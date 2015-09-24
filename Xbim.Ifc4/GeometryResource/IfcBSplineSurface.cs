// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCBSPLINESURFACE", 426)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBSplineSurface : IfcBoundedSurface
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurface(IModel model) : base(model) 		{ 
			Model = model; 
			_controlPointsList = new ItemSet<ItemSet<IfcCartesianPoint>>( this );
		}

		#region Explicit attribute fields
		private long _uDegree;
		private long _vDegree;
		private ItemSet<ItemSet<IfcCartesianPoint>> _controlPointsList;
		private IfcBSplineSurfaceForm _surfaceForm;
		private bool? _uClosed;
		private bool? _vClosed;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @UDegree 
		{ 
			get 
			{
				if(Activated) return _uDegree;
				
				Model.Activate(this, true);
				Activated = true;
				return _uDegree;
			} 
			set
			{
				SetValue( v =>  _uDegree = v, _uDegree, value,  "UDegree");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @VDegree 
		{ 
			get 
			{
				if(Activated) return _vDegree;
				
				Model.Activate(this, true);
				Activated = true;
				return _vDegree;
			} 
			set
			{
				SetValue( v =>  _vDegree = v, _vDegree, value,  "VDegree");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 2, -1)]
		public ItemSet<ItemSet<IfcCartesianPoint>> @ControlPointsList 
		{ 
			get 
			{
				if(Activated) return _controlPointsList;
				
				Model.Activate(this, true);
				Activated = true;
				return _controlPointsList;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcBSplineSurfaceForm @SurfaceForm 
		{ 
			get 
			{
				if(Activated) return _surfaceForm;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceForm;
			} 
			set
			{
				SetValue( v =>  _surfaceForm = v, _surfaceForm, value,  "SurfaceForm");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @UClosed 
		{ 
			get 
			{
				if(Activated) return _uClosed;
				
				Model.Activate(this, true);
				Activated = true;
				return _uClosed;
			} 
			set
			{
				SetValue( v =>  _uClosed = v, _uClosed, value,  "UClosed");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @VClosed 
		{ 
			get 
			{
				if(Activated) return _vClosed;
				
				Model.Activate(this, true);
				Activated = true;
				return _vClosed;
			} 
			set
			{
				SetValue( v =>  _vClosed = v, _vClosed, value,  "VClosed");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @SelfIntersect 
		{ 
			get 
			{
				if(Activated) return _selfIntersect;
				
				Model.Activate(this, true);
				Activated = true;
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_uDegree = value.IntegerVal;
					return;
				case 1: 
					_vDegree = value.IntegerVal;
					return;
				case 2: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseControlPointsList(propIndex, value);
					//return;
					throw new System.NotImplementedException("ControlPointsList in IfcBSplineSurface is a special case of nested lists. It is not implemented for now.");
				case 3: 
                    _surfaceForm = (IfcBSplineSurfaceForm) System.Enum.Parse(typeof (IfcBSplineSurfaceForm), value.EnumVal, true);
					return;
				case 4: 
					_uClosed = value.BooleanVal;
					return;
				case 5: 
					_vClosed = value.BooleanVal;
					return;
				case 6: 
					_selfIntersect = value.BooleanVal;
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