// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.QuantityResource
{
	[EntityName("IFCPHYSICALCOMPLEXQUANTITY", 408)]
	public  partial class @IfcPhysicalComplexQuantity : IfcPhysicalQuantity, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalComplexQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_hasQuantities = new ItemSet<IfcPhysicalQuantity>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPhysicalQuantity> _hasQuantities;
		private IfcLabel _discrimination;
		private IfcLabel? _quality;
		private IfcLabel? _usage;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPhysicalQuantity> @HasQuantities 
		{ 
			get 
			{
				if(Activated) return _hasQuantities;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasQuantities;
			} 
			set
			{
				SetValue( v =>  _hasQuantities = v, _hasQuantities, value,  "HasQuantities");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcLabel @Discrimination 
		{ 
			get 
			{
				if(Activated) return _discrimination;
				
				Model.Activate(this, true);
				Activated = true;
				return _discrimination;
			} 
			set
			{
				SetValue( v =>  _discrimination = v, _discrimination, value,  "Discrimination");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @Quality 
		{ 
			get 
			{
				if(Activated) return _quality;
				
				Model.Activate(this, true);
				Activated = true;
				return _quality;
			} 
			set
			{
				SetValue( v =>  _quality = v, _quality, value,  "Quality");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcLabel? @Usage 
		{ 
			get 
			{
				if(Activated) return _usage;
				
				Model.Activate(this, true);
				Activated = true;
				return _usage;
			} 
			set
			{
				SetValue( v =>  _usage = v, _usage, value,  "Usage");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"HasQuantities",
			"Discrimination",
			"Quality",
			"Usage",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @HasQuantities;
				case 3: 
					return @Discrimination;
				case 4: 
					return @Quality;
				case 5: 
					return @Usage;
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
				case "HasQuantities":  
					return @HasQuantities;
				case "Discrimination":  
					return @Discrimination;
				case "Quality":  
					return @Quality;
				case "Usage":  
					return @Usage;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @HasQuantities.Add((IfcPhysicalQuantity)value);
					 break;
				case 3:
					 if (value != null) @Discrimination = (IfcLabel)value;
					 break;
				case 4:
					 @Quality = (IfcLabel?)value;
					 break;
				case 5:
					 @Usage = (IfcLabel?)value;
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
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "HasQuantities":
					 @HasQuantities.Add((IfcPhysicalQuantity)value);
					 break;
				case "Discrimination":
					 if (value != null) @Discrimination = (IfcLabel)value;
					 break;
				case "Quality":
					 @Quality = (IfcLabel?)value;
					 break;
				case "Usage":
					 @Usage = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(temp <* HasQuantities | SELF :=: temp)) = 0;*/
		/*UniqueQuantityNames:	UniqueQuantityNames : IfcUniqueQuantityNames(HasQuantities);*/
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