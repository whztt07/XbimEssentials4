// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCHALFSPACESOLID", 338)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IfcBooleanOperand, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcHalfSpaceSolid>, System.IEquatable<@IfcHalfSpaceSolid>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcHalfSpaceSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _baseSurface;
		private bool _agreementFlag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurface @BaseSurface 
		{ 
			get 
			{
				if(Activated) return _baseSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseSurface;
			} 
			set
			{
				SetValue( v =>  _baseSurface = v, _baseSurface, value,  "BaseSurface");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @AgreementFlag 
		{ 
			get 
			{
				if(Activated) return _agreementFlag;
				
				Model.Activate(this, true);
				Activated = true;
				return _agreementFlag;
			} 
			set
			{
				SetValue( v =>  _agreementFlag = v, _agreementFlag, value,  "AgreementFlag");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_baseSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_agreementFlag = value.BooleanVal;
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
        public bool Equals(@IfcHalfSpaceSolid other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcHalfSpaceSolid left, @IfcHalfSpaceSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcHalfSpaceSolid left, @IfcHalfSpaceSolid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcHalfSpaceSolid x, @IfcHalfSpaceSolid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcHalfSpaceSolid obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}