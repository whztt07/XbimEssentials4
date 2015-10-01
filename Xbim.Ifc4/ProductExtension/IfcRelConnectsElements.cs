// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCRELCONNECTSELEMENTS", 918)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsElements : IfcRelConnects, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelConnectsElements>, System.IEquatable<@IfcRelConnectsElements>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsElements(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcConnectionGeometry _connectionGeometry;
		private IfcElement _relatingElement;
		private IfcElement _relatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcConnectionGeometry @ConnectionGeometry 
		{ 
			get 
			{
				if(Activated) return _connectionGeometry;
				
				Model.Activate(this, true);
				Activated = true;
				return _connectionGeometry;
			} 
			set
			{
				SetValue( v =>  _connectionGeometry = v, _connectionGeometry, value,  "ConnectionGeometry");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(Activated) return _relatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingElement;
			} 
			set
			{
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatedElement 
		{ 
			get 
			{
				if(Activated) return _relatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedElement;
			} 
			set
			{
				SetValue( v =>  _relatedElement = v, _relatedElement, value,  "RelatedElement");
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
					_connectionGeometry = (IfcConnectionGeometry)(value.EntityVal);
					return;
				case 5: 
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 6: 
					_relatedElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : RelatingElement :<>: RelatedElement;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsElements other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelConnectsElements left, @IfcRelConnectsElements right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsElements left, @IfcRelConnectsElements right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelConnectsElements x, @IfcRelConnectsElements y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelConnectsElements obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}