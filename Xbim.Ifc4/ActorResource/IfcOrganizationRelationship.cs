// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ActorResource
{
	[EntityName("IFCORGANIZATIONRELATIONSHIP", 394)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganizationRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrganizationRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedOrganizations = new ItemSet<IfcOrganization>( this );
		}

		#region Explicit attribute fields
		private IfcOrganization _relatingOrganization;
		private ItemSet<IfcOrganization> _relatedOrganizations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcOrganization @RelatingOrganization 
		{ 
			get 
			{
				if(Activated) return _relatingOrganization;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingOrganization;
			} 
			set
			{
				SetValue( v =>  _relatingOrganization = v, _relatingOrganization, value,  "RelatingOrganization");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public ItemSet<IfcOrganization> @RelatedOrganizations 
		{ 
			get 
			{
				if(Activated) return _relatedOrganizations;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedOrganizations;
			} 
			set
			{
				SetValue( v =>  _relatedOrganizations = v, _relatedOrganizations, value,  "RelatedOrganizations");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
					_relatingOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					if (_relatedOrganizations == null) _relatedOrganizations = new ItemSet<IfcOrganization>( this );
					_relatedOrganizations.InternalAdd((IfcOrganization)value.EntityVal);
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