// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCMAPPEDITEM", 349)]
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"MappingSource",
			"MappingTarget",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @MappingSource;
				case 1: 
					return @MappingTarget;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "MappingSource":  
					return @MappingSource;
				case "MappingTarget":  
					return @MappingTarget;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @MappingSource = (IfcRepresentationMap)value;
					 break;
				case 1:
					 @MappingTarget = (IfcCartesianTransformationOperator)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "MappingSource":
					 @MappingSource = (IfcRepresentationMap)value;
					 break;
				case "MappingTarget":
					 @MappingTarget = (IfcCartesianTransformationOperator)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}