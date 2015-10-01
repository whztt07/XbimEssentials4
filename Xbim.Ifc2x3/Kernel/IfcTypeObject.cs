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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCTYPEOBJECT", 42)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeObject : IfcObjectDefinition, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcTypeObject>, System.IEquatable<@IfcTypeObject>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeObject(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertySets = new OptionalItemSet<IfcPropertySetDefinition>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _applicableOccurrence;
		private OptionalItemSet<IfcPropertySetDefinition> _hasPropertySets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ApplicableOccurrence 
		{ 
			get 
			{
				if(Activated) return _applicableOccurrence;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableOccurrence;
			} 
			set
			{
				SetValue( v =>  _applicableOccurrence = v, _applicableOccurrence, value,  "ApplicableOccurrence");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPropertySetDefinition> @HasPropertySets 
		{ 
			get 
			{
				if(Activated) return _hasPropertySets;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertySets;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByType> @ObjectTypeOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatingType == this);
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_applicableOccurrence = value.StringVal;
					return;
				case 5: 
					if (_hasPropertySets == null) _hasPropertySets = new OptionalItemSet<IfcPropertySetDefinition>( this );
					_hasPropertySets.InternalAdd((IfcPropertySetDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeObject other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcTypeObject left, @IfcTypeObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTypeObject left, @IfcTypeObject right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTypeObject x, @IfcTypeObject y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTypeObject obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}