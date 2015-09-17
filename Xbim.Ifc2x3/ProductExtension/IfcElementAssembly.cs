// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[EntityName("IFCELEMENTASSEMBLY", 18)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElementAssembly : IfcElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementAssembly(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAssemblyPlaceEnum? _assemblyPlace;
		private IfcElementAssemblyTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcAssemblyPlaceEnum? @AssemblyPlace 
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
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcElementAssemblyTypeEnum @PredefinedType 
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
                    _assemblyPlace = (IfcAssemblyPlaceEnum) System.Enum.Parse(typeof (IfcAssemblyPlaceEnum), value.EnumVal, true);
					return;
				case 9: 
                    _predefinedType = (IfcElementAssemblyTypeEnum) System.Enum.Parse(typeof (IfcElementAssemblyTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : (PredefinedType <> IfcElementAssemblyTypeEnum.USERDEFINED) OR ((PredefinedType = IfcElementAssemblyTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion
	}
}