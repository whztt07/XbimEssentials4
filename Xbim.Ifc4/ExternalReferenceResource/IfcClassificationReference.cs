// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:49
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCCLASSIFICATIONREFERENCE", 486)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationReference : IfcExternalReference, IfcClassificationReferenceSelect, IfcClassificationSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassificationReferenceSelect _referencedSource;
		private IfcText? _description;
		private IfcIdentifier? _sort;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassificationReferenceSelect @ReferencedSource 
		{ 
			get 
			{
				if(Activated) return _referencedSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _referencedSource;
			} 
			set
			{
				SetValue( v =>  _referencedSource = v, _referencedSource, value,  "ReferencedSource");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Sort 
		{ 
			get 
			{
				if(Activated) return _sort;
				
				Model.Activate(this, true);
				Activated = true;
				return _sort;
			} 
			set
			{
				SetValue( v =>  _sort = v, _sort, value,  "Sort");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => e.RelatingClassification == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => e.ReferencedSource == this);
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_referencedSource = (IfcClassificationReferenceSelect)(value.EntityVal);
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_sort = value.StringVal;
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