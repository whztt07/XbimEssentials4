// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALLOADSINGLEDISPLACEMENTDISTORTION", 290)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleDisplacementDistortion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurvatureMeasure? _distortion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCurvatureMeasure? @Distortion 
		{ 
			get 
			{
				if(Activated) return _distortion;
				
				Model.Activate(this, true);
				Activated = true;
				return _distortion;
			} 
			set
			{
				SetValue( v =>  _distortion = v, _distortion, value,  "Distortion");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
					_distortion = value.RealVal;
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