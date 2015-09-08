﻿using System;
using System.Collections.Generic;
using System.IO;
using Xbim.IO.Parser;
using Xbim.XbimExtensions;
using Xbim.Common.Exceptions;
using System.Collections.Specialized;
using Xbim.Common;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;

namespace Xbim.IO
{
    public static class IPersistEntityExtensions
    {
       

        #region Write the properties of an IPersistEntity to a stream

        /// <summary>
        /// Returns the index value of this type for use in Xbim database storage
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static short IfcTypeId(this  IPersistEntity entity)
        {
            return IfcMetaData.IfcTypeId(entity);
        }

        /// <summary>
        /// Returns the Xbim meta data about the Ifc Properties of the Type
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static IfcType IfcType(this  IPersistEntity entity)
        {
            return IfcMetaData.IfcType(entity);
        }

        public static StringCollection SummaryString(this IPersistEntity entity)
        {
            StringCollection sc = new StringCollection();
            sc.Add("Entity\t = #" + entity.EntityLabel);
            if (entity is IfcRoot)
            {
                IfcRoot root = entity as IfcRoot;
                sc.Add("Guid\t = " + root.GlobalId);
                sc.Add("Type\t = " + root.GetType().Name);
                sc.Add("Name\t = " + (root.Name.HasValue ? root.Name.Value.ToString() : root.ToString()));
            }
            return sc;
        }
       

        internal static void WriteEntity(this IPersistEntity entity, TextWriter tw, byte[] propertyData)
        {
            tw.Write(string.Format("#{0}={1}", entity.EntityLabel, entity.GetType().Name.ToUpper()));
            BinaryReader br = new BinaryReader(new MemoryStream(propertyData));
            P21ParseAction action = (P21ParseAction)br.ReadByte();
            bool comma = false; //the first property
            XbimParserState parserState = new XbimParserState(entity);
            while (action != P21ParseAction.EndEntity)
            {
                switch (action)
                {
                    case P21ParseAction.BeginList:
                        tw.Write("(");
                        break;
                    case P21ParseAction.EndList:
                        tw.Write(")");
                        break;
                    case P21ParseAction.BeginComplex:
                        tw.Write("&SCOPE");
                        break;
                    case P21ParseAction.EndComplex:
                        tw.Write("ENDSCOPE");
                        break;
                    case P21ParseAction.SetIntegerValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write(br.ReadInt64().ToString());
                        break;
                    case P21ParseAction.SetHexValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write(Convert.ToString(br.ReadInt64(),16));
                        break;
                    case P21ParseAction.SetFloatValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write(IfcReal.AsPart21(br.ReadDouble()));
                        break;
                    case P21ParseAction.SetStringValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write(br.ReadString());
                        break;
                    case P21ParseAction.SetEnumValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("." + br.ReadString() + ".");
                        break;
                    case P21ParseAction.SetBooleanValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write(br.ReadBoolean() ? ".T." : ".F.");
                        break;
                    case P21ParseAction.SetNonDefinedValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("$");
                        break;
                    case P21ParseAction.SetOverrideValue:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("*");
                        break;
                    case P21ParseAction.SetObjectValueUInt16:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("#"+ br.ReadUInt16().ToString());
                        break;
                    case P21ParseAction.SetObjectValueInt32:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("#" + br.ReadInt32().ToString());
                        break;
                    case P21ParseAction.SetObjectValueInt64:
                        if (comma) tw.Write(",");
                        comma = true;
                        tw.Write("#" + br.ReadInt64().ToString());
                        break;
                    case P21ParseAction.BeginNestedType:
                        if (comma) tw.Write(",");
                        comma = false;
                        tw.Write(br.ReadString()+"(");
                        break;
                    case P21ParseAction.EndNestedType:
                        comma = true;
                        tw.Write(")");
                        break;
                    case P21ParseAction.EndEntity:
                        tw.Write(");");
                        break;
                    case P21ParseAction.NewEntity:
                        comma = false;
                        tw.Write("(");
                        break;
                    default:
                        throw new Exception("Invalid Property Record #" + entity.EntityLabel + " EntityType: " + entity.GetType().Name);
                }
                action = (P21ParseAction)br.ReadByte();
            }
            tw.WriteLine();
        }
        /// <summary>
        /// Writes the entity to a TextWriter in the Part21 format
        /// </summary>
        /// <param name="entityWriter">The TextWriter</param>
        /// <param name="entity">The entity to write</param>
        internal static void WriteEntity(this IPersistEntity entity, TextWriter entityWriter, IDictionary<int, int> map = null)
        {

            if (map != null && map.Keys.Contains(entity.EntityLabel)) return; //if the entity is replaced in the map do not write it
            entityWriter.Write(string.Format("#{0}={1}(", entity.EntityLabel, entity.GetType().Name.ToUpper()));
            IfcType ifcType = IfcMetaData.IfcType(entity);
            bool first = true;
            
            foreach (IfcMetaProperty ifcProperty in ifcType.IfcProperties.Values)
            //only write out persistent attributes, ignore inverses
            {
                if (ifcProperty.IfcAttribute.State == IfcAttributeState.DerivedOverride)
                {
                    if (!first)
                        entityWriter.Write(',');
                    entityWriter.Write('*');
                    first = false;
                }
                else
                {
                    Type propType = ifcProperty.PropertyInfo.PropertyType;
                    object propVal = ifcProperty.PropertyInfo.GetValue(entity, null);
                    if (!first)
                        entityWriter.Write(',');
                    WriteProperty(propType, propVal, entityWriter, map);
                    first = false;
                }
            }
            entityWriter.WriteLine(");");

        }

