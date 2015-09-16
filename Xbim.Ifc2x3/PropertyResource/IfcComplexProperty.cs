// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PropertyResource
{
	[EntityName("IFCCOMPLEXPROPERTY", 379)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexProperty : IfcProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexProperty(IModel model) : base(model) 		{ 
			Model = model; 
			_hasProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier _usageName;
		private ItemSet<IfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcIdentifier @UsageName 
		{ 
			get 
			{
				if(Activated) return _usageName;
				
				Model.Activate(this, true);
				Activated = true;
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public ItemSet<IfcProperty> @HasProperties 
		{ 
			get 
			{
				if(Activated) return _hasProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasProperties;
			} 
			set
			{
				SetValue( v =>  _hasProperties = v, _hasProperties, value,  "HasProperties");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Name",
			"Description",
			"UsageName",
			"HasProperties",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @UsageName;
				case 3: 
					return @HasProperties;
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
				case "Description":  
					return @Description;
				case "UsageName":  
					return @UsageName;
				case "HasProperties":  
					return @HasProperties;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Name = (IfcIdentifier)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 if (value != null) @UsageName = (IfcIdentifier)value;
					 break;
				case 3:
					 @HasProperties.Add((IfcProperty)value);
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
					 if (value != null) @Name = (IfcIdentifier)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "UsageName":
					 if (value != null) @UsageName = (IfcIdentifier)value;
					 break;
				case "HasProperties":
					 @HasProperties.Add((IfcProperty)value);
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
				case 1: 
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_usageName = value.StringVal;
					return;
				case 3: 
					if (_hasProperties == null) _hasProperties = new ItemSet<IfcProperty>( this );
					_hasProperties.Add((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : SIZEOF(QUERY(temp <* HasProperties | SELF :=: temp)) = 0;*/
		/*WR22:	WR22 : IfcUniquePropertyName(HasProperties);*/
		}
		#endregion

		
	}
}