// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Kernel;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCDOCUMENTINFORMATION", 578)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformation : IfcExternalInformation, IfcDocumentSelect, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcDocumentInformation>, System.IEquatable<@IfcDocumentInformation>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentInformation(IModel model) : base(model) 		{ 
			Model = model; 
			_editors = new OptionalItemSet<IfcActorSelect>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier _identification;
		private IfcLabel _name;
		private IfcText? _description;
		private IfcURIReference? _location;
		private IfcText? _purpose;
		private IfcText? _intendedUse;
		private IfcText? _scope;
		private IfcLabel? _revision;
		private IfcActorSelect _documentOwner;
		private OptionalItemSet<IfcActorSelect> _editors;
		private IfcDateTime? _creationTime;
		private IfcDateTime? _lastRevisionTime;
		private IfcIdentifier? _electronicFormat;
		private IfcDate? _validFrom;
		private IfcDate? _validUntil;
		private IfcDocumentConfidentialityEnum? _confidentiality;
		private IfcDocumentStatusEnum? _status;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @Identification 
		{ 
			get 
			{
				if(Activated) return _identification;
				
				Model.Activate(this, true);
				Activated = true;
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcURIReference? @Location 
		{ 
			get 
			{
				if(Activated) return _location;
				
				Model.Activate(this, true);
				Activated = true;
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Purpose 
		{ 
			get 
			{
				if(Activated) return _purpose;
				
				Model.Activate(this, true);
				Activated = true;
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @IntendedUse 
		{ 
			get 
			{
				if(Activated) return _intendedUse;
				
				Model.Activate(this, true);
				Activated = true;
				return _intendedUse;
			} 
			set
			{
				SetValue( v =>  _intendedUse = v, _intendedUse, value,  "IntendedUse");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Scope 
		{ 
			get 
			{
				if(Activated) return _scope;
				
				Model.Activate(this, true);
				Activated = true;
				return _scope;
			} 
			set
			{
				SetValue( v =>  _scope = v, _scope, value,  "Scope");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Revision 
		{ 
			get 
			{
				if(Activated) return _revision;
				
				Model.Activate(this, true);
				Activated = true;
				return _revision;
			} 
			set
			{
				SetValue( v =>  _revision = v, _revision, value,  "Revision");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @DocumentOwner 
		{ 
			get 
			{
				if(Activated) return _documentOwner;
				
				Model.Activate(this, true);
				Activated = true;
				return _documentOwner;
			} 
			set
			{
				SetValue( v =>  _documentOwner = v, _documentOwner, value,  "DocumentOwner");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcActorSelect> @Editors 
		{ 
			get 
			{
				if(Activated) return _editors;
				
				Model.Activate(this, true);
				Activated = true;
				return _editors;
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @CreationTime 
		{ 
			get 
			{
				if(Activated) return _creationTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _creationTime;
			} 
			set
			{
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @LastRevisionTime 
		{ 
			get 
			{
				if(Activated) return _lastRevisionTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _lastRevisionTime;
			} 
			set
			{
				SetValue( v =>  _lastRevisionTime = v, _lastRevisionTime, value,  "LastRevisionTime");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @ElectronicFormat 
		{ 
			get 
			{
				if(Activated) return _electronicFormat;
				
				Model.Activate(this, true);
				Activated = true;
				return _electronicFormat;
			} 
			set
			{
				SetValue( v =>  _electronicFormat = v, _electronicFormat, value,  "ElectronicFormat");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @ValidFrom 
		{ 
			get 
			{
				if(Activated) return _validFrom;
				
				Model.Activate(this, true);
				Activated = true;
				return _validFrom;
			} 
			set
			{
				SetValue( v =>  _validFrom = v, _validFrom, value,  "ValidFrom");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @ValidUntil 
		{ 
			get 
			{
				if(Activated) return _validUntil;
				
				Model.Activate(this, true);
				Activated = true;
				return _validUntil;
			} 
			set
			{
				SetValue( v =>  _validUntil = v, _validUntil, value,  "ValidUntil");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDocumentConfidentialityEnum? @Confidentiality 
		{ 
			get 
			{
				if(Activated) return _confidentiality;
				
				Model.Activate(this, true);
				Activated = true;
				return _confidentiality;
			} 
			set
			{
				SetValue( v =>  _confidentiality = v, _confidentiality, value,  "Confidentiality");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDocumentStatusEnum? @Status 
		{ 
			get 
			{
				if(Activated) return _status;
				
				Model.Activate(this, true);
				Activated = true;
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesDocument> @DocumentInfoForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesDocument>(e => e.RelatingDocument == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDocumentReference> @HasDocumentReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentReference>(e => e.ReferencedDocument == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => e.RelatedDocuments != null &&  e.RelatedDocuments.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointer 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => e.RelatingDocument == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_identification = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_location = value.StringVal;
					return;
				case 4: 
					_purpose = value.StringVal;
					return;
				case 5: 
					_intendedUse = value.StringVal;
					return;
				case 6: 
					_scope = value.StringVal;
					return;
				case 7: 
					_revision = value.StringVal;
					return;
				case 8: 
					_documentOwner = (IfcActorSelect)(value.EntityVal);
					return;
				case 9: 
					if (_editors == null) _editors = new OptionalItemSet<IfcActorSelect>( this );
					_editors.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_creationTime = value.StringVal;
					return;
				case 11: 
					_lastRevisionTime = value.StringVal;
					return;
				case 12: 
					_electronicFormat = value.StringVal;
					return;
				case 13: 
					_validFrom = value.StringVal;
					return;
				case 14: 
					_validUntil = value.StringVal;
					return;
				case 15: 
                    _confidentiality = (IfcDocumentConfidentialityEnum) System.Enum.Parse(typeof (IfcDocumentConfidentialityEnum), value.EnumVal, true);
					return;
				case 16: 
                    _status = (IfcDocumentStatusEnum) System.Enum.Parse(typeof (IfcDocumentStatusEnum), value.EnumVal, true);
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
        public bool Equals(@IfcDocumentInformation other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcDocumentInformation left, @IfcDocumentInformation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentInformation left, @IfcDocumentInformation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentInformation x, @IfcDocumentInformation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentInformation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}