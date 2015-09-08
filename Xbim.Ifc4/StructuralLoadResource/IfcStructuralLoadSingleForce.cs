// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:24
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
	[EntityName("IFCSTRUCTURALLOADSINGLEFORCE", 640)]
	public  partial class @IfcStructuralLoadSingleForce : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcForceMeasure? _forceX;
		private IfcForceMeasure? _forceY;
		private IfcForceMeasure? _forceZ;
		private IfcTorqueMeasure? _momentX;
		private IfcTorqueMeasure? _momentY;
		private IfcTorqueMeasure? _momentZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcForceMeasure? @ForceX 
		{ 
			get 
			{
				if(Activated) return _forceX;
				
				Model.Activate(this, true);
				Activated = true;
				return _forceX;
			} 
			set
			{
				SetValue( v =>  _forceX = v, _forceX, value,  "ForceX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcForceMeasure? @ForceY 
		{ 
			get 
			{
				if(Activated) return _forceY;
				
				Model.Activate(this, true);
				Activated = true;
				return _forceY;
			} 
			set
			{
				SetValue( v =>  _forceY = v, _forceY, value,  "ForceY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcForceMeasure? @ForceZ 
		{ 
			get 
			{
				if(Activated) return _forceZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _forceZ;
			} 
			set
			{
				SetValue( v =>  _forceZ = v, _forceZ, value,  "ForceZ");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcTorqueMeasure? @MomentX 
		{ 
			get 
			{
				if(Activated) return _momentX;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentX;
			} 
			set
			{
				SetValue( v =>  _momentX = v, _momentX, value,  "MomentX");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcTorqueMeasure? @MomentY 
		{ 
			get 
			{
				if(Activated) return _momentY;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentY;
			} 
			set
			{
				SetValue( v =>  _momentY = v, _momentY, value,  "MomentY");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcTorqueMeasure? @MomentZ 
		{ 
			get 
			{
				if(Activated) return _momentZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentZ;
			} 
			set
			{
				SetValue( v =>  _momentZ = v, _momentZ, value,  "MomentZ");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"ForceX",
			"ForceY",
			"ForceZ",
			"MomentX",
			"MomentY",
			"MomentZ",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @ForceX;
				case 2: 
					return @ForceY;
				case 3: 
					return @ForceZ;
				case 4: 
					return @MomentX;
				case 5: 
					return @MomentY;
				case 6: 
					return @MomentZ;
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
				case "ForceX":  
					return @ForceX;
				case "ForceY":  
					return @ForceY;
				case "ForceZ":  
					return @ForceZ;
				case "MomentX":  
					return @MomentX;
				case "MomentY":  
					return @MomentY;
				case "MomentZ":  
					return @MomentZ;
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
					 @ForceX = (IfcForceMeasure?)value;
					 break;
				case 2:
					 @ForceY = (IfcForceMeasure?)value;
					 break;
				case 3:
					 @ForceZ = (IfcForceMeasure?)value;
					 break;
				case 4:
					 @MomentX = (IfcTorqueMeasure?)value;
					 break;
				case 5:
					 @MomentY = (IfcTorqueMeasure?)value;
					 break;
				case 6:
					 @MomentZ = (IfcTorqueMeasure?)value;
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
				case "ForceX":
					 @ForceX = (IfcForceMeasure?)value;
					 break;
				case "ForceY":
					 @ForceY = (IfcForceMeasure?)value;
					 break;
				case "ForceZ":
					 @ForceZ = (IfcForceMeasure?)value;
					 break;
				case "MomentX":
					 @MomentX = (IfcTorqueMeasure?)value;
					 break;
				case "MomentY":
					 @MomentY = (IfcTorqueMeasure?)value;
					 break;
				case "MomentZ":
					 @MomentZ = (IfcTorqueMeasure?)value;
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