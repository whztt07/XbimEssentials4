// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationResource
{
	[IndexedClass]
	[ExpressType("IFCDRAUGHTINGPREDEFINEDTEXTFONT", 761)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDraughtingPreDefinedTextFont : IfcPreDefinedTextFont, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingPreDefinedTextFont(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : SELF\IfcPreDefinedItem.Name IN ['ISO 3098-1 font A','ISO 3098-1 font B'];*/
		}
		#endregion
	}
}