// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCGEOMETRICSET", 695)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricSet : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricSet(IModel model) : base(model) 		{ 
			Model = model; 
			_elements = new ItemSet<IfcGeometricSetSelect>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGeometricSetSelect> _elements;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcGeometricSetSelect> @Elements 
		{ 
			get 
			{
				if(Activated) return _elements;
				
				Model.Activate(this, true);
				Activated = true;
				return _elements;
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
					if (_elements == null) _elements = new ItemSet<IfcGeometricSetSelect>( this );
					_elements.InternalAdd((IfcGeometricSetSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ConsistentDim:                      = 0;*/
		}
		#endregion
	}
}