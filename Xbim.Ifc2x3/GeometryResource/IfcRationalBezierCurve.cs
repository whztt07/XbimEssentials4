// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCRATIONALBEZIERCURVE", 546)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBezierCurve : IfcBezierCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBezierCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_weightsData = new ItemSet<double>( this );
		}

		#region Explicit attribute fields
		private ItemSet<double> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<double> @WeightsData 
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					if (_weightsData == null) _weightsData = new ItemSet<double>( this );
					_weightsData.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(WeightsData) = SIZEOF(SELF\IfcBSplineCurve.ControlPointsList);*/
		/*WR2:	WR2 : IfcCurveWeightsPositive(SELF);*/
		}
		#endregion
	}
}