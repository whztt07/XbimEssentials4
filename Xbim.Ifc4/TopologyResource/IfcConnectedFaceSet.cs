// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTEDFACESET", 509)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectedFaceSet : IfcTopologicalRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_cfsFaces = new ItemSet<IfcFace>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcFace> _cfsFaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcFace> @CfsFaces 
		{ 
			get 
			{
				if(Activated) return _cfsFaces;
				
				Model.Activate(this, true);
				Activated = true;
				return _cfsFaces;
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
					if (_cfsFaces == null) _cfsFaces = new ItemSet<IfcFace>( this );
					_cfsFaces.InternalAdd((IfcFace)value.EntityVal);
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