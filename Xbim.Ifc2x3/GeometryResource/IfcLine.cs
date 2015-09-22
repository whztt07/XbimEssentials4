// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCLINE", 272)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLine : IfcCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLine(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _pnt;
		private IfcVector _dir;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Pnt 
		{ 
			get 
			{
				if(Activated) return _pnt;
				
				Model.Activate(this, true);
				Activated = true;
				return _pnt;
			} 
			set
			{
				SetValue( v =>  _pnt = v, _pnt, value,  "Pnt");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVector @Dir 
		{ 
			get 
			{
				if(Activated) return _dir;
				
				Model.Activate(this, true);
				Activated = true;
				return _dir;
			} 
			set
			{
				SetValue( v =>  _dir = v, _dir, value,  "Dir");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_pnt = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_dir = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Dir.Dim = Pnt.Dim;*/
		}
		#endregion
	}
}