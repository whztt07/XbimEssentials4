// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCELEMENTARYSURFACE")]
	public abstract partial class @IfcElementarySurface : IfcSurface
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementarySurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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


		#region IPersist implementation
		#endregion

	}
}