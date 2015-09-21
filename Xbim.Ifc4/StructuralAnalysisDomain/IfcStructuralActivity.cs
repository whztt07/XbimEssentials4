// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.StructuralLoadResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALACTIVITY", 1011)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcStructuralActivity : IfcProduct
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralActivity(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStructuralLoad _appliedLoad;
		private IfcGlobalOrLocalEnum _globalOrLocal;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralLoad @AppliedLoad 
		{ 
			get 
			{
				if(Activated) return _appliedLoad;
				
				Model.Activate(this, true);
				Activated = true;
				return _appliedLoad;
			} 
			set
			{
				SetValue( v =>  _appliedLoad = v, _appliedLoad, value,  "AppliedLoad");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcGlobalOrLocalEnum @GlobalOrLocal 
		{ 
			get 
			{
				if(Activated) return _globalOrLocal;
				
				Model.Activate(this, true);
				Activated = true;
				return _globalOrLocal;
			} 
			set
			{
				SetValue( v =>  _globalOrLocal = v, _globalOrLocal, value,  "GlobalOrLocal");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelConnectsStructuralActivity> @AssignedToStructuralItem 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralActivity>(e => e.RelatedStructuralActivity == this);
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
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_appliedLoad = (IfcStructuralLoad)(value.EntityVal);
					return;
				case 8: 
                    _globalOrLocal = (IfcGlobalOrLocalEnum) System.Enum.Parse(typeof (IfcGlobalOrLocalEnum), value.EnumVal, true);
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
	}
}