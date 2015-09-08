// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:23
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProcessExtension;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCPROCESS", 446)]
	public abstract partial class @IfcProcess : IfcObject, IfcProcessSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcText? _longDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(Activated) return _identification;
				
				Model.Activate(this, true);
				Activated = true;
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(Activated) return _longDescription;
				
				Model.Activate(this, true);
				Activated = true;
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelSequence> @IsPredecessorTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => e.RelatingProcess == this);
			} 
		}
	
		public IEnumerable<IfcRelSequence> @IsSuccessorFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => e.RelatedProcess == this);
			} 
		}
	
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