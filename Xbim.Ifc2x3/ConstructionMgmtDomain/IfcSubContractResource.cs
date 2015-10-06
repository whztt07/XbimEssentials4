// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	[ExpressType("IFCSUBCONTRACTRESOURCE", 594)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSubContractResource : IfcConstructionResource, IInstantiableEntity, IEqualityComparer<@IfcSubContractResource>, IEquatable<@IfcSubContractResource>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSubContractResource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActorSelect _subContractor;
		private IfcText? _jobDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @SubContractor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _subContractor;
				((IPersistEntity)this).Activate(false);
				return _subContractor;
			} 
			set
			{
				SetValue( v =>  _subContractor = v, _subContractor, value,  "SubContractor");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @JobDescription 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jobDescription;
				((IPersistEntity)this).Activate(false);
				return _jobDescription;
			} 
			set
			{
				SetValue( v =>  _jobDescription = v, _jobDescription, value,  "JobDescription");
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					_subContractor = (IfcActorSelect)(value.EntityVal);
					return;
				case 10: 
					_jobDescription = value.StringVal;
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
        public bool Equals(@IfcSubContractResource other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcSubContractResource left, @IfcSubContractResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSubContractResource left, @IfcSubContractResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSubContractResource x, @IfcSubContractResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSubContractResource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}