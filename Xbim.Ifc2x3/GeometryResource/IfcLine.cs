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

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCLINE", 272)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLine : IfcCurve, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcLine>, System.IEquatable<@IfcLine>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLine(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _pnt;
		private IfcVector _dir;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Pnt 
		{ 
			get 
			{
				if(Activated) return _pnt;
				
				Model.Activate(this, true);
				Activated = true;
				return _pnt;
			} 
			set
			{
				SetValue( v =>  _pnt = v, _pnt, value,  "Pnt");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVector @Dir 
		{ 
			get 
			{
				if(Activated) return _dir;
				
				Model.Activate(this, true);
				Activated = true;
				return _dir;
			} 
			set
			{
				SetValue( v =>  _dir = v, _dir, value,  "Dir");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_pnt = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_dir = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Dir.Dim = Pnt.Dim;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLine other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLine
            var root = (@IfcLine)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLine left, @IfcLine right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLine left, @IfcLine right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLine x, @IfcLine y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLine obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}