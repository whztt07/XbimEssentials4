// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCBOUNDARYNODECONDITIONWARPING", 442)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeConditionWarping(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWarpingStiffnessSelect _warpingStiffness;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcWarpingStiffnessSelect @WarpingStiffness 
		{ 
			get 
			{
				if(Activated) return _warpingStiffness;
				
				Model.Activate(this, true);
				Activated = true;
				return _warpingStiffness;
			} 
			set
			{
				SetValue( v =>  _warpingStiffness = v, _warpingStiffness, value,  "WarpingStiffness");
			} 
		}
	
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_warpingStiffness = (IfcWarpingStiffnessSelect)(value.EntityVal);
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