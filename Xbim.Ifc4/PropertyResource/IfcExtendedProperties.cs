// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IFCEXTENDEDPROPERTIES", 631)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcExtendedProperties : IfcPropertyAbstraction, System.Collections.Generic.IEqualityComparer<@IfcExtendedProperties>, System.IEquatable<@IfcExtendedProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtendedProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_properties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _name;
		private IfcText? _description;
		private ItemSet<IfcProperty> _properties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Name 
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @Properties 
		{ 
			get 
			{
				if(Activated) return _properties;
				
				Model.Activate(this, true);
				Activated = true;
				return _properties;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					if (_properties == null) _properties = new ItemSet<IfcProperty>( this );
					_properties.InternalAdd((IfcProperty)value.EntityVal);
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
        public bool Equals(@IfcExtendedProperties other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcExtendedProperties left, @IfcExtendedProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtendedProperties left, @IfcExtendedProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtendedProperties x, @IfcExtendedProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtendedProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}