// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTIONPOINTGEOMETRY", 513)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPointGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPointOrVertexPoint _pointOnRelatingElement;
		private IfcPointOrVertexPoint _pointOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPointOrVertexPoint @PointOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _pointOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _pointOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatingElement = v, _pointOnRelatingElement, value,  "PointOnRelatingElement");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPointOrVertexPoint @PointOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _pointOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _pointOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatedElement = v, _pointOnRelatedElement, value,  "PointOnRelatedElement");
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
					_pointOnRelatingElement = (IfcPointOrVertexPoint)(value.EntityVal);
					return;
				case 1: 
					_pointOnRelatedElement = (IfcPointOrVertexPoint)(value.EntityVal);
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