// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProfileResource
{
	[EntityName("IFCISHAPEPROFILEDEF", 314)]
	public  partial class @IfcIShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallWidth;
		private IfcPositiveLengthMeasure _overallDepth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcNonNegativeLengthMeasure? _filletRadius;
		private IfcNonNegativeLengthMeasure? _flangeEdgeRadius;
		private IfcPlaneAngleMeasure? _flangeSlope;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @OverallWidth 
		{ 
			get 
			{
				if(Activated) return _overallWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @OverallDepth 
		{ 
			get 
			{
				if(Activated) return _overallDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallDepth;
			} 
			set
			{
				SetValue( v =>  _overallDepth = v, _overallDepth, value,  "OverallDepth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(Activated) return _webThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(Activated) return _flangeThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(Activated) return _filletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @FlangeEdgeRadius 
		{ 
			get 
			{
				if(Activated) return _flangeEdgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _flangeEdgeRadius = v, _flangeEdgeRadius, value,  "FlangeEdgeRadius");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @FlangeSlope 
		{ 
			get 
			{
				if(Activated) return _flangeSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeSlope;
			} 
			set
			{
				SetValue( v =>  _flangeSlope = v, _flangeSlope, value,  "FlangeSlope");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ProfileType",
			"ProfileName",
			"Position",
			"OverallWidth",
			"OverallDepth",
			"WebThickness",
			"FlangeThickness",
			"FilletRadius",
			"FlangeEdgeRadius",
			"FlangeSlope",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ProfileType;
				case 1: 
					return @ProfileName;
				case 2: 
					return @Position;
				case 3: 
					return @OverallWidth;
				case 4: 
					return @OverallDepth;
				case 5: 
					return @WebThickness;
				case 6: 
					return @FlangeThickness;
				case 7: 
					return @FilletRadius;
				case 8: 
					return @FlangeEdgeRadius;
				case 9: 
					return @FlangeSlope;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ProfileType":  
					return @ProfileType;
				case "ProfileName":  
					return @ProfileName;
				case "Position":  
					return @Position;
				case "OverallWidth":  
					return @OverallWidth;
				case "OverallDepth":  
					return @OverallDepth;
				case "WebThickness":  
					return @WebThickness;
				case "FlangeThickness":  
					return @FlangeThickness;
				case "FilletRadius":  
					return @FilletRadius;
				case "FlangeEdgeRadius":  
					return @FlangeEdgeRadius;
				case "FlangeSlope":  
					return @FlangeSlope;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @ProfileType = (IfcProfileTypeEnum)value;
					 break;
				case 1:
					 @ProfileName = (IfcLabel?)value;
					 break;
				case 2:
					 @Position = (IfcAxis2Placement2D)value;
					 break;
				case 3:
					 if (value != null) @OverallWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 if (value != null) @OverallDepth = (IfcPositiveLengthMeasure)value;
					 break;
				case 5:
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 if (value != null) @FlangeThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 7:
					 @FilletRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case 8:
					 @FlangeEdgeRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case 9:
					 @FlangeSlope = (IfcPlaneAngleMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ProfileType":
					 if (value != null) @ProfileType = (IfcProfileTypeEnum)value;
					 break;
				case "ProfileName":
					 @ProfileName = (IfcLabel?)value;
					 break;
				case "Position":
					 @Position = (IfcAxis2Placement2D)value;
					 break;
				case "OverallWidth":
					 if (value != null) @OverallWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case "OverallDepth":
					 if (value != null) @OverallDepth = (IfcPositiveLengthMeasure)value;
					 break;
				case "WebThickness":
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "FlangeThickness":
					 if (value != null) @FlangeThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "FilletRadius":
					 @FilletRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case "FlangeEdgeRadius":
					 @FlangeEdgeRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case "FlangeSlope":
					 @FlangeSlope = (IfcPlaneAngleMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*ValidFlangeThickness:	ValidFlangeThickness : (2. * FlangeThickness) < OverallDepth;*/
		/*ValidWebThickness:	ValidWebThickness : WebThickness < OverallWidth;*/
		/*ValidFilletRadius:                              (FilletRadius <= (OverallDepth - (2. * FlangeThickness))/2.));*/
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