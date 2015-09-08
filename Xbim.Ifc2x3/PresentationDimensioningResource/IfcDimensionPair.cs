// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[EntityName("IFCDIMENSIONPAIR")]
	public  partial class @IfcDimensionPair : IfcDraughtingCalloutRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionPair(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"RelatingDraughtingCallout",
			"RelatedDraughtingCallout",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @RelatingDraughtingCallout;
				case 3: 
					return @RelatedDraughtingCallout;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "RelatingDraughtingCallout":  
					return @RelatingDraughtingCallout;
				case "RelatedDraughtingCallout":  
					return @RelatedDraughtingCallout;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @RelatingDraughtingCallout = (IfcDraughtingCallout)value;
					 break;
				case 3:
					 @RelatedDraughtingCallout = (IfcDraughtingCallout)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "RelatingDraughtingCallout":
					 @RelatingDraughtingCallout = (IfcDraughtingCallout)value;
					 break;
				case "RelatedDraughtingCallout":
					 @RelatedDraughtingCallout = (IfcDraughtingCallout)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR11:	WR11 : SELF.Name IN ['chained','parallel'];*/
		/*WR12:                            'IFC2X3.IFCRADIUSDIMENSION']) = 1;*/
		/*WR13:                            'IFC2X3.IFCRADIUSDIMENSION']) = 1;*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}