// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.RepresentationResource
{
	[IndexedClass]
	[ExpressType("IFCSHAPEMODEL", 89)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcShapeModel : IfcRepresentation
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShapeModel(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcShapeAspect> @OfShapeAspect 
		{ 
			get 
			{
				return Model.Instances.Where<IfcShapeAspect>(e => e.ShapeRepresentations != null &&  e.ShapeRepresentations.Contains(this));
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
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:             (SIZEOF(OfShapeAspect) = 1);*/
		}
		#endregion
	}
}