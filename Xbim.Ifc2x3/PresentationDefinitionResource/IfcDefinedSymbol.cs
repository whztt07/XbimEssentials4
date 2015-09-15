// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[EntityName("IFCDEFINEDSYMBOL", 461)]
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Definition",
			"Target",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Definition;
				case 1: 
					return @Target;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Definition":  
					return @Definition;
				case "Target":  
					return @Target;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Definition = (IfcDefinedSymbolSelect)value;
					 break;
				case 1:
					 @Target = (IfcCartesianTransformationOperator2D)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Definition":
					 @Definition = (IfcDefinedSymbolSelect)value;
					 break;
				case "Target":
					 @Target = (IfcCartesianTransformationOperator2D)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}