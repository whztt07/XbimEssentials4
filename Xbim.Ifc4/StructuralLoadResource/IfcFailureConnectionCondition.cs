// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:38
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
	[EntityName("IFCFAILURECONNECTIONCONDITION", 258)]
	public  partial class @IfcFailureConnectionCondition : IfcStructuralConnectionCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFailureConnectionCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcForceMeasure? _tensionFailureX;
		private IfcForceMeasure? _tensionFailureY;
		private IfcForceMeasure? _tensionFailureZ;
		private IfcForceMeasure? _compressionFailureX;
		private IfcForceMeasure? _compressionFailureY;
		private IfcForceMeasure? _compressionFailureZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcForceMeasure? @TensionFailureX 
		{ 
			get 
			{
				if(Activated) return _tensionFailureX;
				
				Model.Activate(this, true);
				Activated = true;
				return _tensionFailureX;
			} 
			set
			{
				SetValue( v =>  _tensionFailureX = v, _tensionFailureX, value,  "TensionFailureX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcForceMeasure? @TensionFailureY 
		{ 
			get 
			{
				if(Activated) return _tensionFailureY;
				
				Model.Activate(this, true);
				Activated = true;
				return _tensionFailureY;
			} 
			set
			{
				SetValue( v =>  _tensionFailureY = v, _tensionFailureY, value,  "TensionFailureY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcForceMeasure? @TensionFailureZ 
		{ 
			get 
			{
				if(Activated) return _tensionFailureZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _tensionFailureZ;
			} 
			set
			{
				SetValue( v =>  _tensionFailureZ = v, _tensionFailureZ, value,  "TensionFailureZ");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcForceMeasure? @CompressionFailureX 
		{ 
			get 
			{
				if(Activated) return _compressionFailureX;
				
				Model.Activate(this, true);
				Activated = true;
				return _compressionFailureX;
			} 
			set
			{
				SetValue( v =>  _compressionFailureX = v, _compressionFailureX, value,  "CompressionFailureX");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcForceMeasure? @CompressionFailureY 
		{ 
			get 
			{
				if(Activated) return _compressionFailureY;
				
				Model.Activate(this, true);
				Activated = true;
				return _compressionFailureY;
			} 
			set
			{
				SetValue( v =>  _compressionFailureY = v, _compressionFailureY, value,  "CompressionFailureY");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcForceMeasure? @CompressionFailureZ 
		{ 
			get 
			{
				if(Activated) return _compressionFailureZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _compressionFailureZ;
			} 
			set
			{
				SetValue( v =>  _compressionFailureZ = v, _compressionFailureZ, value,  "CompressionFailureZ");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"TensionFailureX",
			"TensionFailureY",
			"TensionFailureZ",
			"CompressionFailureX",
			"CompressionFailureY",
			"CompressionFailureZ",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @TensionFailureX;
				case 2: 
					return @TensionFailureY;
				case 3: 
					return @TensionFailureZ;
				case 4: 
					return @CompressionFailureX;
				case 5: 
					return @CompressionFailureY;
				case 6: 
					return @CompressionFailureZ;
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
				case "TensionFailureX":  
					return @TensionFailureX;
				case "TensionFailureY":  
					return @TensionFailureY;
				case "TensionFailureZ":  
					return @TensionFailureZ;
				case "CompressionFailureX":  
					return @CompressionFailureX;
				case "CompressionFailureY":  
					return @CompressionFailureY;
				case "CompressionFailureZ":  
					return @CompressionFailureZ;
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
					 @TensionFailureX = (IfcForceMeasure?)value;
					 break;
				case 2:
					 @TensionFailureY = (IfcForceMeasure?)value;
					 break;
				case 3:
					 @TensionFailureZ = (IfcForceMeasure?)value;
					 break;
				case 4:
					 @CompressionFailureX = (IfcForceMeasure?)value;
					 break;
				case 5:
					 @CompressionFailureY = (IfcForceMeasure?)value;
					 break;
				case 6:
					 @CompressionFailureZ = (IfcForceMeasure?)value;
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
				case "TensionFailureX":
					 @TensionFailureX = (IfcForceMeasure?)value;
					 break;
				case "TensionFailureY":
					 @TensionFailureY = (IfcForceMeasure?)value;
					 break;
				case "TensionFailureZ":
					 @TensionFailureZ = (IfcForceMeasure?)value;
					 break;
				case "CompressionFailureX":
					 @CompressionFailureX = (IfcForceMeasure?)value;
					 break;
				case "CompressionFailureY":
					 @CompressionFailureY = (IfcForceMeasure?)value;
					 break;
				case "CompressionFailureZ":
					 @CompressionFailureZ = (IfcForceMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
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