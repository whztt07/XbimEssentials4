// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCRELSPACEBOUNDARY", 944)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSpaceBoundary : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSpaceBoundarySelect _relatingSpace;
		private IfcElement _relatedBuildingElement;
		private IfcConnectionGeometry _connectionGeometry;
		private IfcPhysicalOrVirtualEnum _physicalOrVirtualBoundary;
		private IfcInternalOrExternalEnum _internalOrExternalBoundary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpaceBoundarySelect @RelatingSpace 
		{ 
			get 
			{
				if(Activated) return _relatingSpace;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingSpace;
			} 
			set
			{
				SetValue( v =>  _relatingSpace = v, _relatingSpace, value,  "RelatingSpace");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatedBuildingElement 
		{ 
			get 
			{
				if(Activated) return _relatedBuildingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedBuildingElement;
			} 
			set
			{
				SetValue( v =>  _relatedBuildingElement = v, _relatedBuildingElement, value,  "RelatedBuildingElement");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcConnectionGeometry @ConnectionGeometry 
		{ 
			get 
			{
				if(Activated) return _connectionGeometry;
				
				Model.Activate(this, true);
				Activated = true;
				return _connectionGeometry;
			} 
			set
			{
				SetValue( v =>  _connectionGeometry = v, _connectionGeometry, value,  "ConnectionGeometry");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcPhysicalOrVirtualEnum @PhysicalOrVirtualBoundary 
		{ 
			get 
			{
				if(Activated) return _physicalOrVirtualBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _physicalOrVirtualBoundary;
			} 
			set
			{
				SetValue( v =>  _physicalOrVirtualBoundary = v, _physicalOrVirtualBoundary, value,  "PhysicalOrVirtualBoundary");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcInternalOrExternalEnum @InternalOrExternalBoundary 
		{ 
			get 
			{
				if(Activated) return _internalOrExternalBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _internalOrExternalBoundary;
			} 
			set
			{
				SetValue( v =>  _internalOrExternalBoundary = v, _internalOrExternalBoundary, value,  "InternalOrExternalBoundary");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_relatingSpace = (IfcSpaceBoundarySelect)(value.EntityVal);
					return;
				case 5: 
					_relatedBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 6: 
					_connectionGeometry = (IfcConnectionGeometry)(value.EntityVal);
					return;
				case 7: 
                    _physicalOrVirtualBoundary = (IfcPhysicalOrVirtualEnum) System.Enum.Parse(typeof (IfcPhysicalOrVirtualEnum), value.EnumVal, true);
					return;
				case 8: 
                    _internalOrExternalBoundary = (IfcInternalOrExternalEnum) System.Enum.Parse(typeof (IfcInternalOrExternalEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPhysOrVirt:                          (PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.NotDefined);*/
		}
		#endregion
	}
}