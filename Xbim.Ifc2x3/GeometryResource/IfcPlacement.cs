// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCPLACEMENT", 357)]
	public abstract partial class @IfcPlacement : IfcGeometricRepresentationItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _location;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCartesianPoint @Location 
		{ 
			get 
			{
				if(Activated) return _location;
				
				Model.Activate(this, true);
				Activated = true;
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion


		#region IPersist implementation
		#endregion

	}
}