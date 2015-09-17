// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:55
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[EntityName("IFCEDGE", 202)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEdge : IfcTopologicalRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVertex _edgeStart;
		private IfcVertex _edgeEnd;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcVertex @EdgeStart 
		{ 
			get 
			{
				if(Activated) return _edgeStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeStart;
			} 
			set
			{
				SetValue( v =>  _edgeStart = v, _edgeStart, value,  "EdgeStart");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcVertex @EdgeEnd 
		{ 
			get 
			{
				if(Activated) return _edgeEnd;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeEnd;
			} 
			set
			{
				SetValue( v =>  _edgeEnd = v, _edgeEnd, value,  "EdgeEnd");
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
					_edgeStart = (IfcVertex)(value.EntityVal);
					return;
				case 1: 
					_edgeEnd = (IfcVertex)(value.EntityVal);
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