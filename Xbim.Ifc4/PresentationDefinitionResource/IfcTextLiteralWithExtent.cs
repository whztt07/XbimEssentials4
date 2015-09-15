// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[EntityName("IFCTEXTLITERALWITHEXTENT", 702)]
	public  partial class @IfcTextLiteralWithExtent : IfcTextLiteral, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteralWithExtent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarExtent _extent;
		private IfcBoxAlignment _boxAlignment;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPlanarExtent @Extent 
		{ 
			get 
			{
				if(Activated) return _extent;
				
				Model.Activate(this, true);
				Activated = true;
				return _extent;
			} 
			set
			{
				SetValue( v =>  _extent = v, _extent, value,  "Extent");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcBoxAlignment @BoxAlignment 
		{ 
			get 
			{
				if(Activated) return _boxAlignment;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxAlignment;
			} 
			set
			{
				SetValue( v =>  _boxAlignment = v, _boxAlignment, value,  "BoxAlignment");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Literal",
			"Placement",
			"Path",
			"Extent",
			"BoxAlignment",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

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
				case 3: 
					return @Extent;
				case 4: 
					return @BoxAlignment;
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
				case "Extent":  
					return @Extent;
				case "BoxAlignment":  
					return @BoxAlignment;
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
				case 3:
					 @Extent = (IfcPlanarExtent)value;
					 break;
				case 4:
					 if (value != null) @BoxAlignment = (IfcBoxAlignment)value;
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
				case "Extent":
					 @Extent = (IfcPlanarExtent)value;
					 break;
				case "BoxAlignment":
					 if (value != null) @BoxAlignment = (IfcBoxAlignment)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR31:	WR31 : NOT('IFC4.IFCPLANARBOX' IN TYPEOF(Extent));*/
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