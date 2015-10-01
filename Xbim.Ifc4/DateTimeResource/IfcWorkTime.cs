// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IFCWORKTIME", 1154)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkTime : IfcSchedulingTime, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcWorkTime>, System.IEquatable<@IfcWorkTime>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrencePattern;
		private IfcDate? _start;
		private IfcDate? _finish;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRecurrencePattern @RecurrencePattern 
		{ 
			get 
			{
				if(Activated) return _recurrencePattern;
				
				Model.Activate(this, true);
				Activated = true;
				return _recurrencePattern;
			} 
			set
			{
				SetValue( v =>  _recurrencePattern = v, _recurrencePattern, value,  "RecurrencePattern");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @Start 
		{ 
			get 
			{
				if(Activated) return _start;
				
				Model.Activate(this, true);
				Activated = true;
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @Finish 
		{ 
			get 
			{
				if(Activated) return _finish;
				
				Model.Activate(this, true);
				Activated = true;
				return _finish;
			} 
			set
			{
				SetValue( v =>  _finish = v, _finish, value,  "Finish");
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
					_recurrencePattern = (IfcRecurrencePattern)(value.EntityVal);
					return;
				case 4: 
					_start = value.StringVal;
					return;
				case 5: 
					_finish = value.StringVal;
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
        public bool Equals(@IfcWorkTime other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcWorkTime left, @IfcWorkTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWorkTime left, @IfcWorkTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWorkTime x, @IfcWorkTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWorkTime obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}