// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IFCREINFORCEMENTBARPROPERTIES", 684)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementBarProperties : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcReinforcementBarProperties>, System.IEquatable<@IfcReinforcementBarProperties>
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
		public bool Activated { get; internal set; }

		void IPersistEntity.Activate(bool write)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object

			Model.Activate(this, write);
			Activated = true;
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			Activated = true;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementBarProperties(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _totalCrossSectionArea;
		private IfcLabel _steelGrade;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		private IfcLengthMeasure? _effectiveDepth;
		private IfcPositiveLengthMeasure? _nominalBarDiameter;
		private IfcCountMeasure? _barCount;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure @TotalCrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _totalCrossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _totalCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _totalCrossSectionArea = v, _totalCrossSectionArea, value,  "TotalCrossSectionArea");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @SteelGrade 
		{ 
			get 
			{
				if(Activated) return _steelGrade;
				
				Model.Activate(this, true);
				Activated = true;
				return _steelGrade;
			} 
			set
			{
				SetValue( v =>  _steelGrade = v, _steelGrade, value,  "SteelGrade");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(Activated) return _barSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @EffectiveDepth 
		{ 
			get 
			{
				if(Activated) return _effectiveDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _effectiveDepth;
			} 
			set
			{
				SetValue( v =>  _effectiveDepth = v, _effectiveDepth, value,  "EffectiveDepth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @NominalBarDiameter 
		{ 
			get 
			{
				if(Activated) return _nominalBarDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalBarDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalBarDiameter = v, _nominalBarDiameter, value,  "NominalBarDiameter");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCountMeasure? @BarCount 
		{ 
			get 
			{
				if(Activated) return _barCount;
				
				Model.Activate(this, true);
				Activated = true;
				return _barCount;
			} 
			set
			{
				SetValue( v =>  _barCount = v, _barCount, value,  "BarCount");
			} 
		}
	
		#endregion


		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{

			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => setter(newValue);
			Action undoAction = () => setter(oldValue);
			setter(newValue);

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_totalCrossSectionArea = value.RealVal;
					return;
				case 1: 
					_steelGrade = value.StringVal;
					return;
				case 2: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				case 3: 
					_effectiveDepth = value.RealVal;
					return;
				case 4: 
					_nominalBarDiameter = value.RealVal;
					return;
				case 5: 
					_barCount = value.NumberVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcementBarProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcementBarProperties
            var root = (@IfcReinforcementBarProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcementBarProperties left, @IfcReinforcementBarProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcementBarProperties left, @IfcReinforcementBarProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcementBarProperties x, @IfcReinforcementBarProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcementBarProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}