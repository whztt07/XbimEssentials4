// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	[ExpressType("IFCCONSTRUCTIONRESOURCE", 157)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResource : IfcResource, IEqualityComparer<@IfcConstructionResource>, IEquatable<@IfcConstructionResource>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _resourceIdentifier;
		private IfcLabel? _resourceGroup;
		private IfcResourceConsumptionEnum? _resourceConsumption;
		private IfcMeasureWithUnit _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @ResourceIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resourceIdentifier;
				((IPersistEntity)this).Activate(false);
				return _resourceIdentifier;
			} 
			set
			{
				SetValue( v =>  _resourceIdentifier = v, _resourceIdentifier, value,  "ResourceIdentifier");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ResourceGroup 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resourceGroup;
				((IPersistEntity)this).Activate(false);
				return _resourceGroup;
			} 
			set
			{
				SetValue( v =>  _resourceGroup = v, _resourceGroup, value,  "ResourceGroup");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcResourceConsumptionEnum? @ResourceConsumption 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resourceConsumption;
				((IPersistEntity)this).Activate(false);
				return _resourceConsumption;
			} 
			set
			{
				SetValue( v =>  _resourceConsumption = v, _resourceConsumption, value,  "ResourceConsumption");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureWithUnit @BaseQuantity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseQuantity;
				((IPersistEntity)this).Activate(false);
				return _baseQuantity;
			} 
			set
			{
				SetValue( v =>  _baseQuantity = v, _baseQuantity, value,  "BaseQuantity");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_resourceIdentifier = value.StringVal;
					return;
				case 6: 
					_resourceGroup = value.StringVal;
					return;
				case 7: 
                    _resourceConsumption = (IfcResourceConsumptionEnum) System.Enum.Parse(typeof (IfcResourceConsumptionEnum), value.EnumVal, true);
					return;
				case 8: 
					_baseQuantity = (IfcMeasureWithUnit)(value.EntityVal);
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
        public bool Equals(@IfcConstructionResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConstructionResource
            var root = (@IfcConstructionResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConstructionResource left, @IfcConstructionResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConstructionResource left, @IfcConstructionResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConstructionResource x, @IfcConstructionResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConstructionResource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}