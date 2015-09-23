// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:51
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCRATIONALBSPLINESURFACEWITHKNOTS", 885)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBSplineSurfaceWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_weightsData = new ItemSet<ItemSet<double>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<double>> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 2, -1)]
		public ItemSet<ItemSet<double>> @WeightsData 
		{ 
			get 
			{
				if(Activated) return _weightsData;
				
				Model.Activate(this, true);
				Activated = true;
				return _weightsData;
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value); 
					return;
				case 12: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseWeightsData(propIndex, value);
					//return;
					throw new System.NotImplementedException("WeightsData in IfcRationalBSplineSurfaceWithKnots is a special case of nested lists. It is not implemented for now.");
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrespondingWeightsDataLists:                                      (SIZEOF(WeightsData[1]) = SIZEOF(SELF\IfcBSplineSurface.ControlPointsList[1]));*/
		/*WeightValuesGreaterZero:	WeightValuesGreaterZero : IfcSurfaceWeightsPositive(SELF);*/
		}
		#endregion
	}
}