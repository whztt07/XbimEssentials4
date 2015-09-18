// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCRELDEFINESBYOBJECT", 541)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByObject : IfcRelDefines, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByObject(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObject>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObject> _relatedObjects;
		private IfcObject _relatingObject;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcObject> @RelatedObjects 
		{ 
			get 
			{
				if(Activated) return _relatedObjects;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedObjects;
			} 
			set
			{
				SetValue( v =>  _relatedObjects = v, _relatedObjects, value,  "RelatedObjects");
			} 
		}
	
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcObject @RelatingObject 
		{ 
			get 
			{
				if(Activated) return _relatingObject;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingObject;
			} 
			set
			{
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObject>( this );
					_relatedObjects.InternalAdd((IfcObject)value.EntityVal);
					return;
				case 5: 
					_relatingObject = (IfcObject)(value.EntityVal);
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