// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProcessExtension
{
	[EntityName("IFCRELSEQUENCE", 551)]
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
		private IfcLagTime _timeLag;
		private IfcSequenceEnum? _sequenceType;
		private IfcLabel? _userDefinedSequenceType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(6, EntityAttributeState.Optional)]
		public IfcLagTime @TimeLag 
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
	
		[EntityAttributee(7, EntityAttributeState.Optional)]
		public IfcSequenceEnum? @SequenceType 
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
	
		[EntityAttributee(8, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedSequenceType 
		{ 
			get 
			{
				if(Activated) return _userDefinedSequenceType;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedSequenceType;
			} 
			set
			{
				SetValue( v =>  _userDefinedSequenceType = v, _userDefinedSequenceType, value,  "UserDefinedSequenceType");
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
					_timeLag = (IfcLagTime)(value.EntityVal);
					return;
				case 7: 
                    _sequenceType = (IfcSequenceEnum) System.Enum.Parse(typeof (IfcSequenceEnum), value.EnumVal, true);
					return;
				case 8: 
					_userDefinedSequenceType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*AvoidInconsistentSequence:	AvoidInconsistentSequence : RelatingProcess :<>: RelatedProcess;*/
		/*CorrectSequenceType:	CorrectSequenceType : (SequenceType <> IfcSequenceEnum.USERDEFINED) OR ((SequenceType = IfcSequenceEnum.USERDEFINED) AND EXISTS(UserDefinedSequenceType));*/
		}
		#endregion
	}
}