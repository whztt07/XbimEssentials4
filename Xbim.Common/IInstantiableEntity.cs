// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:26
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Xbim.Common
{
	public interface @IInstantiableEntity : IPersistEntity, IPersist
	{
		object GetValue(string propertyName);
		object GetValue(int propertyIndex);
		void SetValue(string propertyName, object value);
		void SetValue(int propertyIndex, object value);
		IEnumerable<string> PropertyNames { get; }
	}
}