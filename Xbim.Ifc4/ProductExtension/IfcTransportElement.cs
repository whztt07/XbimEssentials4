// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCTRANSPORTELEMENT", 719)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTransportElement : IfcElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTransportElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTransportElementTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcTransportElementTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
					base.Parse(propIndex, value); 
					return;
				case 8: 
                    _predefinedType = (IfcTransportElementTypeEnum) System.Enum.Parse(typeof (IfcTransportElementTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcTransportElementTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                ('IFC4.IFCTRANSPORTELEMENTTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion
	}
}