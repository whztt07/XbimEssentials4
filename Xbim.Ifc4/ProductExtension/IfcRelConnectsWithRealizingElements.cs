// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:51
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCRELCONNECTSWITHREALIZINGELEMENTS", 925)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsWithRealizingElements : IfcRelConnectsElements, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsWithRealizingElements(IModel model) : base(model) 		{ 
			Model = model; 
			_realizingElements = new ItemSet<IfcElement>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcElement> _realizingElements;
		private IfcLabel? _connectionType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcElement> @RealizingElements 
		{ 
			get 
			{
				if(Activated) return _realizingElements;
				
				Model.Activate(this, true);
				Activated = true;
				return _realizingElements;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ConnectionType 
		{ 
			get 
			{
				if(Activated) return _connectionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType");
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
					base.Parse(propIndex, value); 
					return;
				case 7: 
					if (_realizingElements == null) _realizingElements = new ItemSet<IfcElement>( this );
					_realizingElements.InternalAdd((IfcElement)value.EntityVal);
					return;
				case 8: 
					_connectionType = value.StringVal;
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