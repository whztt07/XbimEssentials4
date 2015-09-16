// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[EntityName("IFCSTRUCTURALLOADSINGLEFORCEWARPING", 393)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleForceWarping(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWarpingMomentMeasure? _warpingMoment;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcWarpingMomentMeasure? @WarpingMoment 
		{ 
			get 
			{
				if(Activated) return _warpingMoment;
				
				Model.Activate(this, true);
				Activated = true;
				return _warpingMoment;
			} 
			set
			{
				SetValue( v =>  _warpingMoment = v, _warpingMoment, value,  "WarpingMoment");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Name",
			"ForceX",
			"ForceY",
			"ForceZ",
			"MomentX",
			"MomentY",
			"MomentZ",
			"WarpingMoment",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
				case 7: 
					return @WarpingMoment;
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
				case "WarpingMoment":  
					return @WarpingMoment;
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
				case 7:
					 @WarpingMoment = (IfcWarpingMomentMeasure?)value;
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
				case "WarpingMoment":
					 @WarpingMoment = (IfcWarpingMomentMeasure?)value;
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_warpingMoment = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		
	}
}