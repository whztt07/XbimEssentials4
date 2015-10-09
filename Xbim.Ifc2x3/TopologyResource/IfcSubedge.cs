// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IFCSUBEDGE", 487)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSubedge : IfcEdge, IInstantiableEntity, IEqualityComparer<@IfcSubedge>, IEquatable<@IfcSubedge>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSubedge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEdge _parentEdge;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcEdge @ParentEdge 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parentEdge;
				((IPersistEntity)this).Activate(false);
				return _parentEdge;
			} 
			set
			{
				SetValue( v =>  _parentEdge = v, _parentEdge, value,  "ParentEdge");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_parentEdge = (IfcEdge)(value.EntityVal);
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
        public bool Equals(@IfcSubedge other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSubedge
            var root = (@IfcSubedge)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSubedge left, @IfcSubedge right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSubedge left, @IfcSubedge right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSubedge x, @IfcSubedge y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSubedge obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}