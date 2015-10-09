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
using Xbim.Ifc2x3.StructuralLoadResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IFCRELCONNECTSSTRUCTURALMEMBER", 321)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsStructuralMember : IfcRelConnects, IInstantiableEntity, IEqualityComparer<@IfcRelConnectsStructuralMember>, IEquatable<@IfcRelConnectsStructuralMember>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralMember(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStructuralMember _relatingStructuralMember;
		private IfcStructuralConnection _relatedStructuralConnection;
		private IfcBoundaryCondition _appliedCondition;
		private IfcStructuralConnectionCondition _additionalConditions;
		private IfcLengthMeasure? _supportedLength;
		private IfcAxis2Placement3D _conditionCoordinateSystem;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralMember @RelatingStructuralMember 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingStructuralMember;
				((IPersistEntity)this).Activate(false);
				return _relatingStructuralMember;
			} 
			set
			{
				SetValue( v =>  _relatingStructuralMember = v, _relatingStructuralMember, value,  "RelatingStructuralMember");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralConnection @RelatedStructuralConnection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedStructuralConnection;
				((IPersistEntity)this).Activate(false);
				return _relatedStructuralConnection;
			} 
			set
			{
				SetValue( v =>  _relatedStructuralConnection = v, _relatedStructuralConnection, value,  "RelatedStructuralConnection");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcBoundaryCondition @AppliedCondition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _appliedCondition;
				((IPersistEntity)this).Activate(false);
				return _appliedCondition;
			} 
			set
			{
				SetValue( v =>  _appliedCondition = v, _appliedCondition, value,  "AppliedCondition");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralConnectionCondition @AdditionalConditions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _additionalConditions;
				((IPersistEntity)this).Activate(false);
				return _additionalConditions;
			} 
			set
			{
				SetValue( v =>  _additionalConditions = v, _additionalConditions, value,  "AdditionalConditions");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @SupportedLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _supportedLength;
				((IPersistEntity)this).Activate(false);
				return _supportedLength;
			} 
			set
			{
				SetValue( v =>  _supportedLength = v, _supportedLength, value,  "SupportedLength");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @ConditionCoordinateSystem 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _conditionCoordinateSystem;
				((IPersistEntity)this).Activate(false);
				return _conditionCoordinateSystem;
			} 
			set
			{
				SetValue( v =>  _conditionCoordinateSystem = v, _conditionCoordinateSystem, value,  "ConditionCoordinateSystem");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingStructuralMember = (IfcStructuralMember)(value.EntityVal);
					return;
				case 5: 
					_relatedStructuralConnection = (IfcStructuralConnection)(value.EntityVal);
					return;
				case 6: 
					_appliedCondition = (IfcBoundaryCondition)(value.EntityVal);
					return;
				case 7: 
					_additionalConditions = (IfcStructuralConnectionCondition)(value.EntityVal);
					return;
				case 8: 
					_supportedLength = value.RealVal;
					return;
				case 9: 
					_conditionCoordinateSystem = (IfcAxis2Placement3D)(value.EntityVal);
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
        public bool Equals(@IfcRelConnectsStructuralMember other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelConnectsStructuralMember
            var root = (@IfcRelConnectsStructuralMember)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelConnectsStructuralMember left, @IfcRelConnectsStructuralMember right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsStructuralMember left, @IfcRelConnectsStructuralMember right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelConnectsStructuralMember x, @IfcRelConnectsStructuralMember y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelConnectsStructuralMember obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}