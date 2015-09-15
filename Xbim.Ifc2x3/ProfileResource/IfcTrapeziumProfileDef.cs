// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:19
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
	[EntityName("IFCTRAPEZIUMPROFILEDEF", 561)]
	public  partial class @IfcTrapeziumProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrapeziumProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomXDim;
		private IfcPositiveLengthMeasure _topXDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcLengthMeasure _topXOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @BottomXDim 
		{ 
			get 
			{
				if(Activated) return _bottomXDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomXDim;
			} 
			set
			{
				SetValue( v =>  _bottomXDim = v, _bottomXDim, value,  "BottomXDim");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @TopXDim 
		{ 
			get 
			{
				if(Activated) return _topXDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _topXDim;
			} 
			set
			{
				SetValue( v =>  _topXDim = v, _topXDim, value,  "TopXDim");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(Activated) return _yDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @TopXOffset 
		{ 
			get 
			{
				if(Activated) return _topXOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _topXOffset;
			} 
			set
			{
				SetValue( v =>  _topXOffset = v, _topXOffset, value,  "TopXOffset");
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
			"BottomXDim",
			"TopXDim",
			"YDim",
			"TopXOffset",
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
					return @BottomXDim;
				case 4: 
					return @TopXDim;
				case 5: 
					return @YDim;
				case 6: 
					return @TopXOffset;
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
				case "BottomXDim":  
					return @BottomXDim;
				case "TopXDim":  
					return @TopXDim;
				case "YDim":  
					return @YDim;
				case "TopXOffset":  
					return @TopXOffset;
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
					 if (value != null) @BottomXDim = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 if (value != null) @TopXDim = (IfcPositiveLengthMeasure)value;
					 break;
				case 5:
					 if (value != null) @YDim = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 if (value != null) @TopXOffset = (IfcLengthMeasure)value;
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
				case "BottomXDim":
					 if (value != null) @BottomXDim = (IfcPositiveLengthMeasure)value;
					 break;
				case "TopXDim":
					 if (value != null) @TopXDim = (IfcPositiveLengthMeasure)value;
					 break;
				case "YDim":
					 if (value != null) @YDim = (IfcPositiveLengthMeasure)value;
					 break;
				case "TopXOffset":
					 if (value != null) @TopXOffset = (IfcLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
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