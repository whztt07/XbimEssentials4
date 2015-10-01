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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCRELCONNECTSPORTS", 921)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPorts : IfcRelConnects, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelConnectsPorts>, System.IEquatable<@IfcRelConnectsPorts>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPorts(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPort _relatingPort;
		private IfcPort _relatedPort;
		private IfcElement _realizingElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPort @RelatingPort 
		{ 
			get 
			{
				if(Activated) return _relatingPort;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingPort;
			} 
			set
			{
				SetValue( v =>  _relatingPort = v, _relatingPort, value,  "RelatingPort");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPort @RelatedPort 
		{ 
			get 
			{
				if(Activated) return _relatedPort;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedPort;
			} 
			set
			{
				SetValue( v =>  _relatedPort = v, _relatedPort, value,  "RelatedPort");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RealizingElement 
		{ 
			get 
			{
				if(Activated) return _realizingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _realizingElement;
			} 
			set
			{
				SetValue( v =>  _realizingElement = v, _realizingElement, value,  "RealizingElement");
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
					_relatingPort = (IfcPort)(value.EntityVal);
					return;
				case 5: 
					_relatedPort = (IfcPort)(value.EntityVal);
					return;
				case 6: 
					_realizingElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : RelatingPort :<>: RelatedPort;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPorts other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelConnectsPorts left, @IfcRelConnectsPorts right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsPorts left, @IfcRelConnectsPorts right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelConnectsPorts x, @IfcRelConnectsPorts y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelConnectsPorts obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}