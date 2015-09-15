// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("SPACE", 13)]
	public  partial class @CobieSpace : CobieAsset, SpatialDivision, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _roomTag;
		private double? _usableHeight;
		private double? _grossArea;
		private double? _netArea;
		private CobieFloor _floor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public string @RoomTag 
		{ 
			get 
			{
				if(Activated) return _roomTag;
				
				Model.Activate(this, true);
				Activated = true;
				return _roomTag;
			} 
			set
			{
				SetValue( v =>  _roomTag = v, _roomTag, value,  "RoomTag");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public double? @UsableHeight 
		{ 
			get 
			{
				if(Activated) return _usableHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _usableHeight;
			} 
			set
			{
				SetValue( v =>  _usableHeight = v, _usableHeight, value,  "UsableHeight");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public double? @GrossArea 
		{ 
			get 
			{
				if(Activated) return _grossArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _grossArea;
			} 
			set
			{
				SetValue( v =>  _grossArea = v, _grossArea, value,  "GrossArea");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
		public double? @NetArea 
		{ 
			get 
			{
				if(Activated) return _netArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _netArea;
			} 
			set
			{
				SetValue( v =>  _netArea = v, _netArea, value,  "NetArea");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Mandatory)]
		public CobieFloor @Floor 
		{ 
			get 
			{
				if(Activated) return _floor;
				
				Model.Activate(this, true);
				Activated = true;
				return _floor;
			} 
			set
			{
				SetValue( v =>  _floor = v, _floor, value,  "Floor");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<CobieComponent> @Components 
		{ 
			get 
			{
				return Model.Instances.Where<CobieComponent>(e => e.Space == this);
			} 
		}
	
		public IEnumerable<CobieZone> @Zones 
		{ 
			get 
			{
				return Model.Instances.Where<CobieZone>(e => e.Spaces != null &&  e.Spaces.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"Category",
			"Impacts",
			"Documents",
			"Attributes",
			"RoomTag",
			"UsableHeight",
			"GrossArea",
			"NetArea",
			"Floor",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Created;
				case 1: 
					return @ExternalSystem;
				case 2: 
					return @ExternalObject;
				case 3: 
					return @ExternalId;
				case 4: 
					return @LocalId;
				case 5: 
					return @Name;
				case 6: 
					return @Description;
				case 7: 
					return @Category;
				case 8: 
					return @Impacts;
				case 9: 
					return @Documents;
				case 10: 
					return @Attributes;
				case 11: 
					return @RoomTag;
				case 12: 
					return @UsableHeight;
				case 13: 
					return @GrossArea;
				case 14: 
					return @NetArea;
				case 15: 
					return @Floor;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Created":  
					return @Created;
				case "ExternalSystem":  
					return @ExternalSystem;
				case "ExternalObject":  
					return @ExternalObject;
				case "ExternalId":  
					return @ExternalId;
				case "LocalId":  
					return @LocalId;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Category":  
					return @Category;
				case "Impacts":  
					return @Impacts;
				case "Documents":  
					return @Documents;
				case "Attributes":  
					return @Attributes;
				case "RoomTag":  
					return @RoomTag;
				case "UsableHeight":  
					return @UsableHeight;
				case "GrossArea":  
					return @GrossArea;
				case "NetArea":  
					return @NetArea;
				case "Floor":  
					return @Floor;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Created = (CobieCreatedInfo)value;
					 break;
				case 1:
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case 2:
					 @ExternalObject = (string)value;
					 break;
				case 3:
					 @ExternalId = (string)value;
					 break;
				case 4:
					 if (value != null) @LocalId = (long)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case 8:
					 @Impacts.Add((CobieImpact)value);
					 break;
				case 9:
					 @Documents.Add((CobieDocument)value);
					 break;
				case 10:
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case 11:
					 @RoomTag = (string)value;
					 break;
				case 12:
					 @UsableHeight = (double?)value;
					 break;
				case 13:
					 @GrossArea = (double?)value;
					 break;
				case 14:
					 @NetArea = (double?)value;
					 break;
				case 15:
					 @Floor = (CobieFloor)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Created":
					 @Created = (CobieCreatedInfo)value;
					 break;
				case "ExternalSystem":
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case "ExternalObject":
					 @ExternalObject = (string)value;
					 break;
				case "ExternalId":
					 @ExternalId = (string)value;
					 break;
				case "LocalId":
					 if (value != null) @LocalId = (long)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "Category":
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case "Impacts":
					 @Impacts.Add((CobieImpact)value);
					 break;
				case "Documents":
					 @Documents.Add((CobieDocument)value);
					 break;
				case "Attributes":
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case "RoomTag":
					 @RoomTag = (string)value;
					 break;
				case "UsableHeight":
					 @UsableHeight = (double?)value;
					 break;
				case "GrossArea":
					 @GrossArea = (double?)value;
					 break;
				case "NetArea":
					 @NetArea = (double?)value;
					 break;
				case "Floor":
					 @Floor = (CobieFloor)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}