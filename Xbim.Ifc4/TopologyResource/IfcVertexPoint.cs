// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IFCVERTEXPOINT", 1132)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexPoint : IfcVertex, IfcPointOrVertexPoint, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcVertexPoint>, System.IEquatable<@IfcVertexPoint>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexPoint(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPoint _vertexGeometry;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPoint @VertexGeometry 
		{ 
			get 
			{
				if(Activated) return _vertexGeometry;
				
				Model.Activate(this, true);
				Activated = true;
				return _vertexGeometry;
			} 
			set
			{
				SetValue( v =>  _vertexGeometry = v, _vertexGeometry, value,  "VertexGeometry");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_vertexGeometry = (IfcPoint)(value.EntityVal);
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

		#region Equality comparers and operators
        public bool Equals(@IfcVertexPoint other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcVertexPoint
            var root = (@IfcVertexPoint)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcVertexPoint left, @IfcVertexPoint right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcVertexPoint left, @IfcVertexPoint right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcVertexPoint x, @IfcVertexPoint y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcVertexPoint obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}