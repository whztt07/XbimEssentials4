// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCRELASSOCIATES", 519)]
	public abstract partial class @IfcRelAssociates : IfcRelationship
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociates(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcDefinitionSelect>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDefinitionSelect> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDefinitionSelect> @RelatedObjects 
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
		#endregion

		public virtual override string WhereRule() 
		{
			return "";
		}
	}
}