// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCSWEPTSURFACE")]
	public abstract partial class @IfcSweptSurface : IfcSurface
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _sweptCurve;
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcProfileDef @SweptCurve 
		{ 
			get 
			{
				if(IsActivated) return _sweptCurve;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _sweptCurve;
			} 
			set
			{
				SetValue( v =>  _sweptCurve = v, _sweptCurve, value,  "SweptCurve");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(IsActivated) return _position;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Where rules
		/*SweptCurveType:	SweptCurveType : SweptCurve.ProfileType = IfcProfileTypeEnum.Curve;*/
		#endregion

		#region IPersist implementation
		#endregion

	}
}