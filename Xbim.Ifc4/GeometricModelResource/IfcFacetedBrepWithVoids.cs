// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometricModelResource
{
	[EntityName("IFCFACETEDBREPWITHVOIDS", 257)]
	public  partial class @IfcFacetedBrepWithVoids : IfcFacetedBrep, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFacetedBrepWithVoids(IModel model) : base(model) 		{ 
			Model = model; 
			_voids = new ItemSet<IfcClosedShell>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcClosedShell> _voids;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcClosedShell> @Voids 
		{ 
			get 
			{
				if(Activated) return _voids;
				
				Model.Activate(this, true);
				Activated = true;
				return _voids;
			} 
			set
			{
				SetValue( v =>  _voids = v, _voids, value,  "Voids");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Outer",
			"Voids",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Outer;
				case 1: 
					return @Voids;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Outer":  
					return @Outer;
				case "Voids":  
					return @Voids;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Outer = (IfcClosedShell)value;
					 break;
				case 1:
					 @Voids.Add((IfcClosedShell)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Outer":
					 @Outer = (IfcClosedShell)value;
					 break;
				case "Voids":
					 @Voids.Add((IfcClosedShell)value);
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

		public  override string WhereRule() 
		{
			return "";
		}
	}
}