// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCRELSERVICESBUILDINGS", 943)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelServicesBuildings : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelServicesBuildings(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedBuildings = new ItemSet<IfcSpatialElement>( this );
		}

		#region Explicit attribute fields
		private IfcSystem _relatingSystem;
		private ItemSet<IfcSpatialElement> _relatedBuildings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSystem @RelatingSystem 
		{ 
			get 
			{
				if(Activated) return _relatingSystem;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingSystem;
			} 
			set
			{
				SetValue( v =>  _relatingSystem = v, _relatingSystem, value,  "RelatingSystem");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSpatialElement> @RelatedBuildings 
		{ 
			get 
			{
				if(Activated) return _relatedBuildings;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedBuildings;
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
					_relatingSystem = (IfcSystem)(value.EntityVal);
					return;
				case 5: 
					if (_relatedBuildings == null) _relatedBuildings = new ItemSet<IfcSpatialElement>( this );
					_relatedBuildings.InternalAdd((IfcSpatialElement)value.EntityVal);
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