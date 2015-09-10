// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALACTION", 40)]
	public abstract partial class @IfcStructuralAction : IfcStructuralActivity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private bool _destabilizingLoad;
		private IfcStructuralReaction _causedBy;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public bool @DestabilizingLoad 
		{ 
			get 
			{
				if(Activated) return _destabilizingLoad;
				
				Model.Activate(this, true);
				Activated = true;
				return _destabilizingLoad;
			} 
			set
			{
				SetValue( v =>  _destabilizingLoad = v, _destabilizingLoad, value,  "DestabilizingLoad");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcStructuralReaction @CausedBy 
		{ 
			get 
			{
				if(Activated) return _causedBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _causedBy;
			} 
			set
			{
				SetValue( v =>  _causedBy = v, _causedBy, value,  "CausedBy");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion


		#region IPersist implementation
		#endregion

		public virtual override string WhereRule() 
		{
			return "";
		}
	}
}