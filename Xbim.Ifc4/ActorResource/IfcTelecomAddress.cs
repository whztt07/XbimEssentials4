// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ExternalReferenceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ActorResource
{
	[IndexedClass]
	[ExpressType("IFCTELECOMADDRESS", 1085)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTelecomAddress : IfcAddress, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTelecomAddress(IModel model) : base(model) 		{ 
			Model = model; 
			_telephoneNumbers = new OptionalItemSet<IfcLabel>( this );
			_facsimileNumbers = new OptionalItemSet<IfcLabel>( this );
			_electronicMailAddresses = new OptionalItemSet<IfcLabel>( this );
			_messagingIDs = new OptionalItemSet<IfcURIReference>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcLabel> _telephoneNumbers;
		private OptionalItemSet<IfcLabel> _facsimileNumbers;
		private IfcLabel? _pagerNumber;
		private OptionalItemSet<IfcLabel> _electronicMailAddresses;
		private IfcURIReference? _wWWHomePageURL;
		private OptionalItemSet<IfcURIReference> _messagingIDs;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @TelephoneNumbers 
		{ 
			get 
			{
				if(Activated) return _telephoneNumbers;
				
				Model.Activate(this, true);
				Activated = true;
				return _telephoneNumbers;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @FacsimileNumbers 
		{ 
			get 
			{
				if(Activated) return _facsimileNumbers;
				
				Model.Activate(this, true);
				Activated = true;
				return _facsimileNumbers;
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @PagerNumber 
		{ 
			get 
			{
				if(Activated) return _pagerNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _pagerNumber;
			} 
			set
			{
				SetValue( v =>  _pagerNumber = v, _pagerNumber, value,  "PagerNumber");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @ElectronicMailAddresses 
		{ 
			get 
			{
				if(Activated) return _electronicMailAddresses;
				
				Model.Activate(this, true);
				Activated = true;
				return _electronicMailAddresses;
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcURIReference? @WWWHomePageURL 
		{ 
			get 
			{
				if(Activated) return _wWWHomePageURL;
				
				Model.Activate(this, true);
				Activated = true;
				return _wWWHomePageURL;
			} 
			set
			{
				SetValue( v =>  _wWWHomePageURL = v, _wWWHomePageURL, value,  "WWWHomePageURL");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcURIReference> @MessagingIDs 
		{ 
			get 
			{
				if(Activated) return _messagingIDs;
				
				Model.Activate(this, true);
				Activated = true;
				return _messagingIDs;
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
					if (_telephoneNumbers == null) _telephoneNumbers = new OptionalItemSet<IfcLabel>( this );
					_telephoneNumbers.InternalAdd(value.StringVal);
					return;
				case 4: 
					if (_facsimileNumbers == null) _facsimileNumbers = new OptionalItemSet<IfcLabel>( this );
					_facsimileNumbers.InternalAdd(value.StringVal);
					return;
				case 5: 
					_pagerNumber = value.StringVal;
					return;
				case 6: 
					if (_electronicMailAddresses == null) _electronicMailAddresses = new OptionalItemSet<IfcLabel>( this );
					_electronicMailAddresses.InternalAdd(value.StringVal);
					return;
				case 7: 
					_wWWHomePageURL = value.StringVal;
					return;
				case 8: 
					if (_messagingIDs == null) _messagingIDs = new OptionalItemSet<IfcURIReference>( this );
					_messagingIDs.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*MinimumDataProvided:                            EXISTS (MessagingIDs);*/
		}
		#endregion
	}
}