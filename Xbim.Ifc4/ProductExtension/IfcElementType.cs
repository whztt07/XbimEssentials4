// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.MeasureResource;
using Xbim.Common;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCELEMENTTYPE")]
	public abstract partial class @IfcElementType : IfcTypeProduct
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _elementType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @ElementType 
		{ 
			get 
			{
				if(IsActivated) return _elementType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _elementType;
			} 
			set
			{
				SetValue( v =>  _elementType = v, _elementType, value,  "ElementType");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion


		#region IPersist implementation
		#endregion

	}
}