// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.Kernel
{
	[EntityName("IFCTYPEOBJECT", 625)]
	public  partial class @IfcTypeObject : IfcObjectDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeObject(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertySets = new ItemSet<IfcPropertySetDefinition>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _applicableOccurrence;
		private ItemSet<IfcPropertySetDefinition> _hasPropertySets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @ApplicableOccurrence 
		{ 
			get 
			{
				if(Activated) return _applicableOccurrence;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableOccurrence;
			} 
			set
			{
				SetValue( v =>  _applicableOccurrence = v, _applicableOccurrence, value,  "ApplicableOccurrence");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public ItemSet<IfcPropertySetDefinition> @HasPropertySets 
		{ 
			get 
			{
				if(Activated) return _hasPropertySets;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertySets;
			} 
			set
			{
				SetValue( v =>  _hasPropertySets = v, _hasPropertySets, value,  "HasPropertySets");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelDefinesByType> @ObjectTypeOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatingType == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ApplicableOccurrence",
			"HasPropertySets",
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
					return @ApplicableOccurrence;
				case 5: 
					return @HasPropertySets;
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
				case "ApplicableOccurrence":  
					return @ApplicableOccurrence;
				case "HasPropertySets":  
					return @HasPropertySets;
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
					 @ApplicableOccurrence = (IfcLabel?)value;
					 break;
				case 5:
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
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
				case "ApplicableOccurrence":
					 @ApplicableOccurrence = (IfcLabel?)value;
					 break;
				case "HasPropertySets":
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}