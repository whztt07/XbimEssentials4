// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedComponentElements
{
	[IndexedClass]
	[ExpressType("IFCELEMENTCOMPONENT", 424)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcElementComponent : IfcElement
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementComponent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
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
				case 7: 
					base.Parse(propIndex, value); 
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