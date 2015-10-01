// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IFCVERTEXLOOP", 244)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexLoop : IfcLoop, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcVertexLoop>, System.IEquatable<@IfcVertexLoop>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexLoop(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVertex _loopVertex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVertex @LoopVertex 
		{ 
			get 
			{
				if(Activated) return _loopVertex;
				
				Model.Activate(this, true);
				Activated = true;
				return _loopVertex;
			} 
			set
			{
				SetValue( v =>  _loopVertex = v, _loopVertex, value,  "LoopVertex");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_loopVertex = (IfcVertex)(value.EntityVal);
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
        public bool Equals(@IfcVertexLoop other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcVertexLoop left, @IfcVertexLoop right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcVertexLoop left, @IfcVertexLoop right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcVertexLoop x, @IfcVertexLoop y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcVertexLoop obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}