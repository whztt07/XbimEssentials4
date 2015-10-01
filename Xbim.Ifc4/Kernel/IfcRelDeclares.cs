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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELDECLARES", 929)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDeclares : IfcRelationship, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelDeclares>, System.IEquatable<@IfcRelDeclares>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDeclares(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedDefinitions = new ItemSet<IfcDefinitionSelect>( this );
		}

		#region Explicit attribute fields
		private IfcContext _relatingContext;
		private ItemSet<IfcDefinitionSelect> _relatedDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcContext @RelatingContext 
		{ 
			get 
			{
				if(Activated) return _relatingContext;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingContext;
			} 
			set
			{
				SetValue( v =>  _relatingContext = v, _relatingContext, value,  "RelatingContext");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDefinitionSelect> @RelatedDefinitions 
		{ 
			get 
			{
				if(Activated) return _relatedDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedDefinitions;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_relatingContext = (IfcContext)(value.EntityVal);
					return;
				case 5: 
					if (_relatedDefinitions == null) _relatedDefinitions = new ItemSet<IfcDefinitionSelect>( this );
					_relatedDefinitions.InternalAdd((IfcDefinitionSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* RelatedDefinitions | RelatingContext :=: Temp)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDeclares other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDeclares
            var root = (@IfcRelDeclares)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDeclares left, @IfcRelDeclares right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDeclares left, @IfcRelDeclares right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelDeclares x, @IfcRelDeclares y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelDeclares obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}