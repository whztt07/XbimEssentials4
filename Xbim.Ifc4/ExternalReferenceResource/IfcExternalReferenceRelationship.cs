// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCEXTERNALREFERENCERELATIONSHIP", 634)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExternalReferenceRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExternalReferenceRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
		}

		#region Explicit attribute fields
		private IfcExternalReference _relatingReference;
		private ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcExternalReference @RelatingReference 
		{ 
			get 
			{
				if(Activated) return _relatingReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingReference;
			} 
			set
			{
				SetValue( v =>  _relatingReference = v, _relatingReference, value,  "RelatingReference");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcResourceObjectSelect> @RelatedResourceObjects 
		{ 
			get 
			{
				if(Activated) return _relatedResourceObjects;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedResourceObjects;
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_relatingReference = (IfcExternalReference)(value.EntityVal);
					return;
				case 3: 
					if (_relatedResourceObjects == null) _relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
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