// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCBSPLINESURFACE", 35)]
	public abstract partial class @IfcBSplineSurface : IfcBoundedSurface
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurface(IModel model) : base(model) 		{ 
			Model = model; 
			_controlPointsList = new ItemSet<ItemSet<IfcCartesianPoint>>( model );
		}

		#region Explicit attribute fields
		private int _uDegree;
		private int _vDegree;
		private ItemSet<ItemSet<IfcCartesianPoint>> _controlPointsList;
		private IfcBSplineSurfaceForm _surfaceForm;
		private bool? _uClosed;
		private bool? _vClosed;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public int @UDegree 
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public int @VDegree 
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public ItemSet<ItemSet<IfcCartesianPoint>> @ControlPointsList 
		{ 
			get 
			{
				if(Activated) return _controlPointsList;
				
				Model.Activate(this, true);
				Activated = true;
				return _controlPointsList;
			} 
			set
			{
				SetValue( v =>  _controlPointsList = v, _controlPointsList, value,  "ControlPointsList");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
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

		#region Inverse attributes

		#endregion


		#region IPersist implementation
		#endregion

	}
}