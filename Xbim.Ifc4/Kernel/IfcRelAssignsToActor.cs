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
using Xbim.Ifc4.ActorResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCRELASSIGNSTOACTOR", 512)]
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
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingActor :=: Temp)) = 0;*/
		}
		#endregion
	}
}