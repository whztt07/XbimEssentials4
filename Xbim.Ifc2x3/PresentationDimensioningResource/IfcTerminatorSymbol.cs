// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IFCTERMINATORSYMBOL", 743)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence, IInstantiableEntity, IEqualityComparer<@IfcTerminatorSymbol>, IEquatable<@IfcTerminatorSymbol>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTerminatorSymbol(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAnnotationCurveOccurrence _annotatedCurve;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAnnotationCurveOccurrence @AnnotatedCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _annotatedCurve;
				((IPersistEntity)this).Activate(false);
				return _annotatedCurve;
			} 
			set
			{
				SetValue( v =>  _annotatedCurve = v, _annotatedCurve, value,  "AnnotatedCurve");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_annotatedCurve = (IfcAnnotationCurveOccurrence)(value.EntityVal);
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
        public bool Equals(@IfcTerminatorSymbol other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcTerminatorSymbol left, @IfcTerminatorSymbol right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTerminatorSymbol left, @IfcTerminatorSymbol right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTerminatorSymbol x, @IfcTerminatorSymbol y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTerminatorSymbol obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}