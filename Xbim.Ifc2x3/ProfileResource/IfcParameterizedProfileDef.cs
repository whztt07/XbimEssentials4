// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProfileResource
{
	[EntityName("IFCPARAMETERIZEDPROFILEDEF")]
	public abstract partial class @IfcParameterizedProfileDef : IfcProfileDef
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcParameterizedProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement2D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement2D @Position 
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


		#region IPersist implementation
		#endregion

	}
}