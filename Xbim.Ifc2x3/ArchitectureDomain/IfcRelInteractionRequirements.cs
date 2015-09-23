// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProductExtension;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ArchitectureDomain
{
	[IndexedClass]
	[ExpressType("IFCRELINTERACTIONREQUIREMENTS", 708)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelInteractionRequirements : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelInteractionRequirements(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCountMeasure? _dailyInteraction;
		private IfcNormalisedRatioMeasure? _importanceRating;
		private IfcSpatialStructureElement _locationOfInteraction;
		private IfcSpaceProgram _relatedSpaceProgram;
		private IfcSpaceProgram _relatingSpaceProgram;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCountMeasure? @DailyInteraction 
		{ 
			get 
			{
				if(Activated) return _dailyInteraction;
				
				Model.Activate(this, true);
				Activated = true;
				return _dailyInteraction;
			} 
			set
			{
				SetValue( v =>  _dailyInteraction = v, _dailyInteraction, value,  "DailyInteraction");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @ImportanceRating 
		{ 
			get 
			{
				if(Activated) return _importanceRating;
				
				Model.Activate(this, true);
				Activated = true;
				return _importanceRating;
			} 
			set
			{
				SetValue( v =>  _importanceRating = v, _importanceRating, value,  "ImportanceRating");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpatialStructureElement @LocationOfInteraction 
		{ 
			get 
			{
				if(Activated) return _locationOfInteraction;
				
				Model.Activate(this, true);
				Activated = true;
				return _locationOfInteraction;
			} 
			set
			{
				SetValue( v =>  _locationOfInteraction = v, _locationOfInteraction, value,  "LocationOfInteraction");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpaceProgram @RelatedSpaceProgram 
		{ 
			get 
			{
				if(Activated) return _relatedSpaceProgram;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedSpaceProgram;
			} 
			set
			{
				SetValue( v =>  _relatedSpaceProgram = v, _relatedSpaceProgram, value,  "RelatedSpaceProgram");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpaceProgram @RelatingSpaceProgram 
		{ 
			get 
			{
				if(Activated) return _relatingSpaceProgram;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingSpaceProgram;
			} 
			set
			{
				SetValue( v =>  _relatingSpaceProgram = v, _relatingSpaceProgram, value,  "RelatingSpaceProgram");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_dailyInteraction = value.NumberVal;
					return;
				case 5: 
					_importanceRating = value.RealVal;
					return;
				case 6: 
					_locationOfInteraction = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 7: 
					_relatedSpaceProgram = (IfcSpaceProgram)(value.EntityVal);
					return;
				case 8: 
					_relatingSpaceProgram = (IfcSpaceProgram)(value.EntityVal);
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