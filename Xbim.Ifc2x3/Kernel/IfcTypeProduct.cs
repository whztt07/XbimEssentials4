// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[IndexedClass]
	[ExpressType("IFCTYPEPRODUCT", 43)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeProduct : IfcTypeObject, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeProduct(IModel model) : base(model) 		{ 
			Model = model; 
			_representationMaps = new OptionalItemSet<IfcRepresentationMap>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcRepresentationMap> _representationMaps;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcRepresentationMap> @RepresentationMaps 
		{ 
			get 
			{
				if(Activated) return _representationMaps;
				
				Model.Activate(this, true);
				Activated = true;
				return _representationMaps;
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(Activated) return _tag;
				
				Model.Activate(this, true);
				Activated = true;
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
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
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value); 
					return;
				case 6: 
					if (_representationMaps == null) _representationMaps = new OptionalItemSet<IfcRepresentationMap>( this );
					_representationMaps.InternalAdd((IfcRepresentationMap)value.EntityVal);
					return;
				case 7: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:             ) = 0);*/
		}
		#endregion
	}
}