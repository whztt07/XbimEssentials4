// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCPOLYLINE", 500)]
	public  partial class @IfcPolyline : IfcBoundedCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyline(IModel model) : base(model) 		{ 
			Model = model; 
			_points = new ItemSet<IfcCartesianPoint>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCartesianPoint> _points;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcCartesianPoint> @Points 
		{ 
			get 
			{
				if(Activated) return _points;
				
				Model.Activate(this, true);
				Activated = true;
				return _points;
			} 
			set
			{
				SetValue( v =>  _points = v, _points, value,  "Points");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Points",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Points;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Points":  
					return @Points;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Points.Add((IfcCartesianPoint)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Points":
					 @Points.Add((IfcCartesianPoint)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR41:	WR41 : SIZEOF(QUERY(Temp <* Points | Temp.Dim <> Points[1].Dim)) = 0;*/
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