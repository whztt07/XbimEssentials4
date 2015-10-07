// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCIMAGETEXTURE", 727)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcImageTexture : IfcSurfaceTexture, IInstantiableEntity, IEqualityComparer<@IfcImageTexture>, IEquatable<@IfcImageTexture>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcImageTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _urlReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @UrlReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _urlReference;
				((IPersistEntity)this).Activate(false);
				return _urlReference;
			} 
			set
			{
				SetValue( v =>  _urlReference = v, _urlReference, value,  "UrlReference");
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
					_urlReference = value.StringVal;
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
        public bool Equals(@IfcImageTexture other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcImageTexture
            var root = (@IfcImageTexture)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcImageTexture left, @IfcImageTexture right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcImageTexture left, @IfcImageTexture right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcImageTexture x, @IfcImageTexture y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcImageTexture obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}