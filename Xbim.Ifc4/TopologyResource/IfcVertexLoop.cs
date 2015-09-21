// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:21
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
	[ExpressType("IFCVERTEXLOOP", 1131)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexLoop : IfcLoop, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexLoop(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVertex _loopVertex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVertex @LoopVertex 
		{ 
			get 
			{
				if(Activated) return _loopVertex;
				
				Model.Activate(this, true);
				Activated = true;
				return _loopVertex;
			} 
			set
			{
				SetValue( v =>  _loopVertex = v, _loopVertex, value,  "LoopVertex");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_loopVertex = (IfcVertex)(value.EntityVal);
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