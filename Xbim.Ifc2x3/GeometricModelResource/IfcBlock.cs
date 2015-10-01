// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCBLOCK", 702)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlock : IfcCsgPrimitive3D, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcBlock>, System.IEquatable<@IfcBlock>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlock(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xLength;
		private IfcPositiveLengthMeasure _yLength;
		private IfcPositiveLengthMeasure _zLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @XLength 
		{ 
			get 
			{
				if(Activated) return _xLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _xLength;
			} 
			set
			{
				SetValue( v =>  _xLength = v, _xLength, value,  "XLength");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @YLength 
		{ 
			get 
			{
				if(Activated) return _yLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _yLength;
			} 
			set
			{
				SetValue( v =>  _yLength = v, _yLength, value,  "YLength");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @ZLength 
		{ 
			get 
			{
				if(Activated) return _zLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _zLength;
			} 
			set
			{
				SetValue( v =>  _zLength = v, _zLength, value,  "ZLength");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_xLength = value.RealVal;
					return;
				case 2: 
					_yLength = value.RealVal;
					return;
				case 3: 
					_zLength = value.RealVal;
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
        public bool Equals(@IfcBlock other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBlock
            var root = (@IfcBlock)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBlock left, @IfcBlock right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBlock left, @IfcBlock right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBlock x, @IfcBlock y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBlock obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}