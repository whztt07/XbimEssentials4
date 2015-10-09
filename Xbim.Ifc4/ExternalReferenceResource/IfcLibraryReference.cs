// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCLIBRARYREFERENCE", 724)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryReference : IfcExternalReference, IfcLibrarySelect, IInstantiableEntity, IEqualityComparer<@IfcLibraryReference>, IEquatable<@IfcLibraryReference>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcText? _description;
		private IfcLanguageId? _language;
		private IfcLibraryInformation _referencedLibrary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLanguageId? @Language 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _language;
				((IPersistEntity)this).Activate(false);
				return _language;
			} 
			set
			{
				SetValue( v =>  _language = v, _language, value,  "Language");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLibraryInformation @ReferencedLibrary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencedLibrary;
				((IPersistEntity)this).Activate(false);
				return _referencedLibrary;
			} 
			set
			{
				SetValue( v =>  _referencedLibrary = v, _referencedLibrary, value,  "ReferencedLibrary");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesLibrary> @LibraryRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesLibrary>(e => (e.RelatingLibrary as IfcLibraryReference) == this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_description = value.StringVal;
					return;
				case 4: 
					_language = value.StringVal;
					return;
				case 5: 
					_referencedLibrary = (IfcLibraryInformation)(value.EntityVal);
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
        public bool Equals(@IfcLibraryReference other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLibraryReference
            var root = (@IfcLibraryReference)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLibraryReference left, @IfcLibraryReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLibraryReference left, @IfcLibraryReference right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLibraryReference x, @IfcLibraryReference y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLibraryReference obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}