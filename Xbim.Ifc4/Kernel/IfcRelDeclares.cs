// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:43
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
	[ExpressType("IFCRELDECLARES", 929)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDeclares : IfcRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDeclares(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedDefinitions = new ItemSet<IfcDefinitionSelect>( this );
		}

		#region Explicit attribute fields
		private IfcContext _relatingContext;
		private ItemSet<IfcDefinitionSelect> _relatedDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcContext @RelatingContext 
		{ 
			get 
			{
				if(Activated) return _relatingContext;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingContext;
			} 
			set
			{
				SetValue( v =>  _relatingContext = v, _relatingContext, value,  "RelatingContext");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDefinitionSelect> @RelatedDefinitions 
		{ 
			get 
			{
				if(Activated) return _relatedDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedDefinitions;
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
					_relatingContext = (IfcContext)(value.EntityVal);
					return;
				case 5: 
					if (_relatedDefinitions == null) _relatedDefinitions = new ItemSet<IfcDefinitionSelect>( this );
					_relatedDefinitions.InternalAdd((IfcDefinitionSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* RelatedDefinitions | RelatingContext :=: Temp)) = 0;*/
		}
		#endregion
	}
}