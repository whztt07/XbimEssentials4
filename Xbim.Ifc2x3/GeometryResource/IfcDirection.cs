// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralAnalysisDomain;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCDIRECTION", 344)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDirection : IfcGeometricRepresentationItem, IfcOrientationSelect, IfcVectorOrDirection, IInstantiableEntity
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
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 3)]
		public ItemSet<double> @DirectionRatios 
		{ 
			get 
			{
				if(Activated) return _directionRatios;
				
				Model.Activate(this, true);
				Activated = true;
				return _directionRatios;
			} 
		}
	
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
			return "";
		}
		#endregion
	}
}