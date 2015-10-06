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

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCPROPERTYTEMPLATE", 862)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertyTemplate : IfcPropertyTemplateDefinition, IEqualityComparer<@IfcPropertyTemplate>, IEquatable<@IfcPropertyTemplate>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcComplexPropertyTemplate> @PartOfComplexTemplate 
		{ 
			get 
			{
				return Model.Instances.Where<IfcComplexPropertyTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcPropertySetTemplate> @PartOfPsetTemplate 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertySetTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this));
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
        public bool Equals(@IfcPropertyTemplate other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPropertyTemplate left, @IfcPropertyTemplate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyTemplate left, @IfcPropertyTemplate right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyTemplate x, @IfcPropertyTemplate y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyTemplate obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}