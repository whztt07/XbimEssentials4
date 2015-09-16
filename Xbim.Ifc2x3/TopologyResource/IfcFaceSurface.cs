// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[EntityName("IFCFACESURFACE", 85)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFaceSurface : IfcFace, IfcSurfaceOrFaceSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFaceSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _faceSurface;
		private bool _sameSense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcSurface @FaceSurface 
		{ 
			get 
			{
				if(Activated) return _faceSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _faceSurface;
			} 
			set
			{
				SetValue( v =>  _faceSurface = v, _faceSurface, value,  "FaceSurface");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public bool @SameSense 
		{ 
			get 
			{
				if(Activated) return _sameSense;
				
				Model.Activate(this, true);
				Activated = true;
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Bounds",
			"FaceSurface",
			"SameSense",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Bounds;
				case 1: 
					return @FaceSurface;
				case 2: 
					return @SameSense;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Bounds":  
					return @Bounds;
				case "FaceSurface":  
					return @FaceSurface;
				case "SameSense":  
					return @SameSense;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Bounds.Add((IfcFaceBound)value);
					 break;
				case 1:
					 @FaceSurface = (IfcSurface)value;
					 break;
				case 2:
					 if (value != null) @SameSense = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Bounds":
					 @Bounds.Add((IfcFaceBound)value);
					 break;
				case "FaceSurface":
					 @FaceSurface = (IfcSurface)value;
					 break;
				case "SameSense":
					 if (value != null) @SameSense = (bool)value;
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_faceSurface = (IfcSurface)(value.EntityVal);
					return;
				case 2: 
					_sameSense = value.BooleanVal;
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