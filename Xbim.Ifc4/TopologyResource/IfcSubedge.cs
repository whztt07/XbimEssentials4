// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:24
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.TopologyResource
{
	[EntityName("IFCSUBEDGE", 661)]
	public  partial class @IfcSubedge : IfcEdge, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSubedge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEdge _parentEdge;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcEdge @ParentEdge 
		{ 
			get 
			{
				if(Activated) return _parentEdge;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentEdge;
			} 
			set
			{
				SetValue( v =>  _parentEdge = v, _parentEdge, value,  "ParentEdge");
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
			"ParentEdge",
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
					return @ParentEdge;
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
				case "ParentEdge":  
					return @ParentEdge;
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
					 @ParentEdge = (IfcEdge)value;
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
				case "ParentEdge":
					 @ParentEdge = (IfcEdge)value;
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

	}
}