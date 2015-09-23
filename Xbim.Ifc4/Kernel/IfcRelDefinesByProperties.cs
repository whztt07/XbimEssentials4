// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[IndexedClass]
	[ExpressType("IFCRELDEFINESBYPROPERTIES", 933)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByProperties : IfcRelDefines, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcPropertySetDefinitionSelect _relatingPropertyDefinition;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 1)]
		public ItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(Activated) return _relatedObjects;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedObjects;
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPropertySetDefinitionSelect @RelatingPropertyDefinition 
		{ 
			get 
			{
				if(Activated) return _relatingPropertyDefinition;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingPropertyDefinition;
			} 
			set
			{
				SetValue( v =>  _relatingPropertyDefinition = v, _relatingPropertyDefinition, value,  "RelatingPropertyDefinition");
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
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObjectDefinition>( this );
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				case 5: 
					_relatingPropertyDefinition = (IfcPropertySetDefinitionSelect)(value.EntityVal);
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