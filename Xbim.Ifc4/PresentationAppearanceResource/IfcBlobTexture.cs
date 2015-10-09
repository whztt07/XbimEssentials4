// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCBLOBTEXTURE", 431)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlobTexture : IfcSurfaceTexture, IInstantiableEntity, IEqualityComparer<@IfcBlobTexture>, IEquatable<@IfcBlobTexture>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlobTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _rasterFormat;
		private long _rasterCode;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @RasterFormat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rasterFormat;
				((IPersistEntity)this).Activate(false);
				return _rasterFormat;
			} 
			set
			{
				SetValue( v =>  _rasterFormat = v, _rasterFormat, value,  "RasterFormat");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @RasterCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rasterCode;
				((IPersistEntity)this).Activate(false);
				return _rasterCode;
			} 
			set
			{
				SetValue( v =>  _rasterCode = v, _rasterCode, value,  "RasterCode");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_rasterFormat = value.StringVal;
					return;
				case 6: 
					_rasterCode = value.HexadecimalVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SupportedRasterFormat:	SupportedRasterFormat : SELF.RasterFormat IN ['BMP', 'JPG', 'GIF', 'PNG'];*/
		/*RasterCodeByteStream:	RasterCodeByteStream : BLENGTH(RasterCode) MOD 8 = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBlobTexture other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBlobTexture
            var root = (@IfcBlobTexture)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBlobTexture left, @IfcBlobTexture right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBlobTexture left, @IfcBlobTexture right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBlobTexture x, @IfcBlobTexture y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBlobTexture obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}