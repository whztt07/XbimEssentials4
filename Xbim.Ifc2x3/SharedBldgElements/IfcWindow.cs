// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[EntityName("IFCWINDOW", 667)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindow : IfcBuildingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindow(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _overallHeight;
		private IfcPositiveLengthMeasure? _overallWidth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(8, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @OverallHeight 
		{ 
			get 
			{
				if(Activated) return _overallHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @OverallWidth 
		{ 
			get 
			{
				if(Activated) return _overallWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
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
					_overallHeight = value.RealVal;
					return;
				case 9: 
					_overallWidth = value.RealVal;
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