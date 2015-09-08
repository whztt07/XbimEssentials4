// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[EntityName("IFCDRAUGHTINGCALLOUT")]
	public  partial class @IfcDraughtingCallout : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingCallout(IModel model) : base(model) 		{ 
			Model = model; 
			_contents = new ItemSet<IfcDraughtingCalloutElement>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDraughtingCalloutElement> _contents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDraughtingCalloutElement> @Contents 
		{ 
			get 
			{
				if(IsActivated) return _contents;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _contents;
			} 
			set
			{
				SetValue( v =>  _contents = v, _contents, value,  "Contents");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedFromCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatedDraughtingCallout == this);
			} 
		}
	
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedToCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatingDraughtingCallout == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Contents",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Contents;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Contents":  
					return @Contents;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Contents.Add((IfcDraughtingCalloutElement)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Contents":
					 @Contents.Add((IfcDraughtingCalloutElement)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}