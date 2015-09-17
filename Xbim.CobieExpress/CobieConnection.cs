// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[EntityName("CONNECTION", 19)]
	// ReSharper disable once PartialTypeWithSinglePart
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

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_connectionType = (CobiePickValue)(value.EntityVal);
					return;
				case 8: 
					_componentA = (CobieComponent)(value.EntityVal);
					return;
				case 9: 
					_componentB = (CobieComponent)(value.EntityVal);
					return;
				case 10: 
					_realizingComponent = (CobieComponent)(value.EntityVal);
					return;
				case 11: 
					_portNameA = value.StringVal;
					return;
				case 12: 
					_portNameB = value.StringVal;
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