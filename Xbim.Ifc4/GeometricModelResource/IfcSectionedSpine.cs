// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCSECTIONEDSPINE", 973)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSpine : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSpine(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSections = new ItemSet<IfcProfileDef>( this );
			_crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this );
		}

		#region Explicit attribute fields
		private IfcCompositeCurve _spineCurve;
		private ItemSet<IfcProfileDef> _crossSections;
		private ItemSet<IfcAxis2Placement3D> _crossSectionPositions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCompositeCurve @SpineCurve 
		{ 
			get 
			{
				if(Activated) return _spineCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _spineCurve;
			} 
			set
			{
				SetValue( v =>  _spineCurve = v, _spineCurve, value,  "SpineCurve");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(Activated) return _crossSections;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSections;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcAxis2Placement3D> @CrossSectionPositions 
		{ 
			get 
			{
				if(Activated) return _crossSectionPositions;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionPositions;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_spineCurve = (IfcCompositeCurve)(value.EntityVal);
					return;
				case 1: 
					if (_crossSections == null) _crossSections = new ItemSet<IfcProfileDef>( this );
					_crossSections.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 2: 
					if (_crossSectionPositions == null) _crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this );
					_crossSectionPositions.InternalAdd((IfcAxis2Placement3D)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrespondingSectionPositions:	CorrespondingSectionPositions : SIZEOF(CrossSections) = SIZEOF(CrossSectionPositions);*/
		/*ConsistentProfileTypes:	ConsistentProfileTypes : SIZEOF(QUERY(temp <* CrossSections | CrossSections[1].ProfileType <> temp.ProfileType)) = 0;*/
		/*SpineCurveDim:	SpineCurveDim : SpineCurve.Dim = 3;*/
		}
		#endregion
	}
}