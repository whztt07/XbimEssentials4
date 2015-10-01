// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ExternalReferenceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELASSOCIATESLIBRARY", 915)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesLibrary : IfcRelAssociates, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelAssociatesLibrary>, System.IEquatable<@IfcRelAssociatesLibrary>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesLibrary(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLibrarySelect _relatingLibrary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLibrarySelect @RelatingLibrary 
		{ 
			get 
			{
				if(Activated) return _relatingLibrary;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingLibrary;
			} 
			set
			{
				SetValue( v =>  _relatingLibrary = v, _relatingLibrary, value,  "RelatingLibrary");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_relatingLibrary = (IfcLibrarySelect)(value.EntityVal);
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
        public bool Equals(@IfcRelAssociatesLibrary other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssociatesLibrary
            var root = (@IfcRelAssociatesLibrary)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssociatesLibrary left, @IfcRelAssociatesLibrary right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssociatesLibrary left, @IfcRelAssociatesLibrary right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssociatesLibrary x, @IfcRelAssociatesLibrary y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssociatesLibrary obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}