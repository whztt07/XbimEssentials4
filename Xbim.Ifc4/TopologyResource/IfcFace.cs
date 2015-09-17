// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[EntityName("IFCFACE", 251)]
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcFaceBound> @Bounds 
		{ 
			get 
			{
				if(Activated) return _bounds;
				
				Model.Activate(this, true);
				Activated = true;
				return _bounds;
			} 
			set
			{
				SetValue( v =>  _bounds = v, _bounds, value,  "Bounds");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcTextureMap> @HasTextureMaps 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureMap>(e => e.MappedTo == this);
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
		/*HasOuterBound:	HasOuterBound : SIZEOF(QUERY(temp <* Bounds | 'IFC4.IFCFACEOUTERBOUND' IN TYPEOF(temp))) <= 1;*/
		}
		#endregion
	}
}