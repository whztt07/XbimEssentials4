// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[EntityName("IFCSLIPPAGECONNECTIONCONDITION")]
	public  partial class @IfcSlippageConnectionCondition : IfcStructuralConnectionCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSlippageConnectionCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _slippageX;
		private IfcLengthMeasure? _slippageY;
		private IfcLengthMeasure? _slippageZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @SlippageX 
		{ 
			get 
			{
				if(IsActivated) return _slippageX;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _slippageX;
			} 
			set
			{
				SetValue( v =>  _slippageX = v, _slippageX, value,  "SlippageX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @SlippageY 
		{ 
			get 
			{
				if(IsActivated) return _slippageY;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _slippageY;
			} 
			set
			{
				SetValue( v =>  _slippageY = v, _slippageY, value,  "SlippageY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @SlippageZ 
		{ 
			get 
			{
				if(IsActivated) return _slippageZ;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _slippageZ;
			} 
			set
			{
				SetValue( v =>  _slippageZ = v, _slippageZ, value,  "SlippageZ");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"SlippageX",
			"SlippageY",
			"SlippageZ",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @SlippageX;
				case 2: 
					return @SlippageY;
				case 3: 
					return @SlippageZ;
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
				case "SlippageX":  
					return @SlippageX;
				case "SlippageY":  
					return @SlippageY;
				case "SlippageZ":  
					return @SlippageZ;
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
					 @SlippageX = (IfcLengthMeasure?)value;
					 break;
				case 2:
					 @SlippageY = (IfcLengthMeasure?)value;
					 break;
				case 3:
					 @SlippageZ = (IfcLengthMeasure?)value;
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
				case "SlippageX":
					 @SlippageX = (IfcLengthMeasure?)value;
					 break;
				case "SlippageY":
					 @SlippageY = (IfcLengthMeasure?)value;
					 break;
				case "SlippageZ":
					 @SlippageZ = (IfcLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}