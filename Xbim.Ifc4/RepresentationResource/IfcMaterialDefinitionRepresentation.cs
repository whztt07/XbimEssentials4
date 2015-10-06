// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.MaterialResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IFCMATERIALDEFINITIONREPRESENTATION", 746)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialDefinitionRepresentation : IfcProductRepresentation, IInstantiableEntity, IEqualityComparer<@IfcMaterialDefinitionRepresentation>, IEquatable<@IfcMaterialDefinitionRepresentation>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialDefinitionRepresentation(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterial _representedMaterial;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterial @RepresentedMaterial 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representedMaterial;
				((IPersistEntity)this).Activate(false);
				return _representedMaterial;
			} 
			set
			{
				SetValue( v =>  _representedMaterial = v, _representedMaterial, value,  "RepresentedMaterial");
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
				case 2: 
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_representedMaterial = (IfcMaterial)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*OnlyStyledRepresentations:                                  )) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialDefinitionRepresentation other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcMaterialDefinitionRepresentation left, @IfcMaterialDefinitionRepresentation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialDefinitionRepresentation left, @IfcMaterialDefinitionRepresentation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialDefinitionRepresentation x, @IfcMaterialDefinitionRepresentation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialDefinitionRepresentation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}