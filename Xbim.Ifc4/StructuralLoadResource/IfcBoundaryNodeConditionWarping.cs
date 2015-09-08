// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:20
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[EntityName("IFCBOUNDARYNODECONDITIONWARPING", 51)]
	public  partial class @IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeConditionWarping(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWarpingStiffnessSelect _warpingStiffness;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcWarpingStiffnessSelect @WarpingStiffness 
		{ 
			get 
			{
				if(Activated) return _warpingStiffness;
				
				Model.Activate(this, true);
				Activated = true;
				return _warpingStiffness;
			} 
			set
			{
				SetValue( v =>  _warpingStiffness = v, _warpingStiffness, value,  "WarpingStiffness");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"TranslationalStiffnessX",
			"TranslationalStiffnessY",
			"TranslationalStiffnessZ",
			"RotationalStiffnessX",
			"RotationalStiffnessY",
			"RotationalStiffnessZ",
			"WarpingStiffness",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @TranslationalStiffnessX;
				case 2: 
					return @TranslationalStiffnessY;
				case 3: 
					return @TranslationalStiffnessZ;
				case 4: 
					return @RotationalStiffnessX;
				case 5: 
					return @RotationalStiffnessY;
				case 6: 
					return @RotationalStiffnessZ;
				case 7: 
					return @WarpingStiffness;
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
				case "TranslationalStiffnessX":  
					return @TranslationalStiffnessX;
				case "TranslationalStiffnessY":  
					return @TranslationalStiffnessY;
				case "TranslationalStiffnessZ":  
					return @TranslationalStiffnessZ;
				case "RotationalStiffnessX":  
					return @RotationalStiffnessX;
				case "RotationalStiffnessY":  
					return @RotationalStiffnessY;
				case "RotationalStiffnessZ":  
					return @RotationalStiffnessZ;
				case "WarpingStiffness":  
					return @WarpingStiffness;
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
					 @TranslationalStiffnessX = (IfcTranslationalStiffnessSelect)value;
					 break;
				case 2:
					 @TranslationalStiffnessY = (IfcTranslationalStiffnessSelect)value;
					 break;
				case 3:
					 @TranslationalStiffnessZ = (IfcTranslationalStiffnessSelect)value;
					 break;
				case 4:
					 @RotationalStiffnessX = (IfcRotationalStiffnessSelect)value;
					 break;
				case 5:
					 @RotationalStiffnessY = (IfcRotationalStiffnessSelect)value;
					 break;
				case 6:
					 @RotationalStiffnessZ = (IfcRotationalStiffnessSelect)value;
					 break;
				case 7:
					 @WarpingStiffness = (IfcWarpingStiffnessSelect)value;
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
				case "TranslationalStiffnessX":
					 @TranslationalStiffnessX = (IfcTranslationalStiffnessSelect)value;
					 break;
				case "TranslationalStiffnessY":
					 @TranslationalStiffnessY = (IfcTranslationalStiffnessSelect)value;
					 break;
				case "TranslationalStiffnessZ":
					 @TranslationalStiffnessZ = (IfcTranslationalStiffnessSelect)value;
					 break;
				case "RotationalStiffnessX":
					 @RotationalStiffnessX = (IfcRotationalStiffnessSelect)value;
					 break;
				case "RotationalStiffnessY":
					 @RotationalStiffnessY = (IfcRotationalStiffnessSelect)value;
					 break;
				case "RotationalStiffnessZ":
					 @RotationalStiffnessZ = (IfcRotationalStiffnessSelect)value;
					 break;
				case "WarpingStiffness":
					 @WarpingStiffness = (IfcWarpingStiffnessSelect)value;
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