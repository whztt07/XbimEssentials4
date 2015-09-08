// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCTYPEPROCESS")]
	public abstract partial class @IfcTypeProcess : IfcTypeObject, IfcProcessSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcText? _longDescription;
		private IfcLabel? _processType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(IsActivated) return _identification;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(IsActivated) return _longDescription;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @ProcessType 
		{ 
			get 
			{
				if(IsActivated) return _processType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _processType;
			} 
			set
			{
				SetValue( v =>  _processType = v, _processType, value,  "ProcessType");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelAssignsToProcess> @OperatesOn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProcess>(e => e.RelatingProcess == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

	}
}