// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:54
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace Xbim.Common
{
	public interface IEntityCollection: IEnumerable<IPersistEntity>
	{
		IEnumerable<T> Where<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity;
        T FirstOrDefault<T>() where T : IPersistEntity;
		T FirstOrDefault<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity;
        IEnumerable<T> OfType<T>() where T : IPersistEntity;
        IEnumerable<T> OfType<T>(bool activate) where T : IPersistEntity;
        IEnumerable<IPersistEntity> OfType(string stringType, bool activate);
        IPersistEntity New(Type t);
        T New<T>(Action<T> initPropertiesFunc) where T : IInstantiableEntity;
        T New<T>() where T : IInstantiableEntity;
        IPersistEntity this[int label] { get; }
        long Count { get; }
        long CountOf<T>() where T : IPersistEntity;
	}
}