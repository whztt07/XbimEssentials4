// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ActorResource
{
	[EntityName("IFCPOSTALADDRESS", 432)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPostalAddress : IfcAddress, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPostalAddress(IModel model) : base(model) 		{ 
			Model = model; 
			_addressLines = new ItemSet<IfcLabel>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _internalLocation;
		private ItemSet<IfcLabel> _addressLines;
		private IfcLabel? _postalBox;
		private IfcLabel? _town;
		private IfcLabel? _region;
		private IfcLabel? _postalCode;
		private IfcLabel? _country;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(3, EntityAttributeState.Optional)]
		public IfcLabel? @InternalLocation 
		{ 
			get 
			{
				if(Activated) return _internalLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _internalLocation;
			} 
			set
			{
				SetValue( v =>  _internalLocation = v, _internalLocation, value,  "InternalLocation");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public ItemSet<IfcLabel> @AddressLines 
		{ 
			get 
			{
				if(Activated) return _addressLines;
				
				Model.Activate(this, true);
				Activated = true;
				return _addressLines;
			} 
			set
			{
				SetValue( v =>  _addressLines = v, _addressLines, value,  "AddressLines");
			} 
		}
	
		[EntityAttributee(5, EntityAttributeState.Optional)]
		public IfcLabel? @PostalBox 
		{ 
			get 
			{
				if(Activated) return _postalBox;
				
				Model.Activate(this, true);
				Activated = true;
				return _postalBox;
			} 
			set
			{
				SetValue( v =>  _postalBox = v, _postalBox, value,  "PostalBox");
			} 
		}
	
		[EntityAttributee(6, EntityAttributeState.Optional)]
		public IfcLabel? @Town 
		{ 
			get 
			{
				if(Activated) return _town;
				
				Model.Activate(this, true);
				Activated = true;
				return _town;
			} 
			set
			{
				SetValue( v =>  _town = v, _town, value,  "Town");
			} 
		}
	
		[EntityAttributee(7, EntityAttributeState.Optional)]
		public IfcLabel? @Region 
		{ 
			get 
			{
				if(Activated) return _region;
				
				Model.Activate(this, true);
				Activated = true;
				return _region;
			} 
			set
			{
				SetValue( v =>  _region = v, _region, value,  "Region");
			} 
		}
	
		[EntityAttributee(8, EntityAttributeState.Optional)]
		public IfcLabel? @PostalCode 
		{ 
			get 
			{
				if(Activated) return _postalCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _postalCode;
			} 
			set
			{
				SetValue( v =>  _postalCode = v, _postalCode, value,  "PostalCode");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Optional)]
		public IfcLabel? @Country 
		{ 
			get 
			{
				if(Activated) return _country;
				
				Model.Activate(this, true);
				Activated = true;
				return _country;
			} 
			set
			{
				SetValue( v =>  _country = v, _country, value,  "Country");
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
				case 2: 
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_internalLocation = value.StringVal;
					return;
				case 4: 
					if (_addressLines == null) _addressLines = new ItemSet<IfcLabel>( this );
					_addressLines.InternalAdd(value.StringVal);
					return;
				case 5: 
					_postalBox = value.StringVal;
					return;
				case 6: 
					_town = value.StringVal;
					return;
				case 7: 
					_region = value.StringVal;
					return;
				case 8: 
					_postalCode = value.StringVal;
					return;
				case 9: 
					_country = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:            EXISTS (Country);*/
		}
		#endregion
	}
}