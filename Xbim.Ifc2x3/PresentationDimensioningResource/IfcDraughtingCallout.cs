// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[IndexedClass]
	[ExpressType("IFCDRAUGHTINGCALLOUT", 222)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDraughtingCallout : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingCallout(IModel model) : base(model) 		{ 
			Model = model; 
			_contents = new ItemSet<IfcDraughtingCalloutElement>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDraughtingCalloutElement> _contents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDraughtingCalloutElement> @Contents 
		{ 
			get 
			{
				if(Activated) return _contents;
				
				Model.Activate(this, true);
				Activated = true;
				return _contents;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedFromCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatedDraughtingCallout == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedToCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatingDraughtingCallout == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_contents == null) _contents = new ItemSet<IfcDraughtingCalloutElement>( this );
					_contents.InternalAdd((IfcDraughtingCalloutElement)value.EntityVal);
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