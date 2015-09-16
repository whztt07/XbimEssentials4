// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.TopologyResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[EntityName("IFCMANIFOLDSOLIDBREP", 149)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcManifoldSolidBrep : IfcSolidModel
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcManifoldSolidBrep(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClosedShell _outer;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcClosedShell @Outer 
		{ 
			get 
			{
				if(Activated) return _outer;
				
				Model.Activate(this, true);
				Activated = true;
				return _outer;
			} 
			set
			{
				SetValue( v =>  _outer = v, _outer, value,  "Outer");
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
					_outer = (IfcClosedShell)(value.EntityVal);
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