// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONVOLUMEGEOMETRY")]
	public  partial class @IfcConnectionVolumeGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionVolumeGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSolidOrShell _volumeOnRelatingElement;
		private IfcSolidOrShell _volumeOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcSolidOrShell @VolumeOnRelatingElement 
		{ 
			get 
			{
				if(IsActivated) return _volumeOnRelatingElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _volumeOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _volumeOnRelatingElement = v, _volumeOnRelatingElement, value,  "VolumeOnRelatingElement");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcSolidOrShell @VolumeOnRelatedElement 
		{ 
			get 
			{
				if(IsActivated) return _volumeOnRelatedElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _volumeOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _volumeOnRelatedElement = v, _volumeOnRelatedElement, value,  "VolumeOnRelatedElement");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"VolumeOnRelatingElement",
			"VolumeOnRelatedElement",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @VolumeOnRelatingElement;
				case 1: 
					return @VolumeOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "VolumeOnRelatingElement":  
					return @VolumeOnRelatingElement;
				case "VolumeOnRelatedElement":  
					return @VolumeOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @VolumeOnRelatingElement = (IfcSolidOrShell)value;
					 break;
				case 1:
					 @VolumeOnRelatedElement = (IfcSolidOrShell)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "VolumeOnRelatingElement":
					 @VolumeOnRelatingElement = (IfcSolidOrShell)value;
					 break;
				case "VolumeOnRelatedElement":
					 @VolumeOnRelatedElement = (IfcSolidOrShell)value;
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