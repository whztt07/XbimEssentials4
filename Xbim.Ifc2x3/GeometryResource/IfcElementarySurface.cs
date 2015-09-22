// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCELEMENTARYSURFACE", 389)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcElementarySurface : IfcSurface
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementarySurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(Activated) return _position;
				
				Model.Activate(this, true);
				Activated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
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