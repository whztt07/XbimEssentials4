// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCCLASSIFICATIONREFERENCE", 209)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationReference : IfcExternalReference, IfcClassificationNotationSelect, IInstantiableEntity, IEqualityComparer<@IfcClassificationReference>, IEquatable<@IfcClassificationReference>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassification _referencedSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassification @ReferencedSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencedSource;
				((IPersistEntity)this).Activate(false);
				return _referencedSource;
			} 
			set
			{
				SetValue( v =>  _referencedSource = v, _referencedSource, value,  "ReferencedSource");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_referencedSource = (IfcClassification)(value.EntityVal);
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
        public bool Equals(@IfcClassificationReference other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcClassificationReference left, @IfcClassificationReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcClassificationReference left, @IfcClassificationReference right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcClassificationReference x, @IfcClassificationReference y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcClassificationReference obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}