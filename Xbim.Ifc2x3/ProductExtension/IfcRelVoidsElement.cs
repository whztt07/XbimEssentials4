// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCRELVOIDSELEMENT", 496)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelVoidsElement : IfcRelConnects, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelVoidsElement>, System.IEquatable<@IfcRelVoidsElement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelVoidsElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingBuildingElement;
		private IfcFeatureElementSubtraction _relatedOpeningElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatingBuildingElement 
		{ 
			get 
			{
				if(Activated) return _relatingBuildingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingBuildingElement;
			} 
			set
			{
				SetValue( v =>  _relatingBuildingElement = v, _relatingBuildingElement, value,  "RelatingBuildingElement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcFeatureElementSubtraction @RelatedOpeningElement 
		{ 
			get 
			{
				if(Activated) return _relatedOpeningElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedOpeningElement;
			} 
			set
			{
				SetValue( v =>  _relatedOpeningElement = v, _relatedOpeningElement, value,  "RelatedOpeningElement");
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
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_relatingBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedOpeningElement = (IfcFeatureElementSubtraction)(value.EntityVal);
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

		#region Equality comparers and operators
        public bool Equals(@IfcRelVoidsElement other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelVoidsElement left, @IfcRelVoidsElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelVoidsElement left, @IfcRelVoidsElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelVoidsElement x, @IfcRelVoidsElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelVoidsElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}