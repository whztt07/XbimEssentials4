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

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR2DNONUNIFORM", 147)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @Scale2 
		{ 
			get 
			{
				if(Activated) return _scale2;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2");
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
				case 4: 
					_scale2 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Scl2 > 0.0;*/
		}
		#endregion
	}
}