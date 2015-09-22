// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[IndexedClass]
	[ExpressType("IFCFAILURECONNECTIONCONDITION", 649)]
	// ReSharper disable once PartialTypeWithSinglePart
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_tensionFailureX = value.RealVal;
					return;
				case 2: 
					_tensionFailureY = value.RealVal;
					return;
				case 3: 
					_tensionFailureZ = value.RealVal;
					return;
				case 4: 
					_compressionFailureX = value.RealVal;
					return;
				case 5: 
					_compressionFailureY = value.RealVal;
					return;
				case 6: 
					_compressionFailureZ = value.RealVal;
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