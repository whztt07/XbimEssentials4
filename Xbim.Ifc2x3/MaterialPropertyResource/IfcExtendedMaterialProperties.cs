// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IFCEXTENDEDMATERIALPROPERTIES", 585)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExtendedMaterialProperties : IfcMaterialProperties, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcExtendedMaterialProperties>, System.IEquatable<@IfcExtendedMaterialProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtendedMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_extendedProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _extendedProperties;
		private IfcText? _description;
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @ExtendedProperties 
		{ 
			get 
			{
				if(Activated) return _extendedProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _extendedProperties;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
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
					if (_extendedProperties == null) _extendedProperties = new ItemSet<IfcProperty>( this );
					_extendedProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_name = value.StringVal;
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
        public bool Equals(@IfcExtendedMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExtendedMaterialProperties
            var root = (@IfcExtendedMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExtendedMaterialProperties left, @IfcExtendedMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtendedMaterialProperties left, @IfcExtendedMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtendedMaterialProperties x, @IfcExtendedMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtendedMaterialProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}