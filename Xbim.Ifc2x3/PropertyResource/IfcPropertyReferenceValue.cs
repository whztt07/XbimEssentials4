// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:00
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
	[EntityName("IFCPROPERTYREFERENCEVALUE", 277)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyReferenceValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyReferenceValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcObjectReferenceSelect _propertyReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLabel? @UsageName 
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
		public IfcObjectReferenceSelect @PropertyReference 
		{ 
			get 
			{
				if(Activated) return _propertyReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _propertyReference;
			} 
			set
			{
				SetValue( v =>  _propertyReference = v, _propertyReference, value,  "PropertyReference");
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
			"PropertyReference",
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
					return @PropertyReference;
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
				case "PropertyReference":  
					return @PropertyReference;
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
					 @UsageName = (IfcLabel?)value;
					 break;
				case 3:
					 @PropertyReference = (IfcObjectReferenceSelect)value;
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
					 @UsageName = (IfcLabel?)value;
					 break;
				case "PropertyReference":
					 @PropertyReference = (IfcObjectReferenceSelect)value;
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
					_propertyReference = (IfcObjectReferenceSelect)(value.EntityVal);
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