        /// <summary>
        /// Writes a property of an entity to the TextWriter in the Part21 format
        /// </summary>
        /// <param name="propType"></param>
        /// <param name="propVal"></param>
        /// <param name="entityWriter"></param>
        private static void WriteProperty(Type propType, object propVal, TextWriter entityWriter,IDictionary<int,int> map)
        {
            Type itemType;
            if (propVal == null) //null or a value type that maybe null
                entityWriter.Write('$');

            else if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
            //deal with undefined types (nullables)
            {
                if (typeof(IExpressComplexType).IsAssignableFrom(propVal.GetType()))
                {
                    entityWriter.Write('(');
                    bool first = true;
                    foreach (var compVal in ((IExpressComplexType)propVal).Properties)
                    {
                        if (!first)
                            entityWriter.Write(',');
                        WriteProperty(compVal.GetType(), compVal, entityWriter,map);
                        first = false;
                    }
                    entityWriter.Write(')');
                }
                else if ((typeof(IExpressType).IsAssignableFrom(propVal.GetType())))
                {
                    IExpressType expressVal = (IExpressType)propVal;
                    WriteValueType(expressVal.UnderlyingSystemType, expressVal.Value, entityWriter);
                }
                else // if (propVal.GetType().IsEnum)
                {
                    WriteValueType(propVal.GetType(), propVal, entityWriter);
                }

            }
            else if (typeof(IExpressComplexType).IsAssignableFrom(propType))
            {
                entityWriter.Write('(');
                bool first = true;
                foreach (var compVal in ((IExpressComplexType)propVal).Properties)
                {
                    if (!first)
                        entityWriter.Write(',');
                    WriteProperty(compVal.GetType(), compVal, entityWriter, map);
                    first = false;
                }
                entityWriter.Write(')');
            }
            else if (typeof(IExpressType).IsAssignableFrom(propType))
            //value types with a single property (IfcLabel, IfcInteger)
            {
                Type realType = propVal.GetType();
                if (realType != propType)
                //we have a type but it is a select type use the actual value but write out explricitly
                {
                    entityWriter.Write(realType.Name.ToUpper());
                    entityWriter.Write('(');
                    WriteProperty(realType, propVal, entityWriter, map);
                    entityWriter.Write(')');
                }
                else //need to write out underlying property value
                {
                    IExpressType expressVal = (IExpressType)propVal;
                    WriteValueType(expressVal.UnderlyingSystemType, expressVal.Value, entityWriter);
                }
            }
            else if (typeof(IExpressEnumerable).IsAssignableFrom(propType) &&
                     (itemType = propType.GetItemTypeFromGenericType()) != null)
            //only process lists that are real lists, see cartesianpoint
            {
                entityWriter.Write('(');
                bool first = true;
                foreach (var item in ((IExpressEnumerable)propVal))
                {
                    if (!first)
                        entityWriter.Write(',');
                    WriteProperty(itemType, item, entityWriter, map);
                    first = false;
                }
                entityWriter.Write(')');
            }
            else if (typeof(IPersistEntity).IsAssignableFrom(propType))
            //all writable entities must support this interface and ExpressType have been handled so only entities left
            {
                entityWriter.Write('#');
                int label = ((IPersistEntity)propVal).EntityLabel;
                int mapLabel;
                if(map!=null &&  map.TryGetValue(label, out mapLabel))
                    label = mapLabel;
                entityWriter.Write(label);
            }
            else if (propType.IsValueType) //it might be an in-built value type double, string etc
            {
                WriteValueType(propVal.GetType(), propVal, entityWriter);
            }
            else if (typeof(IExpressSelectType).IsAssignableFrom(propType))
            // a select type get the type of the actual value
            {
                if (propVal.GetType().IsValueType) //we have a value type, so write out explicitly
                {
                    entityWriter.Write(propVal.GetType().Name.ToUpper());
                    entityWriter.Write('(');
                    WriteProperty(propVal.GetType(), propVal, entityWriter, map);
                    entityWriter.Write(')');
                }
                else //could be anything so re-evaluate actual type
                {
                    WriteProperty(propVal.GetType(), propVal, entityWriter, map);
                }
            }
            else
                throw new Exception(string.Format("Entity  has illegal property {0} of type {1}",
                                                  propType.Name, propType.Name));
        }

        /// <summary>
        /// Writes the value of a property to the TextWriter in the Part 21 format
        /// </summary>
        /// <param name="pInfoType"></param>
        /// <param name="pVal"></param>
        /// <param name="entityWriter"></param>
        private static void WriteValueType(Type pInfoType, object pVal, TextWriter entityWriter)
        {
            if (pInfoType == typeof(Double))
                entityWriter.Write(string.Format(new Part21Formatter(), "{0:R}", pVal));
            else if (pInfoType == typeof(String)) //convert  string
            {
                if (pVal == null)
                    entityWriter.Write('$');
                else
                {
                    entityWriter.Write('\'');
                    entityWriter.Write(IfcText.Escape((string)pVal));
                    entityWriter.Write('\'');
                }
            }
            else if (pInfoType == typeof(Int16) || pInfoType == typeof(Int32) || pInfoType == typeof(Int64))
                entityWriter.Write(pVal.ToString());
            else if (pInfoType.IsEnum) //convert enum
                entityWriter.Write(string.Format(".{0}.", pVal.ToString().ToUpper()));
            else if (pInfoType == typeof(Boolean))
            {
                bool b = false;

                if (pVal != null)
                {
                    b = (bool)pVal;
                    entityWriter.Write(string.Format(".{0}.", b ? "T" : "F"));
                }
            }
            else if (pInfoType == typeof(DateTime)) //convert  TimeStamp
                entityWriter.Write(string.Format(new Part21Formatter(), "{0:T}", pVal));
            else if (pInfoType == typeof(Guid)) //convert  Guid string
            {
                if (pVal == null)
                    entityWriter.Write('$');
                else
                    entityWriter.Write(string.Format(new Part21Formatter(), "{0:G}", pVal));
            }
            else if (pInfoType == typeof(bool?)) //convert  logical
            {
                bool? b = (bool?)pVal;
                entityWriter.Write(!b.HasValue ? ".U." : string.Format(".{0}.", b.Value ? "T" : "F"));
            }
            else
                throw new ArgumentException(string.Format("Invalid Value Type {0}", pInfoType.Name), "pInfoType");
        }

        public static XbimInstanceHandle GetHandle(this IPersistEntity entity)
        {
            return new XbimInstanceHandle(entity);
        }

        public static void WriteEntity(this IPersistEntity entity, BinaryWriter entityWriter)
        {
           
            IfcType ifcType = IfcMetaData.IfcType(entity);
           // entityWriter.Write(Convert.ToByte(P21ParseAction.NewEntity));
            entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
            foreach (IfcMetaProperty ifcProperty in ifcType.IfcProperties.Values)
            //only write out persistent attributes, ignore inverses
            {
                if (ifcProperty.IfcAttribute.State == IfcAttributeState.DerivedOverride)
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetOverrideValue));
                else
                {
                    Type propType = ifcProperty.PropertyInfo.PropertyType;
                    object propVal = ifcProperty.PropertyInfo.GetValue(entity, null);
                    WriteProperty(propType, propVal, entityWriter);
                }
            }
            entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
            entityWriter.Write(Convert.ToByte(P21ParseAction.EndEntity));
        }

        private static  void WriteProperty(Type propType, object propVal, BinaryWriter entityWriter)
        {
            Type itemType;
            if (propVal == null) //null or a value type that maybe null
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetNonDefinedValue));
            else if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
            //deal with undefined types (nullables)
            {
                if (typeof(IExpressComplexType).IsAssignableFrom(propVal.GetType()))
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
                    foreach (var compVal in ((IExpressComplexType)propVal).Properties)
                        WriteProperty(compVal.GetType(), compVal, entityWriter);
                    entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
                }
                else if ((typeof(IExpressType).IsAssignableFrom(propVal.GetType())))
                {
                    IExpressType expressVal = (IExpressType)propVal;
                    WriteValueType(expressVal.UnderlyingSystemType, expressVal.Value, entityWriter);
                }
                else
                {
                    WriteValueType(propVal.GetType(), propVal, entityWriter);
                }
            }
            else if (typeof(IExpressComplexType).IsAssignableFrom(propType))
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
                foreach (var compVal in ((IExpressComplexType)propVal).Properties)
                    WriteProperty(compVal.GetType(), compVal, entityWriter);
                entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
            }
            else if (typeof(IExpressType).IsAssignableFrom(propType))
            //value types with a single property (IfcLabel, IfcInteger)
            {
                Type realType = propVal.GetType();
                if (realType != propType)
                //we have a type but it is a select type use the actual value but write out explicitly
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.BeginNestedType));
                    entityWriter.Write(realType.Name.ToUpper());
                    entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
                    WriteProperty(realType, propVal, entityWriter);
                    entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
                    entityWriter.Write(Convert.ToByte(P21ParseAction.EndNestedType));
                }
                else //need to write out underlying property value
                {
                    IExpressType expressVal = (IExpressType)propVal;
                    WriteValueType(expressVal.UnderlyingSystemType, expressVal.Value, entityWriter);
                }
            }
            else if (typeof(IExpressEnumerable).IsAssignableFrom(propType) &&
                     (itemType = propType.GetItemTypeFromGenericType()) != null)
            //only process lists that are real lists, see cartesianpoint
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
                foreach (var item in ((IExpressEnumerable)propVal))
                    WriteProperty(itemType, item, entityWriter);
                entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
            }
            else if (typeof(IPersistEntity).IsAssignableFrom(propType))
            //all writable entities must support this interface and ExpressType have been handled so only entities left
            {
                int val = ((IPersistEntity)propVal).EntityLabel;
                if (val <= UInt16.MaxValue)
                {
                    entityWriter.Write((byte)P21ParseAction.SetObjectValueUInt16);
                    entityWriter.Write(Convert.ToUInt16(val));
                }
                else if (val <= Int32.MaxValue)
                {
                    entityWriter.Write((byte)P21ParseAction.SetObjectValueInt32);
                    entityWriter.Write(Convert.ToInt32(val));
                }
                //else if (val <= Int64.MaxValue)
                //{
                //    //This is a very large model and it is unlikely we will be able to handle this number of entities,
                //    //it is possible they have just created big labels and it needs to be renumbered
                //    //Entity Label could be redfined as a long bu this is a large overhead if never required, let's see...
                //    throw new XbimException("Entity Label is Init64, this is not currently supported");
                //    //entityWriter.Write((byte)P21ParseAction.SetObjectValueInt64);
                //    //entityWriter.Write(val);
                //}
                else
                    throw new Exception("Entity Label exceeds maximim value for a an int32 long number");
            }
            else if (propType.IsValueType) //it might be an in-built value type double, string etc
            {
                WriteValueType(propVal.GetType(), propVal, entityWriter);
            }
            else if (typeof(IExpressSelectType).IsAssignableFrom(propType))
            // a select type get the type of the actual value
            {
                if (propVal.GetType().IsValueType) //we have a value type, so write out explicitly
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.BeginNestedType));
                    entityWriter.Write(propVal.GetType().Name.ToUpper());
                    entityWriter.Write(Convert.ToByte(P21ParseAction.BeginList));
                    WriteProperty(propVal.GetType(), propVal, entityWriter);
                    entityWriter.Write(Convert.ToByte(P21ParseAction.EndList));
                    entityWriter.Write(Convert.ToByte(P21ParseAction.EndNestedType));
                }
                else //could be anything so re-evaluate actual type
                {
                    WriteProperty(propVal.GetType(), propVal, entityWriter);
                }
            }
            else
                throw new Exception(string.Format("Entity  has illegal property {0} of type {1}",
                                                  propType.Name, propType.Name));
        }

        private static  void WriteValueType(Type pInfoType, object pVal, BinaryWriter entityWriter)
        {
            if (pInfoType == typeof(Double))
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetFloatValue));
                entityWriter.Write((double)pVal);
            }
            else if (pInfoType == typeof(String)) //convert  string
            {
                if (pVal == null)
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetNonDefinedValue));
                else
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetStringValue));
                    entityWriter.Write((string)pVal);
                }
            }
            else if (pInfoType == typeof(Int16))
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetIntegerValue));
                entityWriter.Write((long)(Int16)pVal);
            }
            else if (pInfoType == typeof(Int32))
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetIntegerValue));
                entityWriter.Write((long)(Int32)pVal);
            }
            else if (pInfoType == typeof(Int64))
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetIntegerValue));
                entityWriter.Write((long)pVal);
            }
            else if (pInfoType.IsEnum) //convert enum
            {
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetEnumValue));
                entityWriter.Write(pVal.ToString().ToUpper());
            }
            else if (pInfoType == typeof(Boolean))
            {
                if (pVal == null) //we have a logical
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetNonDefinedValue));
                }
                else
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetBooleanValue));
                    entityWriter.Write((bool)pVal);
                }
            }

            else if (pInfoType == typeof(DateTime)) //convert  TimeStamp
            {
                IfcTimeStamp ts = IfcTimeStamp.ToTimeStamp((DateTime)pVal);
                entityWriter.Write(Convert.ToByte(P21ParseAction.SetIntegerValue));
                entityWriter.Write((long)ts);
            }
            else if (pInfoType == typeof(Guid)) //convert  Guid string
            {
                if (pVal == null)
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetNonDefinedValue));
                else
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetStringValue));
                    entityWriter.Write((string)pVal);
                }
            }
            else if (pInfoType == typeof(bool?)) //convert  logical
            {
                bool? b = (bool?)pVal;
                if (!b.HasValue)
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetNonDefinedValue));
                else
                {
                    entityWriter.Write(Convert.ToByte(P21ParseAction.SetBooleanValue));
                    entityWriter.Write(b.Value);
                }
            }
            else
                throw new ArgumentException(string.Format("Invalid Value Type {0}", pInfoType.Name), "pInfoType");
        }

        /// <summary>
        ///   Writes the in memory data of the entity to a stream
        /// </summary>
        /// <param name = "entityStream"></param>
        /// <param name = "entityWriter"></param>
        /// <param name = "item"></param>
        private static int WriteEntityToSteam(MemoryStream entityStream, BinaryWriter entityWriter, IPersistEntity item)
        {
            entityWriter.Seek(0, SeekOrigin.Begin);
            entityWriter.Write((int)0);
            item.WriteEntity(entityWriter);
            int len = Convert.ToInt32(entityStream.Position);
            entityWriter.Seek(0, SeekOrigin.Begin);
            entityWriter.Write(len);
            entityWriter.Seek(0, SeekOrigin.Begin);
            return len;
        }
        #endregion

        #region Functions to read property data
        /// <summary>
        /// Populates an entites properties from the binary stream
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cache"></param>
        /// <param name="br"></param>
        /// <param name="unCached">If true instances inside the properties are not added to the cache</param>
        /// <param name="fromCache"> If true the instance is read from the cache if not present it is created, used during parsing</param>
        public static void ReadEntityProperties(this IPersistEntity entity, IfcPersistedInstanceCache cache, BinaryReader br, bool unCached = false,bool fromCache = false)
        {
            P21ParseAction action = (P21ParseAction)br.ReadByte();

            XbimParserState parserState = new XbimParserState(entity);
            while (action != P21ParseAction.EndEntity)
            {
                switch (action)
                {
                    case P21ParseAction.BeginList:
                        parserState.BeginList();
                        break;
                    case P21ParseAction.EndList:
                        parserState.EndList();
                        break;
                    case P21ParseAction.BeginComplex:
                        break;
                    case P21ParseAction.EndComplex:
                        break;
                    case P21ParseAction.SetIntegerValue:
                        parserState.SetIntegerValue(br.ReadInt64());
                        break;
                    case P21ParseAction.SetHexValue:
                        parserState.SetHexValue(br.ReadInt64());
                        break;
                    case P21ParseAction.SetFloatValue:
                        parserState.SetFloatValue(br.ReadDouble());
                        break;
                    case P21ParseAction.SetStringValue:
                        parserState.SetStringValue(br.ReadString());
                        break;
                    case P21ParseAction.SetEnumValue:
                        parserState.SetEnumValue(br.ReadString());
                        break;
                    case P21ParseAction.SetBooleanValue:
                        parserState.SetBooleanValue(br.ReadBoolean());
                        break;
                    case P21ParseAction.SetNonDefinedValue:
                        parserState.SetNonDefinedValue();
                        break;
                    case P21ParseAction.SetOverrideValue:
                        parserState.SetOverrideValue();
                        break;
                    case P21ParseAction.SetObjectValueUInt16:
                        if (fromCache)
                        {
                            int label = br.ReadUInt16();
                            IPersistEntity refEntity;
                            if (!parserState.InList && cache.Read.TryGetValue(label, out refEntity)) //if we are in a list then make a forward reference anyway to make sure we maintain list order
                                parserState.SetObjectValue(refEntity);
                            else
                            {
                                cache.AddForwardReference(new IfcForwardReference(label, parserState.CurrentPropertyId, entity));
                                parserState.SkipProperty();
                            }
                        }
                        else
                            parserState.SetObjectValue(cache.GetInstance(br.ReadUInt16(), false, unCached));
                        break;
                    case P21ParseAction.SetObjectValueInt32:
                        if (fromCache)
                        {
                            int label = br.ReadInt32();
                            IPersistEntity refEntity;
                            if (!parserState.InList && cache.Read.TryGetValue(label, out refEntity)) //if we are in a list then make a forward reference anyway to make sure we maintain list order
                                parserState.SetObjectValue(refEntity);
                            else
                            {
                                cache.AddForwardReference(new IfcForwardReference(label, parserState.CurrentPropertyId, entity));
                                parserState.SkipProperty();
                            }
                        }
                        else
                            parserState.SetObjectValue(cache.GetInstance(br.ReadInt32(), false, unCached));
                        break;
                    case P21ParseAction.SetObjectValueInt64:
                        throw new XbimException("Entity Label is int64, this is not currently supported");
                        //parserState.SetObjectValue(cache.GetInstance(br.ReadInt64(), false, unCached));
                        //break;
                    case P21ParseAction.BeginNestedType:
                        parserState.BeginNestedType(br.ReadString());
                        break;
                    case P21ParseAction.EndNestedType:
                        parserState.EndNestedType();
                        break;
                    case P21ParseAction.EndEntity:
                        parserState.EndEntity();
                        break;
                    case P21ParseAction.NewEntity:
                        parserState = new XbimParserState(entity);
                        break;
                    default:
                        throw new XbimException("Invalid Property Record #" + entity.EntityLabel + " EntityType: " + entity.GetType().Name);
                }
                action = (P21ParseAction)br.ReadByte();
            }
        }

        #endregion

        
    }
}
