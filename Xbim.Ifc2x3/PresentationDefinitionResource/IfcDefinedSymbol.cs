// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[IndexedClass]
	[ExpressType("IFCDEFINEDSYMBOL", 461)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDefinedSymbol : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDefinedSymbol(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDefinedSymbolSelect _definition;
		private IfcCartesianTransformationOperator2D _target;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDefinedSymbolSelect @Definition 
		{ 
			get 
			{
				if(Activated) return _definition;
				
				Model.Activate(this, true);
				Activated = true;
				return _definition;
			} 
			set
			{
				SetValue( v =>  _definition = v, _definition, value,  "Definition");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator2D @Target 
		{ 
			get 
			{
				if(Activated) return _target;
				
				Model.Activate(this, true);
				Activated = true;
				return _target;
			} 
			set
			{
				SetValue( v =>  _target = v, _target, value,  "Target");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_definition = (IfcDefinedSymbolSelect)(value.EntityVal);
					return;
				case 1: 
					_target = (IfcCartesianTransformationOperator2D)(value.EntityVal);
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