// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.TopologyResource
{
	[EntityName("IFCORIENTEDEDGE")]
	public  partial class @IfcOrientedEdge : IfcEdge, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrientedEdge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEdge _edgeElement;
		private bool _orientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcEdge @EdgeElement 
		{ 
			get 
			{
				if(IsActivated) return _edgeElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _edgeElement;
			} 
			set
			{
				SetValue( v =>  _edgeElement = v, _edgeElement, value,  "EdgeElement");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public bool @Orientation 
		{ 
			get 
			{
				if(IsActivated) return _orientation;
				
				Model.Activate(this, true);
				IsActivated = true;
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
			"EdgeStart",
			"EdgeEnd",
			"EdgeElement",
			"Orientation",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @EdgeStart;
				case 1: 
					return @EdgeEnd;
				case 2: 
					return @EdgeElement;
				case 3: 
					return @Orientation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "EdgeStart":  
					return @EdgeStart;
				case "EdgeEnd":  
					return @EdgeEnd;
				case "EdgeElement":  
					return @EdgeElement;
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
					 @EdgeStart = (IfcVertex)value;
					 break;
				case 1:
					 @EdgeEnd = (IfcVertex)value;
					 break;
				case 2:
					 @EdgeElement = (IfcEdge)value;
					 break;
				case 3:
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
				case "EdgeStart":
					 @EdgeStart = (IfcVertex)value;
					 break;
				case "EdgeEnd":
					 @EdgeEnd = (IfcVertex)value;
					 break;
				case "EdgeElement":
					 @EdgeElement = (IfcEdge)value;
					 break;
				case "Orientation":
					 if (value != null) @Orientation = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : NOT('IFC2X3.IFCORIENTEDEDGE' IN TYPEOF(EdgeElement));*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}