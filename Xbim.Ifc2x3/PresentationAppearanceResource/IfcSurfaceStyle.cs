// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCSURFACESTYLE", 260)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyle(IModel model) : base(model) 		{ 
			Model = model; 
			_styles = new ItemSet<IfcSurfaceStyleElementSelect>( model );
		}

		#region Explicit attribute fields
		private IfcSurfaceSide _side;
		private ItemSet<IfcSurfaceStyleElementSelect> _styles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcSurfaceSide @Side 
		{ 
			get 
			{
				if(Activated) return _side;
				
				Model.Activate(this, true);
				Activated = true;
				return _side;
			} 
			set
			{
				SetValue( v =>  _side = v, _side, value,  "Side");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcSurfaceStyleElementSelect> @Styles 
		{ 
			get 
			{
				if(Activated) return _styles;
				
				Model.Activate(this, true);
				Activated = true;
				return _styles;
			} 
			set
			{
				SetValue( v =>  _styles = v, _styles, value,  "Styles");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Name",
			"Side",
			"Styles",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Side;
				case 2: 
					return @Styles;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Side":  
					return @Side;
				case "Styles":  
					return @Styles;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 if (value != null) @Side = (IfcSurfaceSide)value;
					 break;
				case 2:
					 @Styles.Add((IfcSurfaceStyleElementSelect)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Side":
					 if (value != null) @Side = (IfcSurfaceSide)value;
					 break;
				case "Styles":
					 @Styles.Add((IfcSurfaceStyleElementSelect)value);
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
                    _side = (IfcSurfaceSide) System.Enum.Parse(typeof (IfcSurfaceSide), value.EnumVal, true);
					return;
				case 2: 
					if (_styles == null) _styles = new ItemSet<IfcSurfaceStyleElementSelect>( Model );
					_styles.Add((IfcSurfaceStyleElementSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:               )) <= 1;*/
		/*WR12:               )) <= 1;*/
		/*WR13:               )) <= 1;*/
		/*WR14:               )) <= 1;*/
		/*WR15:               )) <= 1;*/
		}
		#endregion

		
	}
}