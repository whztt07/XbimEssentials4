// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.QuantityResource;
using Xbim.Ifc4.CostResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[ExpressType("IFCCONSTRUCTIONRESOURCE", 523)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResource : IfcResource, IEqualityComparer<@IfcConstructionResource>, IEquatable<@IfcConstructionResource>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResource(IModel model) : base(model) 		{ 
			Model = model; 
			_baseCosts = new OptionalItemSet<IfcAppliedValue>( this );
		}

		#region Explicit attribute fields
		private IfcResourceTime _usage;
		private OptionalItemSet<IfcAppliedValue> _baseCosts;
		private IfcPhysicalQuantity _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcResourceTime @Usage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usage;
				((IPersistEntity)this).Activate(false);
				return _usage;
			} 
			set
			{
				SetValue( v =>  _usage = v, _usage, value,  "Usage");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcAppliedValue> @BaseCosts 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseCosts;
				((IPersistEntity)this).Activate(false);
				return _baseCosts;
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPhysicalQuantity @BaseQuantity 
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_usage = (IfcResourceTime)(value.EntityVal);
					return;
				case 8: 
					if (_baseCosts == null) _baseCosts = new OptionalItemSet<IfcAppliedValue>( this );
					_baseCosts.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 9: 
					_baseQuantity = (IfcPhysicalQuantity)(value.EntityVal);
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