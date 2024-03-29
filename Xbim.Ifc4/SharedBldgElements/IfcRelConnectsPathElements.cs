// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedBldgElements
{
	[IndexedClass]
	[ExpressType("IFCRELCONNECTSPATHELEMENTS", 919)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPathElements : IfcRelConnectsElements, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPathElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatingPriorities = new ItemSet<double>( this );
			_relatedPriorities = new ItemSet<double>( this );
		}

		#region Explicit attribute fields
		private ItemSet<double> _relatingPriorities;
		private ItemSet<double> _relatedPriorities;
		private IfcConnectionTypeEnum _relatedConnectionType;
		private IfcConnectionTypeEnum _relatingConnectionType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 0, -1)]
		public ItemSet<double> @RelatingPriorities 
		{ 
			get 
			{
				if(Activated) return _relatingPriorities;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingPriorities;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 0, -1)]
		public ItemSet<double> @RelatedPriorities 
		{ 
			get 
			{
				if(Activated) return _relatedPriorities;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedPriorities;
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcConnectionTypeEnum @RelatedConnectionType 
		{ 
			get 
			{
				if(Activated) return _relatedConnectionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedConnectionType;
			} 
			set
			{
				SetValue( v =>  _relatedConnectionType = v, _relatedConnectionType, value,  "RelatedConnectionType");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcConnectionTypeEnum @RelatingConnectionType 
		{ 
			get 
			{
				if(Activated) return _relatingConnectionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingConnectionType;
			} 
			set
			{
				SetValue( v =>  _relatingConnectionType = v, _relatingConnectionType, value,  "RelatingConnectionType");
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
					if (_relatingPriorities == null) _relatingPriorities = new ItemSet<double>( this );
					_relatingPriorities.InternalAdd(value.NumberVal);
					return;
				case 8: 
					if (_relatedPriorities == null) _relatedPriorities = new ItemSet<double>( this );
					_relatedPriorities.InternalAdd(value.NumberVal);
					return;
				case 9: 
                    _relatedConnectionType = (IfcConnectionTypeEnum) System.Enum.Parse(typeof (IfcConnectionTypeEnum), value.EnumVal, true);
					return;
				case 10: 
                    _relatingConnectionType = (IfcConnectionTypeEnum) System.Enum.Parse(typeof (IfcConnectionTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NormalizedRelatingPriorities:                                       )) = SIZEOF(RelatingPriorities));*/
		/*NormalizedRelatedPriorities:                                       )) = SIZEOF(RelatedPriorities));*/
		}
		#endregion
	}
}