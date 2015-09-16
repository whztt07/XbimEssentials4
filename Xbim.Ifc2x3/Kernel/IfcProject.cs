// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:20
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
	[EntityName("IFCPROJECT", 204)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProject : IfcObject, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProject(IModel model) : base(model) 		{ 
			Model = model; 
			_representationContexts = new ItemSet<IfcRepresentationContext>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcLabel? _phase;
		private ItemSet<IfcRepresentationContext> _representationContexts;
		private IfcUnitAssignment _unitsInContext;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<IfcRepresentationContext> @RepresentationContexts 
		{ 
			get 
			{
				if(Activated) return _representationContexts;
				
				Model.Activate(this, true);
				Activated = true;
				return _representationContexts;
			} 
			set
			{
				SetValue( v =>  _representationContexts = v, _representationContexts, value,  "RepresentationContexts");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
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

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"LongName",
			"Phase",
			"RepresentationContexts",
			"UnitsInContext",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @ObjectType;
				case 5: 
					return @LongName;
				case 6: 
					return @Phase;
				case 7: 
					return @RepresentationContexts;
				case 8: 
					return @UnitsInContext;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ObjectType":  
					return @ObjectType;
				case "LongName":  
					return @LongName;
				case "Phase":  
					return @Phase;
				case "RepresentationContexts":  
					return @RepresentationContexts;
				case "UnitsInContext":  
					return @UnitsInContext;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 @LongName = (IfcLabel?)value;
					 break;
				case 6:
					 @Phase = (IfcLabel?)value;
					 break;
				case 7:
					 @RepresentationContexts.Add((IfcRepresentationContext)value);
					 break;
				case 8:
					 @UnitsInContext = (IfcUnitAssignment)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "LongName":
					 @LongName = (IfcLabel?)value;
					 break;
				case "Phase":
					 @Phase = (IfcLabel?)value;
					 break;
				case "RepresentationContexts":
					 @RepresentationContexts.Add((IfcRepresentationContext)value);
					 break;
				case "UnitsInContext":
					 @UnitsInContext = (IfcUnitAssignment)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
					_longName = value.StringVal;
					return;
				case 6: 
					_phase = value.StringVal;
					return;
				case 7: 
					if (_representationContexts == null) _representationContexts = new ItemSet<IfcRepresentationContext>( Model );
					_representationContexts.Add((IfcRepresentationContext)value.EntityVal);
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