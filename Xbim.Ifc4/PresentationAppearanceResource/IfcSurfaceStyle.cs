// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCSURFACESTYLE", 668)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyle(IModel model) : base(model) 		{ 
			Model = model; 
			_styles = new ItemSet<IfcSurfaceStyleElementSelect>( this );
		}

		#region Explicit attribute fields
		private IfcSurfaceSide _side;
		private ItemSet<IfcSurfaceStyleElementSelect> _styles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public IfcSurfaceSide @Side 
		{ 
			get 
			{
				if(Activated) return _side;
				
				Model.Activate(this, true);
				Activated = true;
				return _side;
			} 
			set
			{
				SetValue( v =>  _side = v, _side, value,  "Side");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcSurfaceStyleElementSelect> @Styles 
		{ 
			get 
			{
				if(Activated) return _styles;
				
				Model.Activate(this, true);
				Activated = true;
				return _styles;
			} 
			set
			{
				SetValue( v =>  _styles = v, _styles, value,  "Styles");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
                    _side = (IfcSurfaceSide) System.Enum.Parse(typeof (IfcSurfaceSide), value.EnumVal, true);
					return;
				case 2: 
					if (_styles == null) _styles = new ItemSet<IfcSurfaceStyleElementSelect>( this );
					_styles.InternalAdd((IfcSurfaceStyleElementSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*MaxOneShading:                           )) <= 1;*/
		/*MaxOneLighting:                           )) <= 1;*/
		/*MaxOneRefraction:                           )) <= 1;*/
		/*MaxOneTextures:                           )) <= 1;*/
		/*MaxOneExtDefined:                           )) <= 1;*/
		}
		#endregion
	}
}