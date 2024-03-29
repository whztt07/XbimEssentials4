// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[IndexedClass]
	[ExpressType("IFCPRODUCT", 20)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProduct : IfcObject
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProduct(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectPlacement _objectPlacement;
		private IfcProductRepresentation _representation;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @ObjectPlacement 
		{ 
			get 
			{
				if(Activated) return _objectPlacement;
				
				Model.Activate(this, true);
				Activated = true;
				return _objectPlacement;
			} 
			set
			{
				SetValue( v =>  _objectPlacement = v, _objectPlacement, value,  "ObjectPlacement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProductRepresentation @Representation 
		{ 
			get 
			{
				if(Activated) return _representation;
				
				Model.Activate(this, true);
				Activated = true;
				return _representation;
			} 
			set
			{
				SetValue( v =>  _representation = v, _representation, value,  "Representation");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssignsToProduct> @ReferencedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProduct>(e => e.RelatingProduct == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_objectPlacement = (IfcObjectPlacement)(value.EntityVal);
					return;
				case 6: 
					_representation = (IfcProductRepresentation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:                        OR (NOT(EXISTS(Representation)));*/
		}
		#endregion
	}
}