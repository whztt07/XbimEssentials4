// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[IndexedClass]
	[ExpressType("IFCFACE", 83)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFace : IfcTopologicalRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFace(IModel model) : base(model) 		{ 
			Model = model; 
			_bounds = new ItemSet<IfcFaceBound>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcFaceBound> _bounds;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcFaceBound> @Bounds 
		{ 
			get 
			{
				if(Activated) return _bounds;
				
				Model.Activate(this, true);
				Activated = true;
				return _bounds;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_bounds == null) _bounds = new ItemSet<IfcFaceBound>( this );
					_bounds.InternalAdd((IfcFaceBound)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* Bounds | 'IFC2X3.IFCFACEOUTERBOUND' IN TYPEOF(temp))) <= 1;*/
		}
		#endregion
	}
}