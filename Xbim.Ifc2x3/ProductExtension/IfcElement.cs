// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralAnalysisDomain;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCELEMENT", 19)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcElement : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Tag 
		{ 
			get 
			{
				if(Activated) return _tag;
				
				Model.Activate(this, true);
				Activated = true;
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsStructuralElement> @HasStructuralMember 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralElement>(e => e.RelatingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelFillsElement> @FillsVoids 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelFillsElement>(e => e.RelatedBuildingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsElements> @ConnectedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsElements>(e => e.RelatingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelCoversBldgElements> @HasCoverings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelCoversBldgElements>(e => e.RelatingBuildingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelProjectsElement> @HasProjections 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelProjectsElement>(e => e.RelatingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelReferencedInSpatialStructure> @ReferencedInStructures 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelReferencedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsPortToElement> @HasPorts 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPortToElement>(e => e.RelatedElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelVoidsElement> @HasOpenings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelVoidsElement>(e => e.RelatingBuildingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsWithRealizingElements> @IsConnectionRealization 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsWithRealizingElements>(e => e.RealizingElements != null &&  e.RealizingElements.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelSpaceBoundary> @ProvidesBoundaries 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary>(e => e.RelatedBuildingElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsElements> @ConnectedFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsElements>(e => e.RelatedElement == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainedInStructure 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
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
					_tag = value.StringVal;
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