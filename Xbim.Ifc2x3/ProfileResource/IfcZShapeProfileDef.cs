// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:39
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
	[EntityName("IFCZSHAPEPROFILEDEF")]
	public  partial class @IfcZShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcZShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _flangeWidth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcPositiveLengthMeasure? _filletRadius;
		private IfcPositiveLengthMeasure? _edgeRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(IsActivated) return _depth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @FlangeWidth 
		{ 
			get 
			{
				if(IsActivated) return _flangeWidth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _flangeWidth;
			} 
			set
			{
				SetValue( v =>  _flangeWidth = v, _flangeWidth, value,  "FlangeWidth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(IsActivated) return _webThickness;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _flangeThickness;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(IsActivated) return _filletRadius;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(IsActivated) return _edgeRadius;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius");
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
			"Depth",
			"FlangeWidth",
			"WebThickness",
			"FlangeThickness",
			"FilletRadius",
			"EdgeRadius",
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
					return @Depth;
				case 4: 
					return @FlangeWidth;
				case 5: 
					return @WebThickness;
				case 6: 
					return @FlangeThickness;
				case 7: 
					return @FilletRadius;
				case 8: 
					return @EdgeRadius;
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
				case "Depth":  
					return @Depth;
				case "FlangeWidth":  
					return @FlangeWidth;
				case "WebThickness":  
					return @WebThickness;
				case "FlangeThickness":  
					return @FlangeThickness;
				case "FilletRadius":  
					return @FilletRadius;
				case "EdgeRadius":  
					return @EdgeRadius;
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
					 if (value != null) @Depth = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 if (value != null) @FlangeWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case 5:
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 if (value != null) @FlangeThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 7:
					 @FilletRadius = (IfcPositiveLengthMeasure?)value;
					 break;
				case 8:
					 @EdgeRadius = (IfcPositiveLengthMeasure?)value;
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
				case "Depth":
					 if (value != null) @Depth = (IfcPositiveLengthMeasure)value;
					 break;
				case "FlangeWidth":
					 if (value != null) @FlangeWidth = (IfcPositiveLengthMeasure)value;
					 break;
				case "WebThickness":
					 if (value != null) @WebThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "FlangeThickness":
					 if (value != null) @FlangeThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "FilletRadius":
					 @FilletRadius = (IfcPositiveLengthMeasure?)value;
					 break;
				case "EdgeRadius":
					 @EdgeRadius = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:	WR21 : FlangeThickness < (Depth / 2.);*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}