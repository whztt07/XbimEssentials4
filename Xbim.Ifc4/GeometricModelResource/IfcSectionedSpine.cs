// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometricModelResource
{
	[EntityName("IFCSECTIONEDSPINE", 582)]
	public  partial class @IfcSectionedSpine : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSpine(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSections = new ItemSet<IfcProfileDef>( model );
			_crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( model );
		}

		#region Explicit attribute fields
		private IfcCompositeCurve _spineCurve;
		private ItemSet<IfcProfileDef> _crossSections;
		private ItemSet<IfcAxis2Placement3D> _crossSectionPositions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"SpineCurve",
			"CrossSections",
			"CrossSectionPositions",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SpineCurve;
				case 1: 
					return @CrossSections;
				case 2: 
					return @CrossSectionPositions;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SpineCurve":  
					return @SpineCurve;
				case "CrossSections":  
					return @CrossSections;
				case "CrossSectionPositions":  
					return @CrossSectionPositions;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @SpineCurve = (IfcCompositeCurve)value;
					 break;
				case 1:
					 @CrossSections.Add((IfcProfileDef)value);
					 break;
				case 2:
					 @CrossSectionPositions.Add((IfcAxis2Placement3D)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SpineCurve":
					 @SpineCurve = (IfcCompositeCurve)value;
					 break;
				case "CrossSections":
					 @CrossSections.Add((IfcProfileDef)value);
					 break;
				case "CrossSectionPositions":
					 @CrossSectionPositions.Add((IfcAxis2Placement3D)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrespondingSectionPositions:	CorrespondingSectionPositions : SIZEOF(CrossSections) = SIZEOF(CrossSectionPositions);*/
		/*ConsistentProfileTypes:	ConsistentProfileTypes : SIZEOF(QUERY(temp <* CrossSections | CrossSections[1].ProfileType <> temp.ProfileType)) = 0;*/
		/*SpineCurveDim:	SpineCurveDim : SpineCurve.Dim = 3;*/
		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}