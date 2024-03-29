// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[IndexedClass]
	[ExpressType("IFCCOMPOSITEPROFILEDEF", 503)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeProfileDef : IfcProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
			_profiles = new ItemSet<IfcProfileDef>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProfileDef> _profiles;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcProfileDef> @Profiles 
		{ 
			get 
			{
				if(Activated) return _profiles;
				
				Model.Activate(this, true);
				Activated = true;
				return _profiles;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(Activated) return _label;
				
				Model.Activate(this, true);
				Activated = true;
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					if (_profiles == null) _profiles = new ItemSet<IfcProfileDef>( this );
					_profiles.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 3: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*InvariantProfileType:	InvariantProfileType : SIZEOF(QUERY(temp <* Profiles | temp.ProfileType <> Profiles[1].ProfileType)) = 0;*/
		/*NoRecursion:	NoRecursion : SIZEOF(QUERY(temp <* Profiles | 'IFC4.IFCCOMPOSITEPROFILEDEF' IN TYPEOF(temp))) = 0;*/
		}
		#endregion
	}
}