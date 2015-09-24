// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[IndexedClass]
	[ExpressType("IFCRELASSIGNSTOACTOR", 323)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToActor : IfcRelAssigns, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToActor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActor _relatingActor;
		private IfcActorRole _actingRole;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActor @RelatingActor 
		{ 
			get 
			{
				if(Activated) return _relatingActor;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingActor;
			} 
			set
			{
				SetValue( v =>  _relatingActor = v, _relatingActor, value,  "RelatingActor");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorRole @ActingRole 
		{ 
			get 
			{
				if(Activated) return _actingRole;
				
				Model.Activate(this, true);
				Activated = true;
				return _actingRole;
			} 
			set
			{
				SetValue( v =>  _actingRole = v, _actingRole, value,  "ActingRole");
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
				case 4: 
				case 5: 
					base.Parse(propIndex, value); 
					return;
				case 6: 
					_relatingActor = (IfcActor)(value.EntityVal);
					return;
				case 7: 
					_actingRole = (IfcActorRole)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingActor :=: Temp)) = 0;*/
		}
		#endregion
	}
}