// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Xbim.Common
{
	public interface ITransaction: IDisposable
	{
		string Name { get; }
		void Commit();
		void RollBack();
		void AddReversibleAction(Action doAction, Action undoAction, IPersistEntity entity);
		IEnumerable<IPersistEntity> Modified { get; }
	}
}