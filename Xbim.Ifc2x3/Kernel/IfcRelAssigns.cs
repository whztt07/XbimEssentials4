// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[EntityName("IFCRELASSIGNS", 10)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelAssigns : IfcRelationship
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssigns(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcObjectTypeEnum? _relatedObjectsType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcObjectDefinition> @RelatedObjects 
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
	
		[EntityAttributee(5, EntityAttributeState.Optional)]
		public IfcObjectTypeEnum? @RelatedObjectsType 
		{ 
			get 
			{
				if(Activated) return _relatedObjectsType;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedObjectsType;
			} 
			set
			{
				SetValue( v =>  _relatedObjectsType = v, _relatedObjectsType, value,  "RelatedObjectsType");
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
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObjectDefinition>( this );
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				case 5: 
                    _relatedObjectsType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : IfcCorrectObjectAssignment(RelatedObjectsType, RelatedObjects);*/
		}
		#endregion
	}
}