// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTURECOORDINATEGENERATOR", 1099)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureCoordinateGenerator : IfcTextureCoordinate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinateGenerator(IModel model) : base(model) 		{ 
			Model = model; 
			_parameter = new OptionalItemSet<IfcReal>( this );
		}

		#region Explicit attribute fields
		private IfcLabel _mode;
		private OptionalItemSet<IfcReal> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Mode 
		{ 
			get 
			{
				if(Activated) return _mode;
				
				Model.Activate(this, true);
				Activated = true;
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcReal> @Parameter 
		{ 
			get 
			{
				if(Activated) return _parameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _parameter;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_mode = value.StringVal;
					return;
				case 2: 
					if (_parameter == null) _parameter = new OptionalItemSet<IfcReal>( this );
					_parameter.InternalAdd(value.RealVal);
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