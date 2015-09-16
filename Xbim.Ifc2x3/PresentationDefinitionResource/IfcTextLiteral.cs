// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.PresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[EntityName("IFCTEXTLITERAL", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteral : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteral(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPresentableText _literal;
		private IfcAxis2Placement _placement;
		private IfcTextPath _path;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcPresentableText @Literal 
		{ 
			get 
			{
				if(Activated) return _literal;
				
				Model.Activate(this, true);
				Activated = true;
				return _literal;
			} 
			set
			{
				SetValue( v =>  _literal = v, _literal, value,  "Literal");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement @Placement 
		{ 
			get 
			{
				if(Activated) return _placement;
				
				Model.Activate(this, true);
				Activated = true;
				return _placement;
			} 
			set
			{
				SetValue( v =>  _placement = v, _placement, value,  "Placement");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcTextPath @Path 
		{ 
			get 
			{
				if(Activated) return _path;
				
				Model.Activate(this, true);
				Activated = true;
				return _path;
			} 
			set
			{
				SetValue( v =>  _path = v, _path, value,  "Path");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Literal",
			"Placement",
			"Path",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Literal;
				case 1: 
					return @Placement;
				case 2: 
					return @Path;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Literal":  
					return @Literal;
				case "Placement":  
					return @Placement;
				case "Path":  
					return @Path;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Literal = (IfcPresentableText)value;
					 break;
				case 1:
					 @Placement = (IfcAxis2Placement)value;
					 break;
				case 2:
					 if (value != null) @Path = (IfcTextPath)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Literal":
					 if (value != null) @Literal = (IfcPresentableText)value;
					 break;
				case "Placement":
					 @Placement = (IfcAxis2Placement)value;
					 break;
				case "Path":
					 if (value != null) @Path = (IfcTextPath)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_literal = value.StringVal;
					return;
				case 1: 
					_placement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 2: 
                    _path = (IfcTextPath) System.Enum.Parse(typeof (IfcTextPath), value.EnumVal, true);
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