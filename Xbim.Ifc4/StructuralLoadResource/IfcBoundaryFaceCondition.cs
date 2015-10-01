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
	[ExpressType("IFCBOUNDARYFACECONDITION", 440)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryFaceCondition : IfcBoundaryCondition, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcBoundaryFaceCondition>, System.IEquatable<@IfcBoundaryFaceCondition>
	{
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
				if(Activated) return _translationalStiffnessByAreaX;
				
				Model.Activate(this, true);
				Activated = true;
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
				if(Activated) return _translationalStiffnessByAreaY;
				
				Model.Activate(this, true);
				Activated = true;
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
				if(Activated) return _translationalStiffnessByAreaZ;
				
				Model.Activate(this, true);
				Activated = true;
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

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBoundaryFaceCondition
            var root = (@IfcBoundaryFaceCondition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
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