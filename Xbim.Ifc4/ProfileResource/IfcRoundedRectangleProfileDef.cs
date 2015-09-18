// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[EntityName("IFCROUNDEDRECTANGLEPROFILEDEF", 575)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRoundedRectangleProfileDef : IfcRectangleProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRoundedRectangleProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _roundingRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @RoundingRadius 
		{ 
			get 
			{
				if(Activated) return _roundingRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _roundingRadius;
			} 
			set
			{
				SetValue( v =>  _roundingRadius = v, _roundingRadius, value,  "RoundingRadius");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_roundingRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidRadius:                     (RoundingRadius <= (SELF\IfcRectangleProfileDef.YDim/2.)));*/
		}
		#endregion
	}
}