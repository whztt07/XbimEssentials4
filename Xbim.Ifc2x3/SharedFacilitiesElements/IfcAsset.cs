// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:55
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.CostResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[EntityName("IFCASSET", 767)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsset : IfcGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsset(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _assetID;
		private IfcCostValue _originalValue;
		private IfcCostValue _currentValue;
		private IfcCostValue _totalReplacementCost;
		private IfcActorSelect _owner;
		private IfcActorSelect _user;
		private IfcPerson _responsiblePerson;
		private IfcCalendarDate _incorporationDate;
		private IfcCostValue _depreciatedValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcIdentifier @AssetID 
		{ 
			get 
			{
				if(Activated) return _assetID;
				
				Model.Activate(this, true);
				Activated = true;
				return _assetID;
			} 
			set
			{
				SetValue( v =>  _assetID = v, _assetID, value,  "AssetID");
			} 
		}
	
		[EntityAttributee(6, EntityAttributeState.Mandatory)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(Activated) return _originalValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _originalValue;
			} 
			set
			{
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue");
			} 
		}
	
		[EntityAttributee(7, EntityAttributeState.Mandatory)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(Activated) return _currentValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _currentValue;
			} 
			set
			{
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue");
			} 
		}
	
		[EntityAttributee(8, EntityAttributeState.Mandatory)]
		public IfcCostValue @TotalReplacementCost 
		{ 
			get 
			{
				if(Activated) return _totalReplacementCost;
				
				Model.Activate(this, true);
				Activated = true;
				return _totalReplacementCost;
			} 
			set
			{
				SetValue( v =>  _totalReplacementCost = v, _totalReplacementCost, value,  "TotalReplacementCost");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Mandatory)]
		public IfcActorSelect @Owner 
		{ 
			get 
			{
				if(Activated) return _owner;
				
				Model.Activate(this, true);
				Activated = true;
				return _owner;
			} 
			set
			{
				SetValue( v =>  _owner = v, _owner, value,  "Owner");
			} 
		}
	
		[EntityAttributee(10, EntityAttributeState.Mandatory)]
		public IfcActorSelect @User 
		{ 
			get 
			{
				if(Activated) return _user;
				
				Model.Activate(this, true);
				Activated = true;
				return _user;
			} 
			set
			{
				SetValue( v =>  _user = v, _user, value,  "User");
			} 
		}
	
		[EntityAttributee(11, EntityAttributeState.Mandatory)]
		public IfcPerson @ResponsiblePerson 
		{ 
			get 
			{
				if(Activated) return _responsiblePerson;
				
				Model.Activate(this, true);
				Activated = true;
				return _responsiblePerson;
			} 
			set
			{
				SetValue( v =>  _responsiblePerson = v, _responsiblePerson, value,  "ResponsiblePerson");
			} 
		}
	
		[EntityAttributee(12, EntityAttributeState.Mandatory)]
		public IfcCalendarDate @IncorporationDate 
		{ 
			get 
			{
				if(Activated) return _incorporationDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _incorporationDate;
			} 
			set
			{
				SetValue( v =>  _incorporationDate = v, _incorporationDate, value,  "IncorporationDate");
			} 
		}
	
		[EntityAttributee(13, EntityAttributeState.Mandatory)]
		public IfcCostValue @DepreciatedValue 
		{ 
			get 
			{
				if(Activated) return _depreciatedValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _depreciatedValue;
			} 
			set
			{
				SetValue( v =>  _depreciatedValue = v, _depreciatedValue, value,  "DepreciatedValue");
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
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_assetID = value.StringVal;
					return;
				case 6: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				case 7: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 8: 
					_totalReplacementCost = (IfcCostValue)(value.EntityVal);
					return;
				case 9: 
					_owner = (IfcActorSelect)(value.EntityVal);
					return;
				case 10: 
					_user = (IfcActorSelect)(value.EntityVal);
					return;
				case 11: 
					_responsiblePerson = (IfcPerson)(value.EntityVal);
					return;
				case 12: 
					_incorporationDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 13: 
					_depreciatedValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcGroup.IsGroupedBy.RelatedObjects | NOT('IFC2X3.IFCELEMENT' IN TYPEOF(Temp)))) = 0;*/
		}
		#endregion
	}
}