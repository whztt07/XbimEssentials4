// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.Kernel
{
	[EntityName("IFCRELDEFINES", 207)]
	public abstract partial class @IfcRelDefines : IfcRelationship
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefines(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObject>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObject> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
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
	
		#endregion

		#region Inverse attributes

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