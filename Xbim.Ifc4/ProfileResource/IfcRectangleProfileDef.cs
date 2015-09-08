// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:42
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
	[EntityName("IFCRECTANGLEPROFILEDEF")]
	public  partial class @IfcRectangleProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @XDim 
		{ 
			get 
			{
				if(IsActivated) return _xDim;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _xDim;
			} 
			set
			{
				SetValue( v =>  _xDim = v, _xDim, value,  "XDim");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(IsActivated) return _yDim;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim");
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
			"XDim",
			"YDim",
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
					return @XDim;
				case 4: 
					return @YDim;
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
				case "XDim":  
					return @XDim;
				case "YDim":  
					return @YDim;
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
					 if (value != null) @XDim = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 if (value != null) @YDim = (IfcPositiveLengthMeasure)value;
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
				case "XDim":
					 if (value != null) @XDim = (IfcPositiveLengthMeasure)value;
					 break;
				case "YDim":
					 if (value != null) @YDim = (IfcPositiveLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}