// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:33
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

namespace Xbim.Ifc2x3.RepresentationResource
{
	[IndexedClass]
	[ExpressType("IFCGEOMETRICREPRESENTATIONSUBCONTEXT", 556)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationSubContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationContext _parentContext;
		private IfcPositiveRatioMeasure? _targetScale;
		private IfcGeometricProjectionEnum _targetView;
		private IfcLabel? _userDefinedTargetView;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcGeometricRepresentationContext @ParentContext 
		{ 
			get 
			{
				if(Activated) return _parentContext;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentContext;
			} 
			set
			{
				SetValue( v =>  _parentContext = v, _parentContext, value,  "ParentContext");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @TargetScale 
		{ 
			get 
			{
				if(Activated) return _targetScale;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetScale;
			} 
			set
			{
				SetValue( v =>  _targetScale = v, _targetScale, value,  "TargetScale");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcGeometricProjectionEnum @TargetView 
		{ 
			get 
			{
				if(Activated) return _targetView;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetView;
			} 
			set
			{
				SetValue( v =>  _targetView = v, _targetView, value,  "TargetView");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedTargetView 
		{ 
			get 
			{
				if(Activated) return _userDefinedTargetView;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedTargetView;
			} 
			set
			{
				SetValue( v =>  _userDefinedTargetView = v, _userDefinedTargetView, value,  "UserDefinedTargetView");
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
					base.Parse(propIndex, value); 
					return;
				case 6: 
					_parentContext = (IfcGeometricRepresentationContext)(value.EntityVal);
					return;
				case 7: 
					_targetScale = value.RealVal;
					return;
				case 8: 
                    _targetView = (IfcGeometricProjectionEnum) System.Enum.Parse(typeof (IfcGeometricProjectionEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedTargetView = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT('IFC2X3.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(ParentContext));*/
		/*WR32:              EXISTS(UserDefinedTargetView));*/
		}
		#endregion
	}
}