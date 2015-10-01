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

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IFCEDGE", 595)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEdge : IfcTopologicalRepresentationItem, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcEdge>, System.IEquatable<@IfcEdge>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVertex _edgeStart;
		private IfcVertex _edgeEnd;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVertex @EdgeStart 
		{ 
			get 
			{
				if(Activated) return _edgeStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeStart;
			} 
			set
			{
				SetValue( v =>  _edgeStart = v, _edgeStart, value,  "EdgeStart");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVertex @EdgeEnd 
		{ 
			get 
			{
				if(Activated) return _edgeEnd;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeEnd;
			} 
			set
			{
				SetValue( v =>  _edgeEnd = v, _edgeEnd, value,  "EdgeEnd");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_edgeStart = (IfcVertex)(value.EntityVal);
					return;
				case 1: 
					_edgeEnd = (IfcVertex)(value.EntityVal);
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
        public bool Equals(@IfcEdge other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEdge
            var root = (@IfcEdge)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEdge left, @IfcEdge right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEdge left, @IfcEdge right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcEdge x, @IfcEdge y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcEdge obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}