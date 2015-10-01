// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELASSIGNS", 902)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelAssigns : IfcRelationship, System.Collections.Generic.IEqualityComparer<@IfcRelAssigns>, System.IEquatable<@IfcRelAssigns>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssigns(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcObjectTypeEnum? _relatedObjectsType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(Activated) return _relatedObjects;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedObjects;
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcObjectTypeEnum? @RelatedObjectsType 
		{ 
			get 
			{
				if(Activated) return _relatedObjectsType;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedObjectsType;
			} 
			set
			{
				SetValue( v =>  _relatedObjectsType = v, _relatedObjectsType, value,  "RelatedObjectsType");
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
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObjectDefinition>( this );
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				case 5: 
                    _relatedObjectsType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : IfcCorrectObjectAssignment(RelatedObjectsType, RelatedObjects);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssigns other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelAssigns left, @IfcRelAssigns right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssigns left, @IfcRelAssigns right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssigns x, @IfcRelAssigns y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssigns obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}