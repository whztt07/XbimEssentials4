// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.TopologyResource
{
	[EntityName("IFCEDGELOOP", 302)]
	public  partial class @IfcEdgeLoop : IfcLoop, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdgeLoop(IModel model) : base(model) 		{ 
			Model = model; 
			_edgeList = new ItemSet<IfcOrientedEdge>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcOrientedEdge> _edgeList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcOrientedEdge> @EdgeList 
		{ 
			get 
			{
				if(Activated) return _edgeList;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeList;
			} 
			set
			{
				SetValue( v =>  _edgeList = v, _edgeList, value,  "EdgeList");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"EdgeList",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @EdgeList;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "EdgeList":  
					return @EdgeList;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @EdgeList.Add((IfcOrientedEdge)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "EdgeList":
					 @EdgeList.Add((IfcOrientedEdge)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : (EdgeList[1].EdgeStart) :=: (EdgeList[Ne].EdgeEnd);*/
		/*WR2:	WR2 : IfcLoopHeadToTail(SELF);*/
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