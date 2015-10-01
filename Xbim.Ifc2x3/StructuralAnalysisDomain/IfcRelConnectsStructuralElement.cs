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
using Xbim.Ifc2x3.ProductExtension;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IFCRELCONNECTSSTRUCTURALELEMENT", 413)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsStructuralElement : IfcRelConnects, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelConnectsStructuralElement>, System.IEquatable<@IfcRelConnectsStructuralElement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcStructuralMember _relatedStructuralMember;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(Activated) return _relatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingElement;
			} 
			set
			{
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralMember @RelatedStructuralMember 
		{ 
			get 
			{
				if(Activated) return _relatedStructuralMember;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedStructuralMember;
			} 
			set
			{
				SetValue( v =>  _relatedStructuralMember = v, _relatedStructuralMember, value,  "RelatedStructuralMember");
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
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedStructuralMember = (IfcStructuralMember)(value.EntityVal);
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
        public bool Equals(@IfcRelConnectsStructuralElement other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelConnectsStructuralElement left, @IfcRelConnectsStructuralElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsStructuralElement left, @IfcRelConnectsStructuralElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelConnectsStructuralElement x, @IfcRelConnectsStructuralElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelConnectsStructuralElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}