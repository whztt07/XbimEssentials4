// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:13
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[IndexedClass]
	[ExpressType("IFCPROJECT", 204)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProject : IfcObject, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProject(IModel model) : base(model) 		{ 
			Model = model; 
			_representationContexts = new ItemSet<IfcRepresentationContext>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcLabel? _phase;
		private ItemSet<IfcRepresentationContext> _representationContexts;
		private IfcUnitAssignment _unitsInContext;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(Activated) return _longName;
				
				Model.Activate(this, true);
				Activated = true;
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Phase 
		{ 
			get 
			{
				if(Activated) return _phase;
				
				Model.Activate(this, true);
				Activated = true;
				return _phase;
			} 
			set
			{
				SetValue( v =>  _phase = v, _phase, value,  "Phase");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcRepresentationContext> @RepresentationContexts 
		{ 
			get 
			{
				if(Activated) return _representationContexts;
				
				Model.Activate(this, true);
				Activated = true;
				return _representationContexts;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnitAssignment @UnitsInContext 
		{ 
			get 
			{
				if(Activated) return _unitsInContext;
				
				Model.Activate(this, true);
				Activated = true;
				return _unitsInContext;
			} 
			set
			{
				SetValue( v =>  _unitsInContext = v, _unitsInContext, value,  "UnitsInContext");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_longName = value.StringVal;
					return;
				case 6: 
					_phase = value.StringVal;
					return;
				case 7: 
					if (_representationContexts == null) _representationContexts = new ItemSet<IfcRepresentationContext>( this );
					_representationContexts.InternalAdd((IfcRepresentationContext)value.EntityVal);
					return;
				case 8: 
					_unitsInContext = (IfcUnitAssignment)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : EXISTS(SELF\IfcRoot.Name);*/
		/*WR32:             )) = 0;*/
		/*WR33:	WR33 : SIZEOF(SELF\IfcObjectDefinition.Decomposes) = 0;*/
		}
		#endregion
	}
}