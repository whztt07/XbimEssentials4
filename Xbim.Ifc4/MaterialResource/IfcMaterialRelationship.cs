// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
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

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALRELATIONSHIP", 367)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedMaterials = new ItemSet<IfcMaterial>( this );
		}

		#region Explicit attribute fields
		private IfcMaterial _relatingMaterial;
		private ItemSet<IfcMaterial> _relatedMaterials;
		private IfcLabel? _expression;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcMaterial @RelatingMaterial 
		{ 
			get 
			{
				if(Activated) return _relatingMaterial;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingMaterial;
			} 
			set
			{
				SetValue( v =>  _relatingMaterial = v, _relatingMaterial, value,  "RelatingMaterial");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public ItemSet<IfcMaterial> @RelatedMaterials 
		{ 
			get 
			{
				if(Activated) return _relatedMaterials;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedMaterials;
			} 
			set
			{
				SetValue( v =>  _relatedMaterials = v, _relatedMaterials, value,  "RelatedMaterials");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcLabel? @Expression 
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

		#region Inverse attributes

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
					_relatingMaterial = (IfcMaterial)(value.EntityVal);
					return;
				case 3: 
					if (_relatedMaterials == null) _relatedMaterials = new ItemSet<IfcMaterial>( this );
					_relatedMaterials.InternalAdd((IfcMaterial)value.EntityVal);
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
			return "";
		}
		#endregion
	}
}