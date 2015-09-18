// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[EntityName("IFCFURNITURETYPE", 297)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFurnitureType : IfcFurnishingElementType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFurnitureType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAssemblyPlaceEnum _assemblyPlace;
		private IfcFurnitureTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(9, EntityAttributeState.Mandatory)]
		public IfcAssemblyPlaceEnum @AssemblyPlace 
		{ 
			get 
			{
				if(Activated) return _assemblyPlace;
				
				Model.Activate(this, true);
				Activated = true;
				return _assemblyPlace;
			} 
			set
			{
				SetValue( v =>  _assemblyPlace = v, _assemblyPlace, value,  "AssemblyPlace");
			} 
		}
	
		[EntityAttributee(10, EntityAttributeState.Optional)]
		public IfcFurnitureTypeEnum? @PredefinedType 
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
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
                    _assemblyPlace = (IfcAssemblyPlaceEnum) System.Enum.Parse(typeof (IfcAssemblyPlaceEnum), value.EnumVal, true);
					return;
				case 10: 
                    _predefinedType = (IfcFurnitureTypeEnum) System.Enum.Parse(typeof (IfcFurnitureTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                              ((PredefinedType = IfcFurnitureTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		}
		#endregion
	}
}