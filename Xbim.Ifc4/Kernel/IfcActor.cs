// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:05
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
	[EntityName("IFCACTOR", 1)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActor : IfcObject, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActorSelect _theActor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcActorSelect @TheActor 
		{ 
			get 
			{
				if(Activated) return _theActor;
				
				Model.Activate(this, true);
				Activated = true;
				return _theActor;
			} 
			set
			{
				SetValue( v =>  _theActor = v, _theActor, value,  "TheActor");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelAssignsToActor> @IsActingUpon 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToActor>(e => e.RelatingActor == this);
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_theActor = (IfcActorSelect)(value.EntityVal);
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