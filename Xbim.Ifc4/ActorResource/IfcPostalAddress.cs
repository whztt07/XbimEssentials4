// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:22
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ActorResource
{
	[EntityName("IFCPOSTALADDRESS", 432)]
	public  partial class @IfcPostalAddress : IfcAddress, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPostalAddress(IModel model) : base(model) 		{ 
			Model = model; 
			_addressLines = new ItemSet<IfcLabel>( model );
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
		[EntityAttribute(3, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Purpose",
			"Description",
			"UserDefinedPurpose",
			"InternalLocation",
			"AddressLines",
			"PostalBox",
			"Town",
			"Region",
			"PostalCode",
			"Country",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Purpose;
				case 1: 
					return @Description;
				case 2: 
					return @UserDefinedPurpose;
				case 3: 
					return @InternalLocation;
				case 4: 
					return @AddressLines;
				case 5: 
					return @PostalBox;
				case 6: 
					return @Town;
				case 7: 
					return @Region;
				case 8: 
					return @PostalCode;
				case 9: 
					return @Country;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Purpose":  
					return @Purpose;
				case "Description":  
					return @Description;
				case "UserDefinedPurpose":  
					return @UserDefinedPurpose;
				case "InternalLocation":  
					return @InternalLocation;
				case "AddressLines":  
					return @AddressLines;
				case "PostalBox":  
					return @PostalBox;
				case "Town":  
					return @Town;
				case "Region":  
					return @Region;
				case "PostalCode":  
					return @PostalCode;
				case "Country":  
					return @Country;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Purpose = (IfcAddressTypeEnum)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @UserDefinedPurpose = (IfcLabel?)value;
					 break;
				case 3:
					 @InternalLocation = (IfcLabel?)value;
					 break;
				case 4:
					 @AddressLines = (ItemSet<IfcLabel>)value;
					 break;
				case 5:
					 @PostalBox = (IfcLabel?)value;
					 break;
				case 6:
					 @Town = (IfcLabel?)value;
					 break;
				case 7:
					 @Region = (IfcLabel?)value;
					 break;
				case 8:
					 @PostalCode = (IfcLabel?)value;
					 break;
				case 9:
					 @Country = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Purpose":
					 @Purpose = (IfcAddressTypeEnum)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "UserDefinedPurpose":
					 @UserDefinedPurpose = (IfcLabel?)value;
					 break;
				case "InternalLocation":
					 @InternalLocation = (IfcLabel?)value;
					 break;
				case "AddressLines":
					 @AddressLines = (ItemSet<IfcLabel>)value;
					 break;
				case "PostalBox":
					 @PostalBox = (IfcLabel?)value;
					 break;
				case "Town":
					 @Town = (IfcLabel?)value;
					 break;
				case "Region":
					 @Region = (IfcLabel?)value;
					 break;
				case "PostalCode":
					 @PostalCode = (IfcLabel?)value;
					 break;
				case "Country":
					 @Country = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:            EXISTS (Country);*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}