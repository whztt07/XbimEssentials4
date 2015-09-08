// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProfileResource
{
	[EntityName("IFCCRANERAILFSHAPEPROFILEDEF", 127)]
	public  partial class @IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCraneRailFShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallHeight;
		private IfcPositiveLengthMeasure _headWidth;
		private IfcPositiveLengthMeasure? _radius;
		private IfcPositiveLengthMeasure _headDepth2;
		private IfcPositiveLengthMeasure _headDepth3;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _baseDepth1;
		private IfcPositiveLengthMeasure _baseDepth2;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @OverallHeight 
		{ 
			get 
			{
				if(Activated) return _overallHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @HeadWidth 
		{ 
			get 
			{
				if(Activated) return _headWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _headWidth;
			} 
			set
			{
				SetValue( v =>  _headWidth = v, _headWidth, value,  "HeadWidth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @Radius 
		{ 
			get 
			{
				if(Activated) return _radius;
				
				Model.Activate(this, true);
				Activated = true;
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @HeadDepth2 
		{ 
			get 
			{
				if(Activated) return _headDepth2;
				
				Model.Activate(this, true);
				Activated = true;
				return _headDepth2;
			} 
			set
			{
				SetValue( v =>  _headDepth2 = v, _headDepth2, value,  "HeadDepth2");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @HeadDepth3 
		{ 
			get 
			{
				if(Activated) return _headDepth3;
				
				Model.Activate(this, true);
				Activated = true;
				return _headDepth3;
			} 
			set
			{
				SetValue( v =>  _headDepth3 = v, _headDepth3, value,  "HeadDepth3");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @BaseDepth1 
		{ 
			get 
			{
				if(Activated) return _baseDepth1;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseDepth1;
			} 
			set
			{
				SetValue( v =>  _baseDepth1 = v, _baseDepth1, value,  "BaseDepth1");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @BaseDepth2 
		{ 
			get 
			{
				if(Activated) return _baseDepth2;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseDepth2;
			} 
			set
			{
				SetValue( v =>  _baseDepth2 = v, _baseDepth2, value,  "BaseDepth2");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInY;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
			"OverallHeight",
			"HeadWidth",
			"Radius",
			"HeadDepth2",
			"HeadDepth3",
			"WebThickness",
			"BaseDepth1",
			"BaseDepth2",
			"CentreOfGravityInY",
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
					return @OverallHeight;
				case 4: 
					return @HeadWidth;
				case 5: 
					return @Radius;
				case 6: 
					return @HeadDepth2;
				case 7: 
					return @HeadDepth3;
				case 8: 
					return @WebThickness;
				case 9: 
					return @BaseDepth1;
				case 10: 
					return @BaseDepth2;
				case 11: 
					return @CentreOfGravityInY;
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
				case "OverallHeight":  
					return @OverallHeight;
				case "HeadWidth":  
					return @HeadWidth;
				case "Radius":  
					return @Radius;
				case "HeadDepth2":  
					return @HeadDepth2;
				case "HeadDepth3":  
					return @HeadDepth3;
				case "WebThickness":  
					return @WebThickness;
				case "BaseDepth1":  
					return @BaseDepth1;
				case "BaseDepth2":  
					return @BaseDepth2;
				case "CentreOfGravityInY":  
					return @CentreOfGravityInY;
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
					 if (value != null) @OverallHeight = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 if (value != null) @HeadWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case 5:
					 @Radius = (IfcPositiveLengthMeasure?)value;
					 break;
				case 6:
					 if (value != null) @HeadDepth2 = (IfcPositiveLengthMeasure)value;
					 break;
				case 7:
					 if (value != null) @HeadDepth3 = (IfcPositiveLengthMeasure)value;
					 break;
				case 8:
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 9:
					 if (value != null) @BaseDepth1 = (IfcPositiveLengthMeasure)value;
					 break;
				case 10:
					 if (value != null) @BaseDepth2 = (IfcPositiveLengthMeasure)value;
					 break;
				case 11:
					 @CentreOfGravityInY = (IfcPositiveLengthMeasure?)value;
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
				case "OverallHeight":
					 if (value != null) @OverallHeight = (IfcPositiveLengthMeasure)value;
					 break;
				case "HeadWidth":
					 if (value != null) @HeadWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case "Radius":
					 @Radius = (IfcPositiveLengthMeasure?)value;
					 break;
				case "HeadDepth2":
					 if (value != null) @HeadDepth2 = (IfcPositiveLengthMeasure)value;
					 break;
				case "HeadDepth3":
					 if (value != null) @HeadDepth3 = (IfcPositiveLengthMeasure)value;
					 break;
				case "WebThickness":
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "BaseDepth1":
					 if (value != null) @BaseDepth1 = (IfcPositiveLengthMeasure)value;
					 break;
				case "BaseDepth2":
					 if (value != null) @BaseDepth2 = (IfcPositiveLengthMeasure)value;
					 break;
				case "CentreOfGravityInY":
					 @CentreOfGravityInY = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}