// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProductExtension;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ArchitectureDomain
{
	[EntityName("IFCSPACEPROGRAM", 523)]
	public  partial class @IfcSpaceProgram : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpaceProgram(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _spaceProgramIdentifier;
		private IfcAreaMeasure? _maxRequiredArea;
		private IfcAreaMeasure? _minRequiredArea;
		private IfcSpatialStructureElement _requestedLocation;
		private IfcAreaMeasure _standardRequiredArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcIdentifier @SpaceProgramIdentifier 
		{ 
			get 
			{
				if(Activated) return _spaceProgramIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _spaceProgramIdentifier;
			} 
			set
			{
				SetValue( v =>  _spaceProgramIdentifier = v, _spaceProgramIdentifier, value,  "SpaceProgramIdentifier");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcAreaMeasure? @MaxRequiredArea 
		{ 
			get 
			{
				if(Activated) return _maxRequiredArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _maxRequiredArea;
			} 
			set
			{
				SetValue( v =>  _maxRequiredArea = v, _maxRequiredArea, value,  "MaxRequiredArea");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcAreaMeasure? @MinRequiredArea 
		{ 
			get 
			{
				if(Activated) return _minRequiredArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _minRequiredArea;
			} 
			set
			{
				SetValue( v =>  _minRequiredArea = v, _minRequiredArea, value,  "MinRequiredArea");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcSpatialStructureElement @RequestedLocation 
		{ 
			get 
			{
				if(Activated) return _requestedLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _requestedLocation;
			} 
			set
			{
				SetValue( v =>  _requestedLocation = v, _requestedLocation, value,  "RequestedLocation");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcAreaMeasure @StandardRequiredArea 
		{ 
			get 
			{
				if(Activated) return _standardRequiredArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _standardRequiredArea;
			} 
			set
			{
				SetValue( v =>  _standardRequiredArea = v, _standardRequiredArea, value,  "StandardRequiredArea");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelInteractionRequirements> @HasInteractionReqsFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelInteractionRequirements>(e => e.RelatedSpaceProgram == this);
			} 
		}
	
		public IEnumerable<IfcRelInteractionRequirements> @HasInteractionReqsTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelInteractionRequirements>(e => e.RelatingSpaceProgram == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"SpaceProgramIdentifier",
			"MaxRequiredArea",
			"MinRequiredArea",
			"RequestedLocation",
			"StandardRequiredArea",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

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
					return @SpaceProgramIdentifier;
				case 6: 
					return @MaxRequiredArea;
				case 7: 
					return @MinRequiredArea;
				case 8: 
					return @RequestedLocation;
				case 9: 
					return @StandardRequiredArea;
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
				case "SpaceProgramIdentifier":  
					return @SpaceProgramIdentifier;
				case "MaxRequiredArea":  
					return @MaxRequiredArea;
				case "MinRequiredArea":  
					return @MinRequiredArea;
				case "RequestedLocation":  
					return @RequestedLocation;
				case "StandardRequiredArea":  
					return @StandardRequiredArea;
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
					 if (value != null) @SpaceProgramIdentifier = (IfcIdentifier)value;
					 break;
				case 6:
					 @MaxRequiredArea = (IfcAreaMeasure?)value;
					 break;
				case 7:
					 @MinRequiredArea = (IfcAreaMeasure?)value;
					 break;
				case 8:
					 @RequestedLocation = (IfcSpatialStructureElement)value;
					 break;
				case 9:
					 if (value != null) @StandardRequiredArea = (IfcAreaMeasure)value;
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
				case "SpaceProgramIdentifier":
					 if (value != null) @SpaceProgramIdentifier = (IfcIdentifier)value;
					 break;
				case "MaxRequiredArea":
					 @MaxRequiredArea = (IfcAreaMeasure?)value;
					 break;
				case "MinRequiredArea":
					 @MinRequiredArea = (IfcAreaMeasure?)value;
					 break;
				case "RequestedLocation":
					 @RequestedLocation = (IfcSpatialStructureElement)value;
					 break;
				case "StandardRequiredArea":
					 if (value != null) @StandardRequiredArea = (IfcAreaMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}