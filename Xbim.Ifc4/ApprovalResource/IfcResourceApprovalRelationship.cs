// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ApprovalResource
{
	[IndexedClass]
	[ExpressType("IFCRESOURCEAPPROVALRELATIONSHIP", 955)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceApprovalRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		private IfcApproval _relatingApproval;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(Activated) return _relatingApproval;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingApproval;
			} 
			set
			{
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval");
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
					if (_relatedResourceObjects == null) _relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
					return;
				case 3: 
					_relatingApproval = (IfcApproval)(value.EntityVal);
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