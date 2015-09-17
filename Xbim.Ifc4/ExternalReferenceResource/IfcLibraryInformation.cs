// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:08
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
	[EntityName("IFCLIBRARYINFORMATION", 332)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryInformation : IfcExternalInformation, IfcLibrarySelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryInformation(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcLabel? _version;
		private IfcActorSelect _publisher;
		private IfcDateTime? _versionDate;
		private IfcURIReference? _location;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcLabel? @Version 
		{ 
			get 
			{
				if(Activated) return _version;
				
				Model.Activate(this, true);
				Activated = true;
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcActorSelect @Publisher 
		{ 
			get 
			{
				if(Activated) return _publisher;
				
				Model.Activate(this, true);
				Activated = true;
				return _publisher;
			} 
			set
			{
				SetValue( v =>  _publisher = v, _publisher, value,  "Publisher");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcDateTime? @VersionDate 
		{ 
			get 
			{
				if(Activated) return _versionDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _versionDate;
			} 
			set
			{
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelAssociatesLibrary> @LibraryInfoForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesLibrary>(e => e.RelatingLibrary == this);
			} 
		}
	
		public IEnumerable<IfcLibraryReference> @HasLibraryReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcLibraryReference>(e => e.ReferencedLibrary == this);
			} 
		}
	

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_publisher = (IfcActorSelect)(value.EntityVal);
					return;
				case 3: 
					_versionDate = value.StringVal;
					return;
				case 4: 
					_location = value.StringVal;
					return;
				case 5: 
					_description = value.StringVal;
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
	}
}