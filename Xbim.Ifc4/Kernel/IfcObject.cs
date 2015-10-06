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

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCOBJECT", 774)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObject : IfcObjectDefinition, IEqualityComparer<@IfcObject>, IEquatable<@IfcObject>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObject(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectType;
				((IPersistEntity)this).Activate(false);
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByObject> @IsDeclaredBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByObject> @Declares 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => e.RelatingObject == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByType> @IsTypedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByProperties> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
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
					_objectType = value.StringVal;
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
        public bool Equals(@IfcObject other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcObject left, @IfcObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcObject left, @IfcObject right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcObject x, @IfcObject y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcObject obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}