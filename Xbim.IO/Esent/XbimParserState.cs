using System;
using System.Collections.Generic;
using System.Reflection;
using Xbim.Common;
using Xbim.IO.Parser;

namespace Xbim.IO.Esent
{
    public class XbimParserState
    {

        public XbimParserState(IPersistEntity entity)
        {
            _currentInstance = new Part21Entity(entity);
            _processStack.Push(_currentInstance);
            _schemaModule = entity.GetType().Module;
        }

        private readonly Stack<Part21Entity> _processStack = new Stack<Part21Entity>();
        private int _listNestLevel = -1;
        private Part21Entity _currentInstance;
        private readonly Module _schemaModule;
        private readonly IndexPropertyValue _propertyValue = new IndexPropertyValue();

        public void BeginList()
        {
            var p21 = _processStack.Peek();
            if (p21.CurrentParamIndex == -1)
                p21.CurrentParamIndex++; //first time in take the first argument

            _listNestLevel++;
        }

        public void EndList()
        {
            _listNestLevel--;
            var p21 = _processStack.Peek();
            p21.CurrentParamIndex++;
            //Console.WriteLine("EndList");
        }

        public void EndEntity()
        {
            _processStack.Pop();
            //Debug.Assert(_processStack.Count == 0);
        }

        internal void BeginNestedType(string typeName)
        {
            var type = ExpressMetaData.ExpressType(typeName, _schemaModule);
            _currentInstance = new Part21Entity((IPersist)Activator.CreateInstance(type.Type));
            _processStack.Push(_currentInstance);
        }

        internal void EndNestedType()
        {
            _propertyValue.Init(_processStack.Pop().Entity);
            _currentInstance = _processStack.Peek();
            if (_currentInstance.Entity != null)
                _currentInstance.ParameterSetter(_currentInstance.CurrentParamIndex, _propertyValue);
            if (_listNestLevel == 0) _currentInstance.CurrentParamIndex++;
        }

        private void SetEntityParameter()
        {
            if (_currentInstance.Entity != null)
            {
                //CurrentInstance.SetPropertyValue(PropertyValue);
                try
                {
                    _currentInstance.ParameterSetter(_currentInstance.CurrentParamIndex, _propertyValue);
                }
                catch (Exception e)
                {
                    XbimModel.Logger.ErrorFormat("Parser error, the Attribute {0} of {1} is incorrectly specified and has been ignored. {2}",
                       _currentInstance.CurrentParamIndex,
                        _currentInstance.Entity.GetType().Name,
                        e.Message);
                }
               
            }
            if (_listNestLevel == 0)
                _currentInstance.CurrentParamIndex++;
        }

        internal void SetIntegerValue(long value)
        {
            _propertyValue.Init(value, StepParserType.Integer);
            SetEntityParameter();
        }

        internal void SetHexValue(double value)
        {
            _propertyValue.Init(value, StepParserType.HexaDecimal);
            SetEntityParameter();
        }

        internal void SetFloatValue(double value)
        {
            _propertyValue.Init(value, StepParserType.Real);
            SetEntityParameter();
        }

        internal void SetStringValue(string value)
        {

            _propertyValue.Init(value, StepParserType.String);
            SetEntityParameter();
        }

        internal void SetEnumValue(string value)
        {
            _propertyValue.Init(value, StepParserType.Enum);
            SetEntityParameter();
        }

        internal void SetBooleanValue(bool value)
        {
            _propertyValue.Init(value, StepParserType.Boolean);
            SetEntityParameter();
        }

        internal void SetNonDefinedValue()
        {
            if (_listNestLevel == 0) _currentInstance.CurrentParamIndex++;
        }

        internal void SetOverrideValue()
        {
            if (_listNestLevel == 0) _currentInstance.CurrentParamIndex++;
        }

        internal void SetObjectValue(IPersist value)
        {
            _propertyValue.Init(value);
            //CurrentInstance.SetPropertyValue(PropertyValue);
            _currentInstance.Entity.Parse(_currentInstance.CurrentParamIndex, _propertyValue);
            if (_listNestLevel == 0) _currentInstance.CurrentParamIndex++;
        }

        internal void SkipProperty()
        {
            if (_listNestLevel == 0) _currentInstance.CurrentParamIndex++;
        }

        internal ExpressMetaProperty CurrentProperty
        {
            get
            {
                return ExpressMetaData.ExpressType(_currentInstance.Entity).Properties[_currentInstance.CurrentParamIndex+1];
            }
        }
        internal short CurrentPropertyId
        {
            get
            {
                return (short) _currentInstance.CurrentParamIndex;
            }
        }

        /// <summary>
        /// Returns true if the parser is working through a list of items
        /// </summary>
        public bool InList 
        {
            get
            {
                return _listNestLevel > 0;
            }
        }
    }
}
