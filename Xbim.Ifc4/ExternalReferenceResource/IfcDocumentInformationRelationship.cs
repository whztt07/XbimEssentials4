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

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCDOCUMENTINFORMATIONRELATIONSHIP", 579)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformationRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IEqualityComparer<@IfcDocumentInformationRelationship>, IEquatable<@IfcDocumentInformationRelationship>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentInformationRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedDocuments = new ItemSet<IfcDocumentInformation>( this );
		}

		#region Explicit attribute fields
		private IfcDocumentInformation _relatingDocument;
		private ItemSet<IfcDocumentInformation> _relatedDocuments;
		private IfcLabel? _relationshipType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDocumentInformation @RelatingDocument 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingDocument;
				((IPersistEntity)this).Activate(false);
				return _relatingDocument;
			} 
			set
			{
				SetValue( v =>  _relatingDocument = v, _relatingDocument, value,  "RelatingDocument");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDocumentInformation> @RelatedDocuments 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedDocuments;
				((IPersistEntity)this).Activate(false);
				return _relatedDocuments;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @RelationshipType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relationshipType;
				((IPersistEntity)this).Activate(false);
				return _relationshipType;
			} 
			set
			{
				SetValue( v =>  _relationshipType = v, _relationshipType, value,  "RelationshipType");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_relatingDocument = (IfcDocumentInformation)(value.EntityVal);
					return;
				case 3: 
					if (_relatedDocuments == null) _relatedDocuments = new ItemSet<IfcDocumentInformation>( this );
					_relatedDocuments.InternalAdd((IfcDocumentInformation)value.EntityVal);
					return;
				case 4: 
					_relationshipType = value.StringVal;
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
        public bool Equals(@IfcDocumentInformationRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDocumentInformationRelationship
            var root = (@IfcDocumentInformationRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDocumentInformationRelationship left, @IfcDocumentInformationRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentInformationRelationship left, @IfcDocumentInformationRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentInformationRelationship x, @IfcDocumentInformationRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentInformationRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}