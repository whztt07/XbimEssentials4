// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCBOUNDARYFACECONDITION", 440)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryFaceCondition : IfcBoundaryCondition, IInstantiableEntity, IEqualityComparer<@IfcBoundaryFaceCondition>, IEquatable<@IfcBoundaryFaceCondition>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryFaceCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaX;
		private IfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaY;
		private IfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionSelect @TranslationalStiffnessByAreaX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _translationalStiffnessByAreaX;
				((IPersistEntity)this).Activate(false);
				return _translationalStiffnessByAreaX;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByAreaX = v, _translationalStiffnessByAreaX, value,  "TranslationalStiffnessByAreaX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionSelect @TranslationalStiffnessByAreaY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _translationalStiffnessByAreaY;
				((IPersistEntity)this).Activate(false);
				return _translationalStiffnessByAreaY;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByAreaY = v, _translationalStiffnessByAreaY, value,  "TranslationalStiffnessByAreaY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionSelect @TranslationalStiffnessByAreaZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _translationalStiffnessByAreaZ;
				((IPersistEntity)this).Activate(false);
				return _translationalStiffnessByAreaZ;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByAreaZ = v, _translationalStiffnessByAreaZ, value,  "TranslationalStiffnessByAreaZ");
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
					_translationalStiffnessByAreaX = (IfcModulusOfSubgradeReactionSelect)(value.EntityVal);
					return;
				case 2: 
					_translationalStiffnessByAreaY = (IfcModulusOfSubgradeReactionSelect)(value.EntityVal);
					return;
				case 3: 
					_translationalStiffnessByAreaZ = (IfcModulusOfSubgradeReactionSelect)(value.EntityVal);
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
        public bool Equals(@IfcBoundaryFaceCondition other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcBoundaryFaceCondition left, @IfcBoundaryFaceCondition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoundaryFaceCondition left, @IfcBoundaryFaceCondition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoundaryFaceCondition x, @IfcBoundaryFaceCondition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoundaryFaceCondition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}