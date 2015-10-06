// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCSECTIONEDSPINE", 300)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSpine : IfcGeometricRepresentationItem, IInstantiableEntity, IEqualityComparer<@IfcSectionedSpine>, IEquatable<@IfcSectionedSpine>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSpine(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSections = new ItemSet<IfcProfileDef>( this );
			_crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this );
		}

		#region Explicit attribute fields
		private IfcCompositeCurve _spineCurve;
		private ItemSet<IfcProfileDef> _crossSections;
		private ItemSet<IfcAxis2Placement3D> _crossSectionPositions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCompositeCurve @SpineCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spineCurve;
				((IPersistEntity)this).Activate(false);
				return _spineCurve;
			} 
			set
			{
				SetValue( v =>  _spineCurve = v, _spineCurve, value,  "SpineCurve");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSections;
				((IPersistEntity)this).Activate(false);
				return _crossSections;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcAxis2Placement3D> @CrossSectionPositions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionPositions;
				((IPersistEntity)this).Activate(false);
				return _crossSectionPositions;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_spineCurve = (IfcCompositeCurve)(value.EntityVal);
					return;
				case 1: 
					if (_crossSections == null) _crossSections = new ItemSet<IfcProfileDef>( this );
					_crossSections.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 2: 
					if (_crossSectionPositions == null) _crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this );
					_crossSectionPositions.InternalAdd((IfcAxis2Placement3D)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(CrossSections) = SIZEOF(CrossSectionPositions);*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* CrossSections | CrossSections[1].ProfileType <> temp.ProfileType)) = 0;*/
		/*WR3:	WR3 : SpineCurve.Dim = 3;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionedSpine other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcSectionedSpine left, @IfcSectionedSpine right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSectionedSpine left, @IfcSectionedSpine right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSectionedSpine x, @IfcSectionedSpine y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSectionedSpine obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}