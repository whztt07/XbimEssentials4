// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;

namespace Xbim.Common
{
	public interface IEntityFactory 
	{
		T New<T>(IModel model, int entityLabel, bool activated) where T: IInstantiableEntity;

		T New<T>(IModel model, Action<T> init, int entityLabel, bool activated) where T: IInstantiableEntity;

		IInstantiableEntity New(IModel model, Type t, int entityLabel, bool activated);

		IInstantiableEntity New(IModel model, string typeName, int entityLabel, bool activated);
		
		IInstantiableEntity New(IModel model, int typeId, int entityLabel, bool activated);

		IExpressType New(string typeName);
	}
}