// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[EntityName("IFCSOUNDPROPERTIES", 474)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSoundProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSoundProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_soundValues = new ItemSet<IfcSoundValue>( model );
		}

		#region Explicit attribute fields
		private IfcBoolean _isAttenuating;
		private IfcSoundScaleEnum? _soundScale;
		private ItemSet<IfcSoundValue> _soundValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcBoolean @IsAttenuating 
		{ 
			get 
			{
				if(Activated) return _isAttenuating;
				
				Model.Activate(this, true);
				Activated = true;
				return _isAttenuating;
			} 
			set
			{
				SetValue( v =>  _isAttenuating = v, _isAttenuating, value,  "IsAttenuating");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcSoundScaleEnum? @SoundScale 
		{ 
			get 
			{
				if(Activated) return _soundScale;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundScale;
			} 
			set
			{
				SetValue( v =>  _soundScale = v, _soundScale, value,  "SoundScale");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public ItemSet<IfcSoundValue> @SoundValues 
		{ 
			get 
			{
				if(Activated) return _soundValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundValues;
			} 
			set
			{
				SetValue( v =>  _soundValues = v, _soundValues, value,  "SoundValues");
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
			"IsAttenuating",
			"SoundScale",
			"SoundValues",
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
					return @IsAttenuating;
				case 5: 
					return @SoundScale;
				case 6: 
					return @SoundValues;
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
				case "IsAttenuating":  
					return @IsAttenuating;
				case "SoundScale":  
					return @SoundScale;
				case "SoundValues":  
					return @SoundValues;
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
					 if (value != null) @IsAttenuating = (IfcBoolean)value;
					 break;
				case 5:
					 @SoundScale = (IfcSoundScaleEnum?)value;
					 break;
				case 6:
					 @SoundValues.Add((IfcSoundValue)value);
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
				case "IsAttenuating":
					 if (value != null) @IsAttenuating = (IfcBoolean)value;
					 break;
				case "SoundScale":
					 @SoundScale = (IfcSoundScaleEnum?)value;
					 break;
				case "SoundValues":
					 @SoundValues.Add((IfcSoundValue)value);
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_isAttenuating = value.BooleanVal;
					return;
				case 5: 
                    _soundScale = (IfcSoundScaleEnum) System.Enum.Parse(typeof (IfcSoundScaleEnum), value.EnumVal, true);
					return;
				case 6: 
					if (_soundValues == null) _soundValues = new ItemSet<IfcSoundValue>( Model );
					_soundValues.Add((IfcSoundValue)value.EntityVal);
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