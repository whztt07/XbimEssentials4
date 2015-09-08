// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[EntityName("IFCSTRUCTURALLOADSINGLEDISPLACEMENTDISTORTION", 549)]
	public  partial class @IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleDisplacementDistortion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurvatureMeasure? _distortion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcCurvatureMeasure? @Distortion 
		{ 
			get 
			{
				if(Activated) return _distortion;
				
				Model.Activate(this, true);
				Activated = true;
				return _distortion;
			} 
			set
			{
				SetValue( v =>  _distortion = v, _distortion, value,  "Distortion");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"DisplacementX",
			"DisplacementY",
			"DisplacementZ",
			"RotationalDisplacementRX",
			"RotationalDisplacementRY",
			"RotationalDisplacementRZ",
			"Distortion",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @DisplacementX;
				case 2: 
					return @DisplacementY;
				case 3: 
					return @DisplacementZ;
				case 4: 
					return @RotationalDisplacementRX;
				case 5: 
					return @RotationalDisplacementRY;
				case 6: 
					return @RotationalDisplacementRZ;
				case 7: 
					return @Distortion;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "DisplacementX":  
					return @DisplacementX;
				case "DisplacementY":  
					return @DisplacementY;
				case "DisplacementZ":  
					return @DisplacementZ;
				case "RotationalDisplacementRX":  
					return @RotationalDisplacementRX;
				case "RotationalDisplacementRY":  
					return @RotationalDisplacementRY;
				case "RotationalDisplacementRZ":  
					return @RotationalDisplacementRZ;
				case "Distortion":  
					return @Distortion;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @DisplacementX = (IfcLengthMeasure?)value;
					 break;
				case 2:
					 @DisplacementY = (IfcLengthMeasure?)value;
					 break;
				case 3:
					 @DisplacementZ = (IfcLengthMeasure?)value;
					 break;
				case 4:
					 @RotationalDisplacementRX = (IfcPlaneAngleMeasure?)value;
					 break;
				case 5:
					 @RotationalDisplacementRY = (IfcPlaneAngleMeasure?)value;
					 break;
				case 6:
					 @RotationalDisplacementRZ = (IfcPlaneAngleMeasure?)value;
					 break;
				case 7:
					 @Distortion = (IfcCurvatureMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "DisplacementX":
					 @DisplacementX = (IfcLengthMeasure?)value;
					 break;
				case "DisplacementY":
					 @DisplacementY = (IfcLengthMeasure?)value;
					 break;
				case "DisplacementZ":
					 @DisplacementZ = (IfcLengthMeasure?)value;
					 break;
				case "RotationalDisplacementRX":
					 @RotationalDisplacementRX = (IfcPlaneAngleMeasure?)value;
					 break;
				case "RotationalDisplacementRY":
					 @RotationalDisplacementRY = (IfcPlaneAngleMeasure?)value;
					 break;
				case "RotationalDisplacementRZ":
					 @RotationalDisplacementRZ = (IfcPlaneAngleMeasure?)value;
					 break;
				case "Distortion":
					 @Distortion = (IfcCurvatureMeasure?)value;
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