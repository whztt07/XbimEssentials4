// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCRELCONNECTSWITHREALIZINGELEMENTS", 313)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsWithRealizingElements : IfcRelConnectsElements, IInstantiableEntity, IEqualityComparer<@IfcRelConnectsWithRealizingElements>, IEquatable<@IfcRelConnectsWithRealizingElements>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsWithRealizingElements(IModel model) : base(model) 		{ 
			Model = model; 
			_realizingElements = new ItemSet<IfcElement>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcElement> _realizingElements;
		private IfcLabel? _connectionType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcElement> @RealizingElements 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _realizingElements;
				((IPersistEntity)this).Activate(false);
				return _realizingElements;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ConnectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionType;
				((IPersistEntity)this).Activate(false);
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType");
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
					if (_realizingElements == null) _realizingElements = new ItemSet<IfcElement>( this );
					_realizingElements.InternalAdd((IfcElement)value.EntityVal);
					return;
				case 8: 
					_connectionType = value.StringVal;
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
        public bool Equals(@IfcRelConnectsWithRealizingElements other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelConnectsWithRealizingElements
            var root = (@IfcRelConnectsWithRealizingElements)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelConnectsWithRealizingElements left, @IfcRelConnectsWithRealizingElements right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsWithRealizingElements left, @IfcRelConnectsWithRealizingElements right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelConnectsWithRealizingElements x, @IfcRelConnectsWithRealizingElements y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelConnectsWithRealizingElements obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}