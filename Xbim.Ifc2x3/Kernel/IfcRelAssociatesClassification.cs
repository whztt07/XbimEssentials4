// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ExternalReferenceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCRELASSOCIATESCLASSIFICATION", 343)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesClassification : IfcRelAssociates, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelAssociatesClassification>, System.IEquatable<@IfcRelAssociatesClassification>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesClassification(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassificationNotationSelect _relatingClassification;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassificationNotationSelect @RelatingClassification 
		{ 
			get 
			{
				if(Activated) return _relatingClassification;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingClassification;
			} 
			set
			{
				SetValue( v =>  _relatingClassification = v, _relatingClassification, value,  "RelatingClassification");
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
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_relatingClassification = (IfcClassificationNotationSelect)(value.EntityVal);
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
        public bool Equals(@IfcRelAssociatesClassification other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelAssociatesClassification left, @IfcRelAssociatesClassification right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssociatesClassification left, @IfcRelAssociatesClassification right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssociatesClassification x, @IfcRelAssociatesClassification y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssociatesClassification obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}