// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.StructuralLoadResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALACTIVITY", 41)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcStructuralActivity : IfcProduct, IEqualityComparer<@IfcStructuralActivity>, IEquatable<@IfcStructuralActivity>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralActivity(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStructuralLoad _appliedLoad;
		private IfcGlobalOrLocalEnum _globalOrLocal;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralLoad @AppliedLoad 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _appliedLoad;
				((IPersistEntity)this).Activate(false);
				return _appliedLoad;
			} 
			set
			{
				SetValue( v =>  _appliedLoad = v, _appliedLoad, value,  "AppliedLoad");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcGlobalOrLocalEnum @GlobalOrLocal 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _globalOrLocal;
				((IPersistEntity)this).Activate(false);
				return _globalOrLocal;
			} 
			set
			{
				SetValue( v =>  _globalOrLocal = v, _globalOrLocal, value,  "GlobalOrLocal");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IfcRelConnectsStructuralActivity @AssignedToStructuralItem 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcRelConnectsStructuralActivity>(e => e.RelatedStructuralActivity == this);
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_appliedLoad = (IfcStructuralLoad)(value.EntityVal);
					return;
				case 8: 
                    _globalOrLocal = (IfcGlobalOrLocalEnum) System.Enum.Parse(typeof (IfcGlobalOrLocalEnum), value.EnumVal, true);
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
        public bool Equals(@IfcStructuralActivity other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcStructuralActivity left, @IfcStructuralActivity right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralActivity left, @IfcStructuralActivity right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralActivity x, @IfcStructuralActivity y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralActivity obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}