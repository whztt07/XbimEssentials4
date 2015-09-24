// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[IndexedClass]
	[ExpressType("IFCEDGELOOP", 597)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEdgeLoop : IfcLoop, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdgeLoop(IModel model) : base(model) 		{ 
			Model = model; 
			_edgeList = new ItemSet<IfcOrientedEdge>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcOrientedEdge> _edgeList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcOrientedEdge> @EdgeList 
		{ 
			get 
			{
				if(Activated) return _edgeList;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeList;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_edgeList == null) _edgeList = new ItemSet<IfcOrientedEdge>( this );
					_edgeList.InternalAdd((IfcOrientedEdge)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*IsClosed:	IsClosed : (EdgeList[1].EdgeStart) :=: (EdgeList[Ne].EdgeEnd);*/
		/*IsContinuous:	IsContinuous : IfcLoopHeadToTail(SELF);*/
		}
		#endregion
	}
}