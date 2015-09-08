#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcXmlReader.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Xbim.IO.Parser;
using Xbim.Common;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.IO.Step21;

#endregion

namespace Xbim.IO
{
     
    public delegate void WriteXMLEntityEventHandler( IPersistEntity entity, int count);

    public class IfcXmlReader
    {
        private static readonly Dictionary<string, StepParserType> primitives;
        private readonly int _transactionBatchSize = 100;
        private Dictionary<string, int> idMap;
        private int lastId;
        static IfcXmlReader()
        {
            primitives = new Dictionary<string, StepParserType>();
            primitives.Add("double-wrapper", StepParserType.Real);
            primitives.Add("long-wrapper", StepParserType.Integer);
            primitives.Add("string-wrapper", StepParserType.String);
            primitives.Add("integer-wrapper", StepParserType.Integer);
            primitives.Add("boolean-wrapper", StepParserType.Boolean);
            primitives.Add("logical-wrapper", StepParserType.Boolean);
            primitives.Add("decimal-wrapper", StepParserType.Real);
            primitives.Add("hexBinary-wrapper", StepParserType.HexaDecimal);
            primitives.Add("base64Binary-wrapper", StepParserType.Entity);
            primitives.Add(typeof(double).Name, StepParserType.Real);
            primitives.Add(typeof(long).Name, StepParserType.Integer);
            primitives.Add(typeof(string).Name, StepParserType.String);
            primitives.Add(typeof(int).Name, StepParserType.Integer);
            primitives.Add(typeof(bool).Name, StepParserType.Boolean);
            primitives.Add("Enum", StepParserType.Enum);

        }

        private abstract class XmlNode 
        {
            public readonly XmlNode Parent;
            public int? Position;
            internal XmlNode()
            {

            }
            public XmlNode(XmlNode parent)
            {
                Parent = parent;
            }

           
        }

        private class XmlEntity : XmlNode
        {
            public IPersistEntity Entity;

            public XmlEntity(XmlNode parent, IPersistEntity ent)
                : base(parent)
            {
                Entity = ent;
            }
        }

        private class XmlExpressType : XmlNode
        {
            private string _value;
            public string Value
            {
                get { return _value; }
                set { _value = value; }
            }
            public readonly Type Type;

            public XmlExpressType(XmlNode parent, Type type)
                : base(parent)
            {
                Type = type;
            }
        }

        private class XmlBasicType : XmlNode
        {
            private string _value;


            public string Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public readonly StepParserType Type;

            public XmlBasicType(XmlNode parent, StepParserType type)
                : base(parent)
            {
                Type = type;
            }
        }

        private class XmlProperty : XmlNode
        {
            public readonly PropertyInfo Property;
            public readonly int PropertyIndex;

            public XmlProperty(XmlNode parent, PropertyInfo prop, int propIndex)
                : base(parent)
            {
                Property = prop;
                PropertyIndex = propIndex;
            }

            public void SetValue(string val, StepParserType parserType)
            {
                if (parserType == StepParserType.Boolean && string.Compare(val, "unknown", true) == 0) //do nothing with IfcLogicals that are undefined
                    return;
                var propVal = new PropertyValue();
                propVal.Init(val, parserType);
                ((XmlEntity)Parent).Entity.IfcParse(PropertyIndex - 1, propVal);
            }

            public void SetValue(object o)
            {
                var propVal = new PropertyValue();
                propVal.Init(o);
                ((XmlEntity)Parent).Entity.IfcParse(PropertyIndex - 1, propVal);
            }
        }

        public enum CollectionType
        {
            List,
            ListUnique,
            Set
        }

        private class XmlUosCollection : XmlCollectionProperty
        {
            public XmlUosCollection()
            {
            }


            internal override void SetCollection(IModel model, XmlReader reader)
            {

            }
        }



        private class XmlCollectionProperty : XmlNode
        {
            internal XmlCollectionProperty()
            {

            }

            public XmlCollectionProperty(XmlNode parent, PropertyInfo prop, int propIndex)
                : base(parent)
            {
                Property = prop;
                PropertyIndex = propIndex;
            }

            public readonly List<XmlNode> Entities = new List<XmlNode>();
            public readonly PropertyInfo Property;
            public CollectionType CType = CollectionType.Set;
            public readonly int PropertyIndex;
            public static int CompareNodes(XmlNode a, XmlNode b)
            {
                if (a.Position > b.Position)
                    return 1;
                else if (a.Position < b.Position)
                    return -1;
                else
                    return 0;
            }

            internal virtual void SetCollection(IModel model, XmlReader reader)
            {
                switch (CType)
                {
                    case CollectionType.List:
                    case CollectionType.ListUnique:
                        Entities.Sort(CompareNodes);
                        break;
                    case CollectionType.Set:
                        break;
                    default:
                        throw new Exception("Unknown list type, " + CType);
                }
                
            }
        }

        private XmlNode _currentNode;
        private int _entitiesParsed = 0;
        private string _expressNamespace;
        private string _cTypeAttribute;
        private string _posAttribute;

        private void StartElement(IfcPersistedInstanceCache cache, XmlReader input, XbimEntityCursor entityTable, XbimLazyDBTransaction transaction)
        {
            var elementName = input.LocalName;
            bool isRefType;
            var id = GetId(input, out isRefType);
           
            IfcType ifcType;
            
            StepParserType parserType;
            IfcMetaProperty prop;
            int propIndex;


            if (id.HasValue && IsIfcEntity(elementName, out ifcType)) //we have an element which is an Ifc Entity
            {
                IPersistEntity ent;
                if (!cache.Contains(id.Value))
                {
                    // not been declared in a ref yet
                    // model.New creates an instance uisng type and id
                    ent = cache.CreateNew(ifcType.Type, id.Value);
                   
                }
                else
                {
                    ent = cache.GetInstance(id.Value, false, true);
                }

                var xmlEnt = new XmlEntity(_currentNode, ent);
               
                //if we have a completely empty element that is not a ref we need to make sure it is written to the database as EndElement will not be called
                if (input.IsEmptyElement && !isRefType)
                {
                    _entitiesParsed++;
                    //now write the entity to the database
                    entityTable.AddEntity(xmlEnt.Entity);
                    if (_entitiesParsed % _transactionBatchSize == (_transactionBatchSize - 1))
                    {
                        transaction.Commit();
                        transaction.Begin();
                    }
                    

                }


                var pos = input.GetAttribute(_posAttribute);
                if (string.IsNullOrEmpty(pos)) pos = input.GetAttribute("pos"); //try without namespace
                if (!string.IsNullOrEmpty(pos))
                    xmlEnt.Position = Convert.ToInt32(pos);
                if (!input.IsEmptyElement)
                {
                    // add the entity to its parent if its parent is a list
                    //if (!(_currentNode is XmlUosCollection) && _currentNode is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                    //    ((XmlCollectionProperty)_currentNode).Entities.Add(xmlEnt);

                    _currentNode = xmlEnt;
                }
                else if (_currentNode is XmlProperty)
                {
                    // if it is a ref then it will be empty element and wont have an end tag
                    // so nither SetValue nor EndElement will be called, so set the value of ref here e.g. #3
                    ((XmlProperty)(_currentNode)).SetValue(ent);
                }
                else if (!(_currentNode is XmlUosCollection) && _currentNode is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                {
                    ((XmlCollectionProperty)_currentNode).Entities.Add(xmlEnt);
                }
            }
            else if (input.IsEmptyElement)
            {
                if (IsIfcProperty(elementName, out propIndex, out prop))
                {
                    var node = new XmlProperty(_currentNode, prop.PropertyInfo, propIndex); ;
                    var propVal = new PropertyValue();
                    var t = node.Property.PropertyType;

                    if (!typeof(IExpressEnumerable).IsAssignableFrom(t)) // if its a empty collection then dont do anything
                    {
                        if (t != null && t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                            t = Nullable.GetUnderlyingType(t);
                        IExpressType et = null;
                        if (t != null && typeof(IExpressType).IsAssignableFrom(t))
                            et = (IExpressType)(Activator.CreateInstance(t));

                        StepParserType pt;
                        if (et != null)
                            pt = primitives[et.UnderlyingSystemType.Name];
                        else
                        {
                            if (t.IsEnum)
                            {
                                pt = StepParserType.Enum;
                            }
                            else
                                pt = primitives[t.Name];
                        }

                        if (pt.ToString().ToLower() == "string")
                            propVal.Init("'" + input.Value + "'", pt);
                        else
                        {
                            if (pt.ToString().ToLower() == "boolean")
                                propVal.Init(Convert.ToBoolean(input.Value) ? ".T." : ".F", pt);
                            else
                                propVal.Init(input.Value, pt);
                        }
                        ((XmlEntity)node.Parent).Entity.IfcParse(node.PropertyIndex - 1, propVal);
                    }

                }
                else if (IsIfcType(elementName, out ifcType))
                {
                    IPersist ent;
                    var param = new object[1];
                    param[0] = ""; // empty element
                    ent = (IPersist)Activator.CreateInstance(ifcType.Type, param);

                    ((XmlProperty)_currentNode).SetValue(ent);
                }

                return;
            }
            else if (!id.HasValue && IsIfcProperty(elementName, out propIndex, out prop)) //we have an element which is a property
            {

                var cType = input.GetAttribute(_cTypeAttribute);
                if (string.IsNullOrEmpty(cType)) cType = input.GetAttribute("cType"); //in case namespace omitted
                if (IsCollection(prop)) //the property is a collection
                {
                    var xmlColl = new XmlCollectionProperty(_currentNode, prop.PropertyInfo, propIndex);
                    switch (cType)
                    {
                        case "list":
                            xmlColl.CType = CollectionType.List;
                            break;
                        case "list-unique":
                            xmlColl.CType = CollectionType.ListUnique;
                            break;
                        case "set":
                            xmlColl.CType = CollectionType.Set;
                            break;
                        default:
                            xmlColl.CType = CollectionType.List;
                            break;
                    }

                    _currentNode = xmlColl;
                }
                else //it is a simple value property;
                {


                    // its parent can be a collection, if yes then this property needs to be added to parent
                    XmlNode n = new XmlProperty(_currentNode, prop.PropertyInfo, propIndex);
                    if (_currentNode is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                        ((XmlCollectionProperty)_currentNode).Entities.Add(n);

                    if (!input.IsEmptyElement) _currentNode = n;
                }
            }
            else if (!id.HasValue && IsIfcType(elementName, out ifcType)) // we have an Ifc ExpressType
            {


                // its parent can be a collection, if yes then this property needs to be added to parent
                XmlNode n = new XmlExpressType(_currentNode, ifcType.Type);
                if (_currentNode is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                    ((XmlCollectionProperty)_currentNode).Entities.Add(n);

                if (!input.IsEmptyElement) _currentNode = n;
            }
            else if (!id.HasValue && IsPrimitiveType(elementName, out parserType)) // we have an basic type i.e. double, bool etc
            {
                // its parent can be a collection, if yes then this property needs to be added to parent
                XmlNode n = new XmlBasicType(_currentNode, parserType);
                if (_currentNode is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                    ((XmlCollectionProperty)_currentNode).Entities.Add(n);

                if (!input.IsEmptyElement) _currentNode = n;
            }
            else
                throw new Exception("Illegal XML element tag");
        }

        private bool IsIfcProperty(string elementName, out int index, out IfcMetaProperty prop)
        {
            IfcType ifcType;
            var xmlEntity = _currentNode as XmlEntity;
            if (xmlEntity != null && !IfcMetaData.TryGetIfcType(elementName.ToUpper(), out ifcType))
            {
                IfcType t = IfcMetaData.IfcType(xmlEntity.Entity);

                foreach (var p in t.IfcProperties)
                {
                    var propIndex = p.Key;
                    if (p.Value.PropertyInfo.Name == elementName)
                    //this is the property to set
                    {
                        prop = p.Value;
                        index = p.Key;
                        return true;
                    }
                }
            }
            prop = null;
            index = -1;
            return false;
        }

        private bool IsCollection(IfcMetaProperty prop)
        {
            return typeof(IExpressEnumerable).IsAssignableFrom(prop.PropertyInfo.PropertyType);
        }

        private bool IsPrimitiveType(string elementName, out StepParserType basicType)
        {
            return primitives.TryGetValue(elementName, out basicType); //we have a primitive type

        }

        private bool IsIfcType(string elementName, out IfcType ifcType)
        {
            var ok = IfcMetaData.TryGetIfcType(elementName.ToUpper(), out ifcType);
            if (!ok)
            {

                if (elementName.Contains("-wrapper") && elementName.StartsWith(_expressNamespace) == false) // we have an inline type definition
                {
                    var inputName = elementName.Substring(0, elementName.LastIndexOf("-"));
                    ok = IfcMetaData.TryGetIfcType(inputName.ToUpper(), out ifcType);
                }
            }
            return ok && typeof(IExpressType).IsAssignableFrom(ifcType.Type);
        }

        private int? GetId(XmlReader input, out bool isRefType)
        {
            isRefType = false;
            int? nextId = null;
            IfcType ifcType;
            var strId = input.GetAttribute("id");
            if (string.IsNullOrEmpty(strId))
            {
                strId = input.GetAttribute("ref");
                if (!string.IsNullOrEmpty(strId)) isRefType = true;
            }
            if (!string.IsNullOrEmpty(strId)) //must be a new instance or a reference to an existing one  
            {
                int lookup;
                if (!idMap.TryGetValue(strId, out lookup))
                {
                    ++lastId;
                    nextId = lastId;
                    idMap.Add(strId, nextId.Value);
                }
                else
                    nextId = lookup;
                // if we have id or refid then remove letters and get the number part
                //Match match = Regex.Match(strId, @"\d+");

                //if (!match.Success)
                //    throw new Exception(String.Format("Illegal entity id: {0}", strId));
                //return Convert.ToInt32(match.Value);
                
            }
            else if (IsIfcEntity(input.LocalName, out ifcType) && !typeof(IExpressType).IsAssignableFrom(ifcType.Type)) //its a type with no identity, make one
            {
                ++lastId;
                nextId = lastId;
            }
            
            return nextId;
        }

        private bool IsIfcEntity(string elementName, out IfcType ifcType)
        {

            return IfcMetaData.TryGetIfcType(elementName.ToUpper(), out ifcType);
        }

        private void EndElement(XmlReader input, XmlNodeType prevInputType, string prevInputName, out IPersistEntity writeEntity)
        {
            try
            {
                // before end element, we need to deal with SetCollection
                if (_currentNode is XmlCollectionProperty)
                {
                    // SetCollection will handle SetValue for Collection
                    var CType = ((XmlCollectionProperty)_currentNode).CType;
                    switch (CType)
                    {
                        case CollectionType.List:
                        case CollectionType.ListUnique:
                            ((XmlCollectionProperty)_currentNode).Entities.Sort(XmlCollectionProperty.CompareNodes);
                            break;
                        case CollectionType.Set:
                            break;
                        default:
                            throw new Exception("Unknown list type, " + CType);
                    }

                    foreach (var item in ((XmlCollectionProperty)_currentNode).Entities)
                    {

                        if (item is XmlEntity)
                        {
                            var node = (XmlEntity)item;
                            var collectionOwner = item.Parent.Parent as XmlEntity;
                            var collection = item.Parent as XmlCollectionProperty; //the collection to add to;
                            IPersist ifcCollectionOwner = collectionOwner.Entity;
                            var pv = new PropertyValue();
                            pv.Init(node.Entity);
                            ifcCollectionOwner.IfcParse(collection.PropertyIndex - 1, pv);
                                                        
                        }

                    }                    
                }
                else if (_currentNode.Parent is XmlProperty)
                {
                    var propNode = (XmlProperty)_currentNode.Parent;
                    if (_currentNode is XmlEntity)
                    {
                        var entityNode = (XmlEntity)_currentNode;
                        propNode.SetValue(entityNode.Entity);
                    }
                    else if (_currentNode is XmlExpressType)
                    {
                        //create ExpressType, call ifcparse with propindex and object
                        //((XmlProperty)_currentNode.Parent).SetValue((XmlExpressType)_currentNode);

                        var expressNode = (XmlExpressType)_currentNode;
                        if (expressNode.Type != propNode.Property.PropertyType)
                        {
                            //propNode.SetValue(expressNode);
                            IfcType ifcType;
                            if (IsIfcType(input.LocalName, out ifcType))
                            //we have an IPersistIfc
                            {
                                IPersist ent;
                                var param = new object[1];
                                param[0] = expressNode.Value;
                                ent = (IPersist)Activator.CreateInstance(ifcType.Type, param);

                                propNode.SetValue(ent);
                            }
                        }
                        else
                        {
                            propNode.SetValue(expressNode.Value, primitives[expressNode.Type.Name]);
                        }
                    }
                    else if (_currentNode is XmlBasicType)
                    {
                        //set PropertyValue to write type boolean, integer, call ifcparse with string

                        var basicNode = (XmlBasicType)_currentNode;
                        propNode.SetValue(basicNode.Value, basicNode.Type);
                    }
                }


                else if (prevInputType == XmlNodeType.Element && prevInputName == input.LocalName &&
                    _currentNode is XmlProperty && _currentNode.Parent != null && _currentNode.Parent is XmlEntity)
                {
                    // WE SHOULDNT EXECUTE THE FOLLOWING CODE IF THIS PROPERTY ALREADY CALLED SETVALUE
                    var node = (XmlProperty)_currentNode;
                    var propVal = new PropertyValue();
                    var t = node.Property.PropertyType;
                    if (t != null && t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                        t = Nullable.GetUnderlyingType(t);
                    IExpressType et = null;
                    if (t != null && typeof(IExpressType).IsAssignableFrom(t))
                        et = (IExpressType)(Activator.CreateInstance(t));

                    var pt = StepParserType.Undefined;
                    if (et != null)
                        pt = primitives[et.UnderlyingSystemType.Name];
                    else
                    {
                        if (t.IsEnum)
                        {
                            pt = StepParserType.Enum;
                        }
                        else if (primitives.ContainsKey(t.Name))
                            pt = primitives[t.Name];
                    }

                    if (pt != StepParserType.Undefined)
                    {
                        if (pt.ToString().ToLower() == "string")
                            propVal.Init("'" + input.Value + "'", pt);
                        else
                        {
                            if (pt.ToString().ToLower() == "boolean")
                                propVal.Init(Convert.ToBoolean(input.Value) ? ".T." : ".F", pt);
                            else
                                propVal.Init(input.Value, pt);
                        }

                        ((XmlEntity)node.Parent).Entity.IfcParse(node.PropertyIndex - 1, propVal);
                    }


                }

                else if (_currentNode.Parent is XmlCollectionProperty && !(_currentNode.Parent is XmlUosCollection))
                {
                    if (_currentNode is XmlEntity)
                    {
                        ((XmlCollectionProperty)_currentNode.Parent).Entities.Add(((XmlEntity)_currentNode));
                    }
                    else if (_currentNode is XmlExpressType)
                    {
                        var expressNode = (XmlExpressType)_currentNode;
                        //actualEntityType is the actual type of the value to create
                        var actualEntityType = expressNode.Type;
                        //Determine if the Express Type is a Nullable, if so get the type of the Nullable
                        if (actualEntityType.IsGenericType && actualEntityType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                            actualEntityType = Nullable.GetUnderlyingType(actualEntityType);

                        //need to resolve what the Parser type is
                        //if the generic type of the collection is different from the actualEntityType then we need to create an entity and call Ifc Parse
                        //otherwise we need to call Ifcparse with a string value and the type of the underlying type
                        var collection = _currentNode.Parent as XmlCollectionProperty; //the collection to add to;
                        var collectionValueType = collection.Property.PropertyType;
                        var collectionGenericType = GetItemTypeFromGenericType(collectionValueType); ;
                        var genericTypeIsSameAsValueType = (collectionGenericType == actualEntityType);
                        var pv = new PropertyValue();

                        if (genericTypeIsSameAsValueType) //call IfcParse with string value and parser type
                        {
                            var actualEntityValue = (IExpressType)(Activator.CreateInstance(actualEntityType));
                            //resolve the underlying type
                            var parserType = primitives[actualEntityValue.UnderlyingSystemType.Name];
                            if (parserType == StepParserType.String)
                                pv.Init("'" + expressNode.Value + "'", parserType);
                            else
                                pv.Init(expressNode.Value, parserType);
                        }
                        else //call IfcParse with an entity
                        {
                            var param = new object[1];
                            param[0] = expressNode.Value;
                            var actualEntityValue = (IExpressType)(Activator.CreateInstance(expressNode.Type, param));
                            pv.Init(actualEntityValue);
                        }

                        var collectionOwner = _currentNode.Parent.Parent as XmlEntity; //go to owner of collection
                        IPersist ifcCollectionOwner = collectionOwner.Entity;
                        ifcCollectionOwner.IfcParse(collection.PropertyIndex - 1, pv);

                    }
                    else if (_currentNode is XmlBasicType)
                    {
                        var basicNode = (XmlBasicType)_currentNode;
                        var collectionOwner = _currentNode.Parent.Parent as XmlEntity;
                        var collection = _currentNode.Parent as XmlCollectionProperty; //the collection to add to;
                        IPersist ifcCollectionOwner = collectionOwner.Entity;
                        var pv = new PropertyValue();
                        pv.Init(basicNode.Value, basicNode.Type);
                        ifcCollectionOwner.IfcParse(collection.PropertyIndex - 1, pv);
                    }


                }


                writeEntity = null;
                if (_currentNode.Parent != null) // we are not at UOS yet
                {
                    if (_currentNode is XmlEntity)
                        writeEntity = ((XmlEntity)_currentNode).Entity;
                    _currentNode = _currentNode.Parent;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error reading IfcXML data at node " + input.LocalName, e);
            }
        }

        public Type GetItemTypeFromGenericType(Type genericType)
        {
            if (genericType == typeof(ICoordinateList))
                return typeof(IfcLengthMeasure); //special case for coordinates
            if (genericType.IsGenericType || genericType.IsInterface)
            {
                var genericTypes = genericType.GetGenericArguments();
                if (genericTypes.GetUpperBound(0) >= 0)
                    return genericTypes[genericTypes.GetUpperBound(0)];
                return null;
            }
            if (genericType.BaseType != null)
                return GetItemTypeFromGenericType(genericType.BaseType);
            return null;
        }

        private void SetValue(XmlReader input, XmlNodeType prevInputType, string prevInputName)
        {
            try
            {
                // we are here because this node is of type Text or WhiteSpace
                if (prevInputType == XmlNodeType.Element) // previous node should be of Type Element before we go next
                {
                    if (_currentNode is XmlExpressType)
                    {
                        var node = (XmlExpressType)_currentNode;
                        node.Value = input.Value;
                    }
                    else if (_currentNode is XmlBasicType)
                    {
                        var node = (XmlBasicType)_currentNode;
                        node.Value = input.Value;

                    }
                    else if (_currentNode is XmlProperty)
                    {
                        var node = (XmlProperty)_currentNode;
                        var propVal = new PropertyValue();
                        var t = node.Property.PropertyType;
                        if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                            t = Nullable.GetUnderlyingType(t);
                       

                        // if the propertytype is abstract, we cant possibly set any text value on it
                        // effectively this ignores white spaces, e.g. NominalValue of IfcPropertySingleValue
                        if (!t.IsAbstract)
                        {
                            StepParserType parserType;
                            if (typeof(IExpressType).IsAssignableFrom(t) && !(typeof(IExpressComplexType).IsAssignableFrom(t) ))
                            {
                                var et = (IExpressType)(Activator.CreateInstance(t));
                                if (et.GetType() == typeof(IfcLogical))
                                    parserType = StepParserType.Boolean;
                                else
                                    parserType = primitives[et.UnderlyingSystemType.Name];
                            }
                            else if (t.IsEnum)
                            {
                                parserType = StepParserType.Enum;
                            }
                            else 
                            {
                                if (!primitives.TryGetValue(t.Name, out parserType))
                                    parserType = StepParserType.Undefined;
                            }

                            if (parserType == StepParserType.String)
                            {
                                propVal.Init("'" + input.Value + "'", parserType);
                                ((XmlEntity)node.Parent).Entity.IfcParse(node.PropertyIndex - 1, propVal);
                            }
                            else if (parserType != StepParserType.Undefined && !string.IsNullOrWhiteSpace(input.Value))
                            {
                                if (parserType == StepParserType.Boolean)
                                {
                                    if(string.Compare(input.Value, "unknown", true) != 0) //do nothing with IfcLogicals that are undefined
                                        propVal.Init(Convert.ToBoolean(input.Value) ? ".T." : ".F.", parserType);
                                }
                                else
                                    propVal.Init(input.Value, parserType);

                                ((XmlEntity)node.Parent).Entity.IfcParse(node.PropertyIndex - 1, propVal);
                            }

                            
                        }
                    }
                }
                

            }
            catch (Exception e)
            {
                throw new Exception("Error reading IfcXML data at node " + input.LocalName, e);
            }
        }



        internal IfcFileHeader Read(IfcPersistedInstanceCache instanceCache, XbimEntityCursor entityTable,  XmlReader input)
        {
           
            // Read until end of file
            idMap = new Dictionary<string, int>();
            lastId = 0;
            _entitiesParsed = 0;
            var foundHeader = false;
            var header = new IfcFileHeader(IfcFileHeader.HeaderCreationMode.LeaveEmpty);
            var headerId="";
            while (_currentNode == null && input.Read()) //read through to UOS
            {
                switch (input.NodeType)
                {
                    case XmlNodeType.Element:
                        if (string.Compare(input.LocalName, "uos", true) == 0)
                        {
                            _currentNode = new XmlUosCollection();
                           
                        }
                        else if (string.Compare(input.LocalName, "iso_10303_28", true) == 0)
                        {
                            foundHeader = true;
                           
                            if (!string.IsNullOrWhiteSpace(input.Prefix))
                            {
                                _expressNamespace = input.Prefix;
                                _cTypeAttribute = _expressNamespace + ":cType";
                                _posAttribute = _expressNamespace + ":pos";
                                _expressNamespace += ":";
                            }
                            else
                            {
                                _cTypeAttribute = "cType";
                                _posAttribute = "pos";
                            } //correct the values if the namespace is defined correctly
                            while (input.MoveToNextAttribute())
                            {
                                if (input.Value == "urn:oid:1.0.10303.28.2.1.1" ||
                                    input.Value =="urn:iso.org:standard:10303:part(28):version(2):xmlschema:common")
                                {
                                    _expressNamespace = input.LocalName;
                                    _cTypeAttribute = _expressNamespace + ":cType";
                                    _posAttribute = _expressNamespace + ":pos";
                                    _expressNamespace += ":";
                                    break;
                                }  
                            }
                        }
                        else
                        {
                            headerId = input.LocalName.ToLower();
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (headerId)
                        {
                            case "name":
                                header.FileName.Name = input.Value;
                                break;
                            case "time_stamp":
                                header.FileName.TimeStamp= input.Value;
                                break;
                            case "author":
                                header.FileName.AuthorName.Add(input.Value);
                                break;
                            case "organization":
                                header.FileName.Organization.Add(input.Value);
                                break;
                            case "preprocessor_version":
                                header.FileName.PreprocessorVersion = input.Value;
                                break;
                            case "originating_system":
                                header.FileName.OriginatingSystem = input.Value;
                                break;
                            case "authorization":
                                header.FileName.AuthorizationName = input.Value;
                                break;
                            case "documentation":
                                header.FileDescription.Description.Add(input.Value);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
               
            }
            if (!foundHeader)
                throw new Exception("Invalid XML format, iso_10303_28 tag not found");
           
            var prevInputType = XmlNodeType.None;
            var prevInputName = "";

            // set counter for start of every element that is not empty, and reduce it on every end of that element


           
            try
            {
                using (var transaction = entityTable.BeginLazyTransaction())
                {


                    // this will create id of each element
                    var ids = new Dictionary<string, int>();
                    while (input.Read())
                    {
                        switch (input.NodeType)
                        {
                            case XmlNodeType.Element:
                                StartElement(instanceCache, input, entityTable, transaction);
                                break;
                            case XmlNodeType.EndElement:
                                IPersistEntity toWrite;
                                //if toWrite has a value we have completed an Ifc Entity
                                EndElement(input, prevInputType, prevInputName, out toWrite);
                                if (toWrite != null)
                                {
                                    _entitiesParsed++;
                                    //now write the entity to the database
                                    entityTable.AddEntity(toWrite);
                                    if (_entitiesParsed % _transactionBatchSize == (_transactionBatchSize - 1))
                                    {
                                        transaction.Commit();
                                        transaction.Begin();
                                    }
                                }
                                break;
                            case XmlNodeType.Whitespace:
                                SetValue(input, prevInputType, prevInputName);
                                break;
                            case XmlNodeType.Text:
                                SetValue(input, prevInputType, prevInputName);
                                break;
                            default:
                                break;
                        }
                        prevInputType = input.NodeType;
                        prevInputName = input.LocalName;
                    }
                    transaction.Commit();
                }
            }
            catch(Exception e)
            {
                throw new Exception(String.Format("Error reading XML, Line={0}, Position={1}, Tag='{2}'", ((IXmlLineInfo) input).LineNumber, ((IXmlLineInfo) input).LinePosition, input.LocalName), e);
            }
            return header;
        }
    }
}