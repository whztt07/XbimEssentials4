// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[EntityName("IFCSECTIONEDSPINE", 300)]
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
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(Activated) return _crossSections;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSections;
			} 
			set
			{
				SetValue( v =>  _crossSections = v, _crossSections, value,  "CrossSections");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcAxis2Placement3D> @CrossSectionPositions 
		{ 
			get 
			{
				if(Activated) return _crossSectionPositions;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionPositions;
			} 
			set
			{
				SetValue( v =>  _crossSectionPositions = v, _crossSectionPositions, value,  "CrossSectionPositions");
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
		/*WR1:	WR1 : SIZEOF(CrossSections) = SIZEOF(CrossSectionPositions);*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* CrossSections | CrossSections[1].ProfileType <> temp.ProfileType)) = 0;*/
		/*WR3:	WR3 : SpineCurve.Dim = 3;*/
		}
		#endregion
	}
}