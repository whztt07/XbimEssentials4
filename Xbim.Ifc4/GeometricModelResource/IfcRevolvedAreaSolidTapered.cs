// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCREVOLVEDAREASOLIDTAPERED", 960)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRevolvedAreaSolidTapered(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _endSweptArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @EndSweptArea 
		{ 
			get 
			{
				if(Activated) return _endSweptArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _endSweptArea;
			} 
			set
			{
				SetValue( v =>  _endSweptArea = v, _endSweptArea, value,  "EndSweptArea");
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
					_endSweptArea = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectProfileAssignment:	CorrectProfileAssignment : IfcTaperedSweptAreaProfiles(SELF\IfcSweptAreaSolid.SweptArea, SELF.EndSweptArea);*/
		}
		#endregion
	}
}