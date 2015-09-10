// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:46
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("CONNECTION", 19)]
	public  partial class @CobieConnection : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _connectionType;
		private CobieComponent _componentA;
		private CobieComponent _componentB;
		private CobieComponent _realizingComponent;
		private string _portNameA;
		private string _portNameB;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public string @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public string @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public CobiePickValue @ConnectionType 
		{ 
			get 
			{
				if(Activated) return _connectionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public CobieComponent @ComponentA 
		{ 
			get 
			{
				if(Activated) return _componentA;
				
				Model.Activate(this, true);
				Activated = true;
				return _componentA;
			} 
			set
			{
				SetValue( v =>  _componentA = v, _componentA, value,  "ComponentA");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public CobieComponent @ComponentB 
		{ 
			get 
			{
				if(Activated) return _componentB;
				
				Model.Activate(this, true);
				Activated = true;
				return _componentB;
			} 
			set
			{
				SetValue( v =>  _componentB = v, _componentB, value,  "ComponentB");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public CobieComponent @RealizingComponent 
		{ 
			get 
			{
				if(Activated) return _realizingComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _realizingComponent;
			} 
			set
			{
				SetValue( v =>  _realizingComponent = v, _realizingComponent, value,  "RealizingComponent");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public string @PortNameA 
		{ 
			get 
			{
				if(Activated) return _portNameA;
				
				Model.Activate(this, true);
				Activated = true;
				return _portNameA;
			} 
			set
			{
				SetValue( v =>  _portNameA = v, _portNameA, value,  "PortNameA");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public string @PortNameB 
		{ 
			get 
			{
				if(Activated) return _portNameB;
				
				Model.Activate(this, true);
				Activated = true;
				return _portNameB;
			} 
			set
			{
				SetValue( v =>  _portNameB = v, _portNameB, value,  "PortNameB");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"ConnectionType",
			"ComponentA",
			"ComponentB",
			"RealizingComponent",
			"PortNameA",
			"PortNameB",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Created;
				case 1: 
					return @ExternalSystem;
				case 2: 
					return @ExternalObject;
				case 3: 
					return @ExternalId;
				case 4: 
					return @LocalId;
				case 5: 
					return @Name;
				case 6: 
					return @Description;
				case 7: 
					return @ConnectionType;
				case 8: 
					return @ComponentA;
				case 9: 
					return @ComponentB;
				case 10: 
					return @RealizingComponent;
				case 11: 
					return @PortNameA;
				case 12: 
					return @PortNameB;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Created":  
					return @Created;
				case "ExternalSystem":  
					return @ExternalSystem;
				case "ExternalObject":  
					return @ExternalObject;
				case "ExternalId":  
					return @ExternalId;
				case "LocalId":  
					return @LocalId;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ConnectionType":  
					return @ConnectionType;
				case "ComponentA":  
					return @ComponentA;
				case "ComponentB":  
					return @ComponentB;
				case "RealizingComponent":  
					return @RealizingComponent;
				case "PortNameA":  
					return @PortNameA;
				case "PortNameB":  
					return @PortNameB;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Created = (CobieCreatedInfo)value;
					 break;
				case 1:
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case 2:
					 @ExternalObject = (string)value;
					 break;
				case 3:
					 @ExternalId = (string)value;
					 break;
				case 4:
					 if (value != null) @LocalId = (long)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @ConnectionType = (CobiePickValue)value;
					 break;
				case 8:
					 @ComponentA = (CobieComponent)value;
					 break;
				case 9:
					 @ComponentB = (CobieComponent)value;
					 break;
				case 10:
					 @RealizingComponent = (CobieComponent)value;
					 break;
				case 11:
					 @PortNameA = (string)value;
					 break;
				case 12:
					 @PortNameB = (string)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Created":
					 @Created = (CobieCreatedInfo)value;
					 break;
				case "ExternalSystem":
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case "ExternalObject":
					 @ExternalObject = (string)value;
					 break;
				case "ExternalId":
					 @ExternalId = (string)value;
					 break;
				case "LocalId":
					 if (value != null) @LocalId = (long)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "ConnectionType":
					 @ConnectionType = (CobiePickValue)value;
					 break;
				case "ComponentA":
					 @ComponentA = (CobieComponent)value;
					 break;
				case "ComponentB":
					 @ComponentB = (CobieComponent)value;
					 break;
				case "RealizingComponent":
					 @RealizingComponent = (CobieComponent)value;
					 break;
				case "PortNameA":
					 @PortNameA = (string)value;
					 break;
				case "PortNameB":
					 @PortNameB = (string)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}