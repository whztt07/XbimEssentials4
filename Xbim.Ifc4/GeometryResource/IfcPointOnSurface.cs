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
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCPOINTONSURFACE")]
	public  partial class @IfcPointOnSurface : IfcPoint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPointOnSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcParameterValue _pointParameterU;
		private IfcParameterValue _pointParameterV;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(IsActivated) return _basisSurface;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcParameterValue @PointParameterU 
		{ 
			get 
			{
				if(IsActivated) return _pointParameterU;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _pointParameterU;
			} 
			set
			{
				SetValue( v =>  _pointParameterU = v, _pointParameterU, value,  "PointParameterU");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcParameterValue @PointParameterV 
		{ 
			get 
			{
				if(IsActivated) return _pointParameterV;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _pointParameterV;
			} 
			set
			{
				SetValue( v =>  _pointParameterV = v, _pointParameterV, value,  "PointParameterV");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"BasisSurface",
			"PointParameterU",
			"PointParameterV",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @BasisSurface;
				case 1: 
					return @PointParameterU;
				case 2: 
					return @PointParameterV;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "BasisSurface":  
					return @BasisSurface;
				case "PointParameterU":  
					return @PointParameterU;
				case "PointParameterV":  
					return @PointParameterV;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @BasisSurface = (IfcSurface)value;
					 break;
				case 1:
					 if (value != null) @PointParameterU = (IfcParameterValue)value;
					 break;
				case 2:
					 if (value != null) @PointParameterV = (IfcParameterValue)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "BasisSurface":
					 @BasisSurface = (IfcSurface)value;
					 break;
				case "PointParameterU":
					 if (value != null) @PointParameterU = (IfcParameterValue)value;
					 break;
				case "PointParameterV":
					 if (value != null) @PointParameterV = (IfcParameterValue)value;
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