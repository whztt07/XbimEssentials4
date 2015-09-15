// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:16
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[EntityName("IFCGEOMETRICSET", 236)]
	public  partial class @IfcGeometricSet : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricSet(IModel model) : base(model) 		{ 
			Model = model; 
			_elements = new ItemSet<IfcGeometricSetSelect>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGeometricSetSelect> _elements;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcGeometricSetSelect> @Elements 
		{ 
			get 
			{
				if(Activated) return _elements;
				
				Model.Activate(this, true);
				Activated = true;
				return _elements;
			} 
			set
			{
				SetValue( v =>  _elements = v, _elements, value,  "Elements");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Elements",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Elements;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Elements":  
					return @Elements;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Elements.Add((IfcGeometricSetSelect)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Elements":
					 @Elements.Add((IfcGeometricSetSelect)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:             = 0;*/
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