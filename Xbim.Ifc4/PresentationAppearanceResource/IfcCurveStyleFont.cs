// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
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
	[ExpressType("IFCCURVESTYLEFONT", 554)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFont : IfcPresentationItem, IfcCurveStyleFontSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFont(IModel model) : base(model) 		{ 
			Model = model; 
			_patternList = new ItemSet<IfcCurveStyleFontPattern>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private ItemSet<IfcCurveStyleFontPattern> _patternList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCurveStyleFontPattern> @PatternList 
		{ 
			get 
			{
				if(Activated) return _patternList;
				
				Model.Activate(this, true);
				Activated = true;
				return _patternList;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					if (_patternList == null) _patternList = new ItemSet<IfcCurveStyleFontPattern>( this );
					_patternList.InternalAdd((IfcCurveStyleFontPattern)value.EntityVal);
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