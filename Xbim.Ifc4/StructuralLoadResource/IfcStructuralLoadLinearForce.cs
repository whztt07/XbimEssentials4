// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADLINEARFORCE", 1026)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadLinearForce : IfcStructuralLoadStatic, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcStructuralLoadLinearForce>, System.IEquatable<@IfcStructuralLoadLinearForce>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadLinearForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLinearForceMeasure? _linearForceX;
		private IfcLinearForceMeasure? _linearForceY;
		private IfcLinearForceMeasure? _linearForceZ;
		private IfcLinearMomentMeasure? _linearMomentX;
		private IfcLinearMomentMeasure? _linearMomentY;
		private IfcLinearMomentMeasure? _linearMomentZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearForceMeasure? @LinearForceX 
		{ 
			get 
			{
				if(Activated) return _linearForceX;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearForceX;
			} 
			set
			{
				SetValue( v =>  _linearForceX = v, _linearForceX, value,  "LinearForceX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearForceMeasure? @LinearForceY 
		{ 
			get 
			{
				if(Activated) return _linearForceY;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearForceY;
			} 
			set
			{
				SetValue( v =>  _linearForceY = v, _linearForceY, value,  "LinearForceY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearForceMeasure? @LinearForceZ 
		{ 
			get 
			{
				if(Activated) return _linearForceZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearForceZ;
			} 
			set
			{
				SetValue( v =>  _linearForceZ = v, _linearForceZ, value,  "LinearForceZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearMomentMeasure? @LinearMomentX 
		{ 
			get 
			{
				if(Activated) return _linearMomentX;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearMomentX;
			} 
			set
			{
				SetValue( v =>  _linearMomentX = v, _linearMomentX, value,  "LinearMomentX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearMomentMeasure? @LinearMomentY 
		{ 
			get 
			{
				if(Activated) return _linearMomentY;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearMomentY;
			} 
			set
			{
				SetValue( v =>  _linearMomentY = v, _linearMomentY, value,  "LinearMomentY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearMomentMeasure? @LinearMomentZ 
		{ 
			get 
			{
				if(Activated) return _linearMomentZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearMomentZ;
			} 
			set
			{
				SetValue( v =>  _linearMomentZ = v, _linearMomentZ, value,  "LinearMomentZ");
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
					_linearForceX = value.RealVal;
					return;
				case 2: 
					_linearForceY = value.RealVal;
					return;
				case 3: 
					_linearForceZ = value.RealVal;
					return;
				case 4: 
					_linearMomentX = value.RealVal;
					return;
				case 5: 
					_linearMomentY = value.RealVal;
					return;
				case 6: 
					_linearMomentZ = value.RealVal;
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
        public bool Equals(@IfcStructuralLoadLinearForce other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadLinearForce
            var root = (@IfcStructuralLoadLinearForce)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadLinearForce left, @IfcStructuralLoadLinearForce right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadLinearForce left, @IfcStructuralLoadLinearForce right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadLinearForce x, @IfcStructuralLoadLinearForce y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadLinearForce obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}