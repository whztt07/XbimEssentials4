// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.TopologyResource
{
	[EntityName("IFCFACEBOUND", 253)]
	public  partial class @IfcFaceBound : IfcTopologicalRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFaceBound(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLoop _bound;
		private bool _orientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcLoop @Bound 
		{ 
			get 
			{
				if(Activated) return _bound;
				
				Model.Activate(this, true);
				Activated = true;
				return _bound;
			} 
			set
			{
				SetValue( v =>  _bound = v, _bound, value,  "Bound");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public bool @Orientation 
		{ 
			get 
			{
				if(Activated) return _orientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Bound",
			"Orientation",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Bound;
				case 1: 
					return @Orientation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Bound":  
					return @Bound;
				case "Orientation":  
					return @Orientation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Bound = (IfcLoop)value;
					 break;
				case 1:
					 if (value != null) @Orientation = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Bound":
					 @Bound = (IfcLoop)value;
					 break;
				case "Orientation":
					 if (value != null) @Orientation = (bool)value;
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

		public  override string WhereRule() 
		{
			return "";
		}
	}
}