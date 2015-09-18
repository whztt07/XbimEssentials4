// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCDIRECTION", 173)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDirection : IfcGeometricRepresentationItem, IfcGridPlacementDirectionSelect, IfcVectorOrDirection, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDirection(IModel model) : base(model) 		{ 
			Model = model; 
			_directionRatios = new ItemSet<double>( this );
		}

		#region Explicit attribute fields
		private ItemSet<double> _directionRatios;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public ItemSet<double> @DirectionRatios 
		{ 
			get 
			{
				if(Activated) return _directionRatios;
				
				Model.Activate(this, true);
				Activated = true;
				return _directionRatios;
			} 
			set
			{
				SetValue( v =>  _directionRatios = v, _directionRatios, value,  "DirectionRatios");
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
					if (_directionRatios == null) _directionRatios = new ItemSet<double>( this );
					_directionRatios.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*MagnitudeGreaterZero:	MagnitudeGreaterZero : SIZEOF(QUERY(Tmp <* DirectionRatios | Tmp <> 0.0)) > 0;*/
		}
		#endregion
	}
}