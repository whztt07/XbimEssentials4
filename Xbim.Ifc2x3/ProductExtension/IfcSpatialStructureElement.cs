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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCSPATIALSTRUCTUREELEMENT", 170)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSpatialStructureElement : IfcProduct, System.Collections.Generic.IEqualityComparer<@IfcSpatialStructureElement>, System.IEquatable<@IfcSpatialStructureElement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpatialStructureElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcElementCompositionEnum _compositionType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(Activated) return _longName;
				
				Model.Activate(this, true);
				Activated = true;
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcElementCompositionEnum @CompositionType 
		{ 
			get 
			{
				if(Activated) return _compositionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _compositionType;
			} 
			set
			{
				SetValue( v =>  _compositionType = v, _compositionType, value,  "CompositionType");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelReferencedInSpatialStructure> @ReferencesElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelReferencedInSpatialStructure>(e => e.RelatingStructure == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelServicesBuildings> @ServicedBySystems 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainsElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatingStructure == this);
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
					_longName = value.StringVal;
					return;
				case 8: 
                    _compositionType = (IfcElementCompositionEnum) System.Enum.Parse(typeof (IfcElementCompositionEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:             );*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpatialStructureElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSpatialStructureElement
            var root = (@IfcSpatialStructureElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSpatialStructureElement left, @IfcSpatialStructureElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSpatialStructureElement left, @IfcSpatialStructureElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSpatialStructureElement x, @IfcSpatialStructureElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSpatialStructureElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}