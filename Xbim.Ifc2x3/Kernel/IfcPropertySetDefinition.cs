// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCPROPERTYSETDEFINITION", 97)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertySetDefinition : IfcPropertyDefinition, IEqualityComparer<@IfcPropertySetDefinition>, IEquatable<@IfcPropertySetDefinition>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByProperties> @PropertyDefinitionOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => (e.RelatingPropertyDefinition as IfcPropertySetDefinition) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcTypeObject> @DefinesType 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTypeObject>(e => e.HasPropertySets != null &&  e.HasPropertySets.Contains(this));
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
        public bool Equals(@IfcPropertySetDefinition other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertySetDefinition
            var root = (@IfcPropertySetDefinition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertySetDefinition left, @IfcPropertySetDefinition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertySetDefinition left, @IfcPropertySetDefinition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertySetDefinition x, @IfcPropertySetDefinition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertySetDefinition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}