// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:14
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

namespace Xbim.Ifc4.ConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCRESOURCECONSTRAINTRELATIONSHIP", 956)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceConstraintRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceConstraintRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
		}

		#region Explicit attribute fields
		private IfcConstraint _relatingConstraint;
		private ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(Activated) return _relatingConstraint;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingConstraint;
			} 
			set
			{
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint");
			} 
		}
	
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
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
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