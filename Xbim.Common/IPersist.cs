// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Xbim.Common
{
	public interface IPersist
	{
		void Parse(int propIndex, IPropertyValue value);
        
		/// <summary>
        ///   Validates the object against the Ifc schema where rule, returns empty string if the object complies or an error string indicating the reason for compliance failure
        /// </summary>
        /// <returns></returns>
        string WhereRule();
	}
}