// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:54
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("COMPONENT", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieComponent : CobieAsset, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieComponent(IModel model) : base(model) 		{ 
			Model = model; 
			_assemblyOf = new ItemSet<CobieComponent>( this );
		}

		#region Explicit attribute fields
		private string _serialNumber;
		private DateTimeValue _installationDate;
		private DateTimeValue _warrantyStartDate;
		private string _tagNumber;
		private string _barCode;
		private string _assetIdentifier;
		private CobieType _type;
		private CobieSpace _space;
		private ItemSet<CobieComponent> _assemblyOf;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @SerialNumber 
		{ 
			get 
			{
				if(Activated) return _serialNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _serialNumber;
			} 
			set
			{
				SetValue( v =>  _serialNumber = v, _serialNumber, value,  "SerialNumber");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public DateTimeValue @InstallationDate 
		{ 
			get 
			{
				if(Activated) return _installationDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _installationDate;
			} 
			set
			{
				SetValue( v =>  _installationDate = v, _installationDate, value,  "InstallationDate");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public DateTimeValue @WarrantyStartDate 
		{ 
			get 
			{
				if(Activated) return _warrantyStartDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _warrantyStartDate;
			} 
			set
			{
				SetValue( v =>  _warrantyStartDate = v, _warrantyStartDate, value,  "WarrantyStartDate");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @TagNumber 
		{ 
			get 
			{
				if(Activated) return _tagNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _tagNumber;
			} 
			set
			{
				SetValue( v =>  _tagNumber = v, _tagNumber, value,  "TagNumber");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @BarCode 
		{ 
			get 
			{
				if(Activated) return _barCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _barCode;
			} 
			set
			{
				SetValue( v =>  _barCode = v, _barCode, value,  "BarCode");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @AssetIdentifier 
		{ 
			get 
			{
				if(Activated) return _assetIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _assetIdentifier;
			} 
			set
			{
				SetValue( v =>  _assetIdentifier = v, _assetIdentifier, value,  "AssetIdentifier");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(17, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieType @Type 
		{ 
			get 
			{
				if(Activated) return _type;
				
				Model.Activate(this, true);
				Activated = true;
				return _type;
			} 
			set
			{
				SetValue( v =>  _type = v, _type, value,  "Type");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(18, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieSpace @Space 
		{ 
			get 
			{
				if(Activated) return _space;
				
				Model.Activate(this, true);
				Activated = true;
				return _space;
			} 
			set
			{
				SetValue( v =>  _space = v, _space, value,  "Space");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<CobieComponent> @AssemblyOf 
		{ 
			get 
			{
				if(Activated) return _assemblyOf;
				
				Model.Activate(this, true);
				Activated = true;
				return _assemblyOf;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieSystem> @Systems 
		{ 
			get 
			{
				return Model.Instances.Where<CobieSystem>(e => e.Components != null &&  e.Components.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieConnection> @ConnectedBefore 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => e.ComponentA == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieConnection> @ConnectedAfter 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => e.ComponentB == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieConnection> @Connecting 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => e.RealizingComponent == this);
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value); 
					return;
				case 10: 
					_serialNumber = value.StringVal;
					return;
				case 11: 
					_installationDate = value.StringVal;
					return;
				case 12: 
					_warrantyStartDate = value.StringVal;
					return;
				case 13: 
					_tagNumber = value.StringVal;
					return;
				case 14: 
					_barCode = value.StringVal;
					return;
				case 15: 
					_assetIdentifier = value.StringVal;
					return;
				case 16: 
					_type = (CobieType)(value.EntityVal);
					return;
				case 17: 
					_space = (CobieSpace)(value.EntityVal);
					return;
				case 18: 
					if (_assemblyOf == null) _assemblyOf = new ItemSet<CobieComponent>( this );
					_assemblyOf.InternalAdd((CobieComponent)value.EntityVal);
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