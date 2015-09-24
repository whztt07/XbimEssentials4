// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTUREVERTEX", 1101)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertex : IfcPresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertex(IModel model) : base(model) 		{ 
			Model = model; 
			_coordinates = new ItemSet<IfcParameterValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcParameterValue> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 2)]
		public ItemSet<IfcParameterValue> @Coordinates 
		{ 
			get 
			{
				if(Activated) return _coordinates;
				
				Model.Activate(this, true);
				Activated = true;
				return _coordinates;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_coordinates == null) _coordinates = new ItemSet<IfcParameterValue>( this );
					_coordinates.InternalAdd(value.RealVal);
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