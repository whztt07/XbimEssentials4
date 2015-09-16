// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfileResource
{
	[EntityName("IFCCSHAPEPROFILEDEF", 501)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _width;
		private IfcPositiveLengthMeasure _wallThickness;
		private IfcPositiveLengthMeasure _girth;
		private IfcPositiveLengthMeasure? _internalFilletRadius;
		private IfcPositiveLengthMeasure? _centreOfGravityInX;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(Activated) return _depth;
				
				Model.Activate(this, true);
				Activated = true;
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Width 
		{ 
			get 
			{
				if(Activated) return _width;
				
				Model.Activate(this, true);
				Activated = true;
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @WallThickness 
		{ 
			get 
			{
				if(Activated) return _wallThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _wallThickness;
			} 
			set
			{
				SetValue( v =>  _wallThickness = v, _wallThickness, value,  "WallThickness");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Girth 
		{ 
			get 
			{
				if(Activated) return _girth;
				
				Model.Activate(this, true);
				Activated = true;
				return _girth;
			} 
			set
			{
				SetValue( v =>  _girth = v, _girth, value,  "Girth");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @InternalFilletRadius 
		{ 
			get 
			{
				if(Activated) return _internalFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _internalFilletRadius;
			} 
			set
			{
				SetValue( v =>  _internalFilletRadius = v, _internalFilletRadius, value,  "InternalFilletRadius");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInX;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"ProfileType",
			"ProfileName",
			"Position",
			"Depth",
			"Width",
			"WallThickness",
			"Girth",
			"InternalFilletRadius",
			"CentreOfGravityInX",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @Width;
				case 5: 
					return @WallThickness;
				case 6: 
					return @Girth;
				case 7: 
					return @InternalFilletRadius;
				case 8: 
					return @CentreOfGravityInX;
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
				case "Width":  
					return @Width;
				case "WallThickness":  
					return @WallThickness;
				case "Girth":  
					return @Girth;
				case "InternalFilletRadius":  
					return @InternalFilletRadius;
				case "CentreOfGravityInX":  
					return @CentreOfGravityInX;
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
					 if (value != null) @Width = (IfcPositiveLengthMeasure)value;
					 break;
				case 5:
					 if (value != null) @WallThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 if (value != null) @Girth = (IfcPositiveLengthMeasure)value;
					 break;
				case 7:
					 @InternalFilletRadius = (IfcPositiveLengthMeasure?)value;
					 break;
				case 8:
					 @CentreOfGravityInX = (IfcPositiveLengthMeasure?)value;
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
				case "Width":
					 if (value != null) @Width = (IfcPositiveLengthMeasure)value;
					 break;
				case "WallThickness":
					 if (value != null) @WallThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "Girth":
					 if (value != null) @Girth = (IfcPositiveLengthMeasure)value;
					 break;
				case "InternalFilletRadius":
					 @InternalFilletRadius = (IfcPositiveLengthMeasure?)value;
					 break;
				case "CentreOfGravityInX":
					 @CentreOfGravityInX = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
					_depth = value.RealVal;
					return;
				case 4: 
					_width = value.RealVal;
					return;
				case 5: 
					_wallThickness = value.RealVal;
					return;
				case 6: 
					_girth = value.RealVal;
					return;
				case 7: 
					_internalFilletRadius = value.RealVal;
					return;
				case 8: 
					_centreOfGravityInX = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Girth < (Depth / 2.);*/
		/*WR2:            ((InternalFilletRadius <= Width/2.) AND (InternalFilletRadius <= Depth/2.));*/
		/*WR3:	WR3 : (WallThickness < Width/2.) AND (WallThickness < Depth/2.);*/
		}
		#endregion

		
	}
}