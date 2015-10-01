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
	[ExpressType("IFCPROPERTYSETTEMPLATE", 859)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertySetTemplate : IfcPropertyTemplateDefinition, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcPropertySetTemplate>, System.IEquatable<@IfcPropertySetTemplate>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( this );
		}

		#region Explicit attribute fields
		private IfcPropertySetTemplateTypeEnum? _templateType;
		private IfcIdentifier? _applicableEntity;
		private ItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcPropertySetTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(Activated) return _templateType;
				
				Model.Activate(this, true);
				Activated = true;
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @ApplicableEntity 
		{ 
			get 
			{
				if(Activated) return _applicableEntity;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableEntity;
			} 
			set
			{
				SetValue( v =>  _applicableEntity = v, _applicableEntity, value,  "ApplicableEntity");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(Activated) return _hasPropertyTemplates;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertyTemplates;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByTemplate> @Defines 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByTemplate>(e => e.RelatingTemplate == this);
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
                    _templateType = (IfcPropertySetTemplateTypeEnum) System.Enum.Parse(typeof (IfcPropertySetTemplateTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_applicableEntity = value.StringVal;
					return;
				case 6: 
					if (_hasPropertyTemplates == null) _hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( this );
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ExistsName:	ExistsName : EXISTS(SELF\IfcRoot.Name);*/
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyTemplateNames(HasPropertyTemplates);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertySetTemplate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertySetTemplate
            var root = (@IfcPropertySetTemplate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertySetTemplate left, @IfcPropertySetTemplate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertySetTemplate left, @IfcPropertySetTemplate right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertySetTemplate x, @IfcPropertySetTemplate y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertySetTemplate obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}