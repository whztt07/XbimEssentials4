// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALACTION", 40)]
	// ReSharper disable once PartialTypeWithSinglePart
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
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					_destabilizingLoad = value.BooleanVal;
					return;
				case 10: 
					_causedBy = (IfcStructuralReaction)(value.EntityVal);
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