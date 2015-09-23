// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:51
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PropertyResource
{
	[IndexedClass]
	[ExpressType("IFCPROPERTYDEPENDENCYRELATIONSHIP", 852)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyDependencyRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyDependencyRelationship(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProperty _dependingProperty;
		private IfcProperty _dependantProperty;
		private IfcText? _expression;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProperty @DependingProperty 
		{ 
			get 
			{
				if(Activated) return _dependingProperty;
				
				Model.Activate(this, true);
				Activated = true;
				return _dependingProperty;
			} 
			set
			{
				SetValue( v =>  _dependingProperty = v, _dependingProperty, value,  "DependingProperty");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProperty @DependantProperty 
		{ 
			get 
			{
				if(Activated) return _dependantProperty;
				
				Model.Activate(this, true);
				Activated = true;
				return _dependantProperty;
			} 
			set
			{
				SetValue( v =>  _dependantProperty = v, _dependantProperty, value,  "DependantProperty");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Expression 
		{ 
			get 
			{
				if(Activated) return _expression;
				
				Model.Activate(this, true);
				Activated = true;
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_dependingProperty = (IfcProperty)(value.EntityVal);
					return;
				case 3: 
					_dependantProperty = (IfcProperty)(value.EntityVal);
					return;
				case 4: 
					_expression = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : DependingProperty :<>: DependantProperty;*/
		}
		#endregion
	}
}