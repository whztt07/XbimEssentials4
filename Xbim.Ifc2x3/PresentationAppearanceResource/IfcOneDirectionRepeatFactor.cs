// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCONEDIRECTIONREPEATFACTOR", 32)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOneDirectionRepeatFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVector _repeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcVector @RepeatFactor 
		{ 
			get 
			{
				if(Activated) return _repeatFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatFactor;
			} 
			set
			{
				SetValue( v =>  _repeatFactor = v, _repeatFactor, value,  "RepeatFactor");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"RepeatFactor",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @RepeatFactor;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "RepeatFactor":  
					return @RepeatFactor;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @RepeatFactor = (IfcVector)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "RepeatFactor":
					 @RepeatFactor = (IfcVector)value;
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
					_repeatFactor = (IfcVector)(value.EntityVal);
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