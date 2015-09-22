// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[IndexedClass]
	[ExpressType("IFCRELSEQUENCE", 490)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSequence : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSequence(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProcess _relatingProcess;
		private IfcProcess _relatedProcess;
		private IfcTimeMeasure _timeLag;
		private IfcSequenceEnum _sequenceType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcess @RelatingProcess 
		{ 
			get 
			{
				if(Activated) return _relatingProcess;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingProcess;
			} 
			set
			{
				SetValue( v =>  _relatingProcess = v, _relatingProcess, value,  "RelatingProcess");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcess @RelatedProcess 
		{ 
			get 
			{
				if(Activated) return _relatedProcess;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedProcess;
			} 
			set
			{
				SetValue( v =>  _relatedProcess = v, _relatedProcess, value,  "RelatedProcess");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure @TimeLag 
		{ 
			get 
			{
				if(Activated) return _timeLag;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeLag;
			} 
			set
			{
				SetValue( v =>  _timeLag = v, _timeLag, value,  "TimeLag");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSequenceEnum @SequenceType 
		{ 
			get 
			{
				if(Activated) return _sequenceType;
				
				Model.Activate(this, true);
				Activated = true;
				return _sequenceType;
			} 
			set
			{
				SetValue( v =>  _sequenceType = v, _sequenceType, value,  "SequenceType");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_relatingProcess = (IfcProcess)(value.EntityVal);
					return;
				case 5: 
					_relatedProcess = (IfcProcess)(value.EntityVal);
					return;
				case 6: 
					_timeLag = value.RealVal;
					return;
				case 7: 
                    _sequenceType = (IfcSequenceEnum) System.Enum.Parse(typeof (IfcSequenceEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : RelatingProcess :<>: RelatedProcess;*/
		}
		#endregion
	}
}