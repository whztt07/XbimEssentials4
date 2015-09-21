// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.QuantityResource;
using Xbim.Ifc4.CostResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[IndexedClass]
	[ExpressType("IFCCONSTRUCTIONRESOURCETYPE", 524)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResourceType : IfcTypeResource
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResourceType(IModel model) : base(model) 		{ 
			Model = model; 
			_baseCosts = new OptionalItemSet<IfcAppliedValue>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcAppliedValue> _baseCosts;
		private IfcPhysicalQuantity _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcAppliedValue> @BaseCosts 
		{ 
			get 
			{
				if(Activated) return _baseCosts;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseCosts;
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPhysicalQuantity @BaseQuantity 
		{ 
			get 
			{
				if(Activated) return _baseQuantity;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseQuantity;
			} 
			set
			{
				SetValue( v =>  _baseQuantity = v, _baseQuantity, value,  "BaseQuantity");
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					if (_baseCosts == null) _baseCosts = new OptionalItemSet<IfcAppliedValue>( this );
					_baseCosts.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 10: 
					_baseQuantity = (IfcPhysicalQuantity)(value.EntityVal);
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