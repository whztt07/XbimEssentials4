// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:14
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
	[EntityName("IFCBOUNDARYNODECONDITION", 394)]
	public  partial class @IfcBoundaryNodeCondition : IfcBoundaryCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLinearStiffnessMeasure? _linearStiffnessX;
		private IfcLinearStiffnessMeasure? _linearStiffnessY;
		private IfcLinearStiffnessMeasure? _linearStiffnessZ;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessX;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessY;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessX 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessX;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessX;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessX = v, _linearStiffnessX, value,  "LinearStiffnessX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessY 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessY;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessY;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessY = v, _linearStiffnessY, value,  "LinearStiffnessY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessZ 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessZ = v, _linearStiffnessZ, value,  "LinearStiffnessZ");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessX 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessX;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessX = v, _rotationalStiffnessX, value,  "RotationalStiffnessX");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessY 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessY;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessY = v, _rotationalStiffnessY, value,  "RotationalStiffnessY");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessZ 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessZ = v, _rotationalStiffnessZ, value,  "RotationalStiffnessZ");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"LinearStiffnessX",
			"LinearStiffnessY",
			"LinearStiffnessZ",
			"RotationalStiffnessX",
			"RotationalStiffnessY",
			"RotationalStiffnessZ",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @LinearStiffnessX;
				case 2: 
					return @LinearStiffnessY;
				case 3: 
					return @LinearStiffnessZ;
				case 4: 
					return @RotationalStiffnessX;
				case 5: 
					return @RotationalStiffnessY;
				case 6: 
					return @RotationalStiffnessZ;
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
				case "LinearStiffnessX":  
					return @LinearStiffnessX;
				case "LinearStiffnessY":  
					return @LinearStiffnessY;
				case "LinearStiffnessZ":  
					return @LinearStiffnessZ;
				case "RotationalStiffnessX":  
					return @RotationalStiffnessX;
				case "RotationalStiffnessY":  
					return @RotationalStiffnessY;
				case "RotationalStiffnessZ":  
					return @RotationalStiffnessZ;
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
					 @LinearStiffnessX = (IfcLinearStiffnessMeasure?)value;
					 break;
				case 2:
					 @LinearStiffnessY = (IfcLinearStiffnessMeasure?)value;
					 break;
				case 3:
					 @LinearStiffnessZ = (IfcLinearStiffnessMeasure?)value;
					 break;
				case 4:
					 @RotationalStiffnessX = (IfcRotationalStiffnessMeasure?)value;
					 break;
				case 5:
					 @RotationalStiffnessY = (IfcRotationalStiffnessMeasure?)value;
					 break;
				case 6:
					 @RotationalStiffnessZ = (IfcRotationalStiffnessMeasure?)value;
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
				case "LinearStiffnessX":
					 @LinearStiffnessX = (IfcLinearStiffnessMeasure?)value;
					 break;
				case "LinearStiffnessY":
					 @LinearStiffnessY = (IfcLinearStiffnessMeasure?)value;
					 break;
				case "LinearStiffnessZ":
					 @LinearStiffnessZ = (IfcLinearStiffnessMeasure?)value;
					 break;
				case "RotationalStiffnessX":
					 @RotationalStiffnessX = (IfcRotationalStiffnessMeasure?)value;
					 break;
				case "RotationalStiffnessY":
					 @RotationalStiffnessY = (IfcRotationalStiffnessMeasure?)value;
					 break;
				case "RotationalStiffnessZ":
					 @RotationalStiffnessZ = (IfcRotationalStiffnessMeasure?)value;
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