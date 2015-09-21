// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfileResource
{
	[IndexedClass]
	[ExpressType("IFCARBITRARYPROFILEDEFWITHVOIDS", 116)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryProfileDefWithVoids(IModel model) : base(model) 		{ 
			Model = model; 
			_innerCurves = new ItemSet<IfcCurve>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCurve> _innerCurves;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCurve> @InnerCurves 
		{ 
			get 
			{
				if(Activated) return _innerCurves;
				
				Model.Activate(this, true);
				Activated = true;
				return _innerCurves;
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
				case 1: 
				case 2: 
					base.Parse(propIndex, value); 
					return;
				case 3: 
					if (_innerCurves == null) _innerCurves = new ItemSet<IfcCurve>( this );
					_innerCurves.InternalAdd((IfcCurve)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcProfileDef.ProfileType = AREA;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* InnerCurves | temp.Dim <> 2)) = 0;*/
		/*WR3:	WR3 : SIZEOF(QUERY(temp <* InnerCurves | 'IFC2X3.IFCLINE' IN TYPEOF(temp))) = 0;*/
		}
		#endregion
	}
}