// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCGEOMETRICREPRESENTATIONCONTEXT")]
	public  partial class @IfcGeometricRepresentationContext : IfcRepresentationContext, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDimensionCount _coordinateSpaceDimension;
		private float? _precision;
		private IfcAxis2Placement _worldCoordinateSystem;
		private IfcDirection _trueNorth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcDimensionCount @CoordinateSpaceDimension 
		{ 
			get 
			{
				if(IsActivated) return _coordinateSpaceDimension;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _coordinateSpaceDimension;
			} 
			set
			{
				SetValue( v =>  _coordinateSpaceDimension = v, _coordinateSpaceDimension, value,  "CoordinateSpaceDimension");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public float? @Precision 
		{ 
			get 
			{
				if(IsActivated) return _precision;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _precision;
			} 
			set
			{
				SetValue( v =>  _precision = v, _precision, value,  "Precision");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement @WorldCoordinateSystem 
		{ 
			get 
			{
				if(IsActivated) return _worldCoordinateSystem;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _worldCoordinateSystem;
			} 
			set
			{
				SetValue( v =>  _worldCoordinateSystem = v, _worldCoordinateSystem, value,  "WorldCoordinateSystem");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcDirection @TrueNorth 
		{ 
			get 
			{
				if(IsActivated) return _trueNorth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _trueNorth;
			} 
			set
			{
				SetValue( v =>  _trueNorth = v, _trueNorth, value,  "TrueNorth");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcGeometricRepresentationSubContext> @HasSubContexts 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGeometricRepresentationSubContext>(e => e.ParentContext == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ContextIdentifier",
			"ContextType",
			"CoordinateSpaceDimension",
			"Precision",
			"WorldCoordinateSystem",
			"TrueNorth",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ContextIdentifier;
				case 1: 
					return @ContextType;
				case 2: 
					return @CoordinateSpaceDimension;
				case 3: 
					return @Precision;
				case 4: 
					return @WorldCoordinateSystem;
				case 5: 
					return @TrueNorth;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ContextIdentifier":  
					return @ContextIdentifier;
				case "ContextType":  
					return @ContextType;
				case "CoordinateSpaceDimension":  
					return @CoordinateSpaceDimension;
				case "Precision":  
					return @Precision;
				case "WorldCoordinateSystem":  
					return @WorldCoordinateSystem;
				case "TrueNorth":  
					return @TrueNorth;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ContextIdentifier = (IfcLabel?)value;
					 break;
				case 1:
					 @ContextType = (IfcLabel?)value;
					 break;
				case 2:
					 if (value != null) @CoordinateSpaceDimension = (IfcDimensionCount)value;
					 break;
				case 3:
					 @Precision = (float?)value;
					 break;
				case 4:
					 @WorldCoordinateSystem = (IfcAxis2Placement)value;
					 break;
				case 5:
					 @TrueNorth = (IfcDirection)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ContextIdentifier":
					 @ContextIdentifier = (IfcLabel?)value;
					 break;
				case "ContextType":
					 @ContextType = (IfcLabel?)value;
					 break;
				case "CoordinateSpaceDimension":
					 if (value != null) @CoordinateSpaceDimension = (IfcDimensionCount)value;
					 break;
				case "Precision":
					 @Precision = (float?)value;
					 break;
				case "WorldCoordinateSystem":
					 @WorldCoordinateSystem = (IfcAxis2Placement)value;
					 break;
				case "TrueNorth":
					 @TrueNorth = (IfcDirection)value;
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