// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCSURFACECURVESWEPTAREASOLID", 480)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcSurfaceCurveSweptAreaSolid>, System.IEquatable<@IfcSurfaceCurveSweptAreaSolid>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceCurveSweptAreaSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcParameterValue _startParam;
		private IfcParameterValue _endParam;
		private IfcSurface _referenceSurface;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(Activated) return _directrix;
				
				Model.Activate(this, true);
				Activated = true;
				return _directrix;
			} 
			set
			{
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @StartParam 
		{ 
			get 
			{
				if(Activated) return _startParam;
				
				Model.Activate(this, true);
				Activated = true;
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @EndParam 
		{ 
			get 
			{
				if(Activated) return _endParam;
				
				Model.Activate(this, true);
				Activated = true;
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurface @ReferenceSurface 
		{ 
			get 
			{
				if(Activated) return _referenceSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceSurface;
			} 
			set
			{
				SetValue( v =>  _referenceSurface = v, _referenceSurface, value,  "ReferenceSurface");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				case 5: 
					_referenceSurface = (IfcSurface)(value.EntityVal);
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
        public bool Equals(@IfcSurfaceCurveSweptAreaSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceCurveSweptAreaSolid
            var root = (@IfcSurfaceCurveSweptAreaSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceCurveSweptAreaSolid left, @IfcSurfaceCurveSweptAreaSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceCurveSweptAreaSolid left, @IfcSurfaceCurveSweptAreaSolid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceCurveSweptAreaSolid x, @IfcSurfaceCurveSweptAreaSolid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceCurveSweptAreaSolid obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}