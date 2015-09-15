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

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCOBJECT", 383)]
	public abstract partial class @IfcObject : IfcObjectDefinition
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObject(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(Activated) return _objectType;
				
				Model.Activate(this, true);
				Activated = true;
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelDefinesByObject> @IsDeclaredBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
	
		public IEnumerable<IfcRelDefinesByObject> @Declares 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => e.RelatingObject == this);
			} 
		}
	
		public IEnumerable<IfcRelDefinesByType> @IsTypedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
	
		public IEnumerable<IfcRelDefinesByProperties> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
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