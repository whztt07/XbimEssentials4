// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
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
	[EntityName("IFCTYPEOBJECT", 726)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeObject : IfcObjectDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeObject(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertySets = new ItemSet<IfcPropertySetDefinition>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _applicableOccurrence;
		private ItemSet<IfcPropertySetDefinition> _hasPropertySets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcIdentifier? @ApplicableOccurrence 
		{ 
			get 
			{
				if(Activated) return _applicableOccurrence;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableOccurrence;
			} 
			set
			{
				SetValue( v =>  _applicableOccurrence = v, _applicableOccurrence, value,  "ApplicableOccurrence");
			} 
		}
	
		[EntityAttributee(5, EntityAttributeState.Optional)]
		public ItemSet<IfcPropertySetDefinition> @HasPropertySets 
		{ 
			get 
			{
				if(Activated) return _hasPropertySets;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertySets;
			} 
			set
			{
				SetValue( v =>  _hasPropertySets = v, _hasPropertySets, value,  "HasPropertySets");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelDefinesByType> @Types 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatingType == this);
			} 
		}
	

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
					_applicableOccurrence = value.StringVal;
					return;
				case 5: 
					if (_hasPropertySets == null) _hasPropertySets = new ItemSet<IfcPropertySetDefinition>( this );
					_hasPropertySets.InternalAdd((IfcPropertySetDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion
	}
}