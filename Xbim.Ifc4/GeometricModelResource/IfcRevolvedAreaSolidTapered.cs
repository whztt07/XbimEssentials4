// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCREVOLVEDAREASOLIDTAPERED", 960)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRevolvedAreaSolidTapered>, System.IEquatable<@IfcRevolvedAreaSolidTapered>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRevolvedAreaSolidTapered(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _endSweptArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @EndSweptArea 
		{ 
			get 
			{
				if(Activated) return _endSweptArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _endSweptArea;
			} 
			set
			{
				SetValue( v =>  _endSweptArea = v, _endSweptArea, value,  "EndSweptArea");
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
					_endSweptArea = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectProfileAssignment:	CorrectProfileAssignment : IfcTaperedSweptAreaProfiles(SELF\IfcSweptAreaSolid.SweptArea, SELF.EndSweptArea);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRevolvedAreaSolidTapered other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRevolvedAreaSolidTapered
            var root = (@IfcRevolvedAreaSolidTapered)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRevolvedAreaSolidTapered left, @IfcRevolvedAreaSolidTapered right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRevolvedAreaSolidTapered left, @IfcRevolvedAreaSolidTapered right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRevolvedAreaSolidTapered x, @IfcRevolvedAreaSolidTapered y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRevolvedAreaSolidTapered obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}