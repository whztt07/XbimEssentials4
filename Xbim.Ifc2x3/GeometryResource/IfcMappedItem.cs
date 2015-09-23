// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCMAPPEDITEM", 333)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMappedItem : IfcRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMappedItem(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRepresentationMap _mappingSource;
		private IfcCartesianTransformationOperator _mappingTarget;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRepresentationMap @MappingSource 
		{ 
			get 
			{
				if(Activated) return _mappingSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _mappingSource;
			} 
			set
			{
				SetValue( v =>  _mappingSource = v, _mappingSource, value,  "MappingSource");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator @MappingTarget 
		{ 
			get 
			{
				if(Activated) return _mappingTarget;
				
				Model.Activate(this, true);
				Activated = true;
				return _mappingTarget;
			} 
			set
			{
				SetValue( v =>  _mappingTarget = v, _mappingTarget, value,  "MappingTarget");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_mappingSource = (IfcRepresentationMap)(value.EntityVal);
					return;
				case 1: 
					_mappingTarget = (IfcCartesianTransformationOperator)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}