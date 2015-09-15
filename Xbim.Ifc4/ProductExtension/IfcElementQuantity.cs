// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.QuantityResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCELEMENTQUANTITY", 224)]
	public  partial class @IfcElementQuantity : IfcQuantitySet, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_quantities = new ItemSet<IfcPhysicalQuantity>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _methodOfMeasurement;
		private ItemSet<IfcPhysicalQuantity> _quantities;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @MethodOfMeasurement 
		{ 
			get 
			{
				if(Activated) return _methodOfMeasurement;
				
				Model.Activate(this, true);
				Activated = true;
				return _methodOfMeasurement;
			} 
			set
			{
				SetValue( v =>  _methodOfMeasurement = v, _methodOfMeasurement, value,  "MethodOfMeasurement");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPhysicalQuantity> @Quantities 
		{ 
			get 
			{
				if(Activated) return _quantities;
				
				Model.Activate(this, true);
				Activated = true;
				return _quantities;
			} 
			set
			{
				SetValue( v =>  _quantities = v, _quantities, value,  "Quantities");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"MethodOfMeasurement",
			"Quantities",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @MethodOfMeasurement;
				case 5: 
					return @Quantities;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "MethodOfMeasurement":  
					return @MethodOfMeasurement;
				case "Quantities":  
					return @Quantities;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @MethodOfMeasurement = (IfcLabel?)value;
					 break;
				case 5:
					 @Quantities.Add((IfcPhysicalQuantity)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "MethodOfMeasurement":
					 @MethodOfMeasurement = (IfcLabel?)value;
					 break;
				case "Quantities":
					 @Quantities.Add((IfcPhysicalQuantity)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*UniqueQuantityNames:	UniqueQuantityNames : IfcUniqueQuantityNames(Quantities);*/
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