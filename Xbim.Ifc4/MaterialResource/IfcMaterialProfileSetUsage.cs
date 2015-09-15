// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALPROFILESETUSAGE", 363)]
	public  partial class @IfcMaterialProfileSetUsage : IfcMaterialUsageDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSetUsage(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialProfileSet _forProfileSet;
		private IfcCardinalPointReference? _cardinalPoint;
		private IfcPositiveLengthMeasure? _referenceExtent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcMaterialProfileSet @ForProfileSet 
		{ 
			get 
			{
				if(Activated) return _forProfileSet;
				
				Model.Activate(this, true);
				Activated = true;
				return _forProfileSet;
			} 
			set
			{
				SetValue( v =>  _forProfileSet = v, _forProfileSet, value,  "ForProfileSet");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcCardinalPointReference? @CardinalPoint 
		{ 
			get 
			{
				if(Activated) return _cardinalPoint;
				
				Model.Activate(this, true);
				Activated = true;
				return _cardinalPoint;
			} 
			set
			{
				SetValue( v =>  _cardinalPoint = v, _cardinalPoint, value,  "CardinalPoint");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @ReferenceExtent 
		{ 
			get 
			{
				if(Activated) return _referenceExtent;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceExtent;
			} 
			set
			{
				SetValue( v =>  _referenceExtent = v, _referenceExtent, value,  "ReferenceExtent");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ForProfileSet",
			"CardinalPoint",
			"ReferenceExtent",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ForProfileSet;
				case 1: 
					return @CardinalPoint;
				case 2: 
					return @ReferenceExtent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ForProfileSet":  
					return @ForProfileSet;
				case "CardinalPoint":  
					return @CardinalPoint;
				case "ReferenceExtent":  
					return @ReferenceExtent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ForProfileSet = (IfcMaterialProfileSet)value;
					 break;
				case 1:
					 @CardinalPoint = (IfcCardinalPointReference?)value;
					 break;
				case 2:
					 @ReferenceExtent = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ForProfileSet":
					 @ForProfileSet = (IfcMaterialProfileSet)value;
					 break;
				case "CardinalPoint":
					 @CardinalPoint = (IfcCardinalPointReference?)value;
					 break;
				case "ReferenceExtent":
					 @ReferenceExtent = (IfcPositiveLengthMeasure?)value;
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