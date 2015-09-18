// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCSURFACEOFREVOLUTION", 109)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfRevolution : IfcSweptSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfRevolution(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axisPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcAxis1Placement @AxisPosition 
		{ 
			get 
			{
				if(Activated) return _axisPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _axisPosition;
			} 
			set
			{
				SetValue( v =>  _axisPosition = v, _axisPosition, value,  "AxisPosition");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_axisPosition = (IfcAxis1Placement)(value.EntityVal);
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