#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    XbimArray.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;
using Xbim.XbimExtensions;

#endregion

namespace Xbim.Common.XbimExtensions
{
    public class XbimArray<T> : XbimList<T>
    {
        internal XbimArray(IPersistEntity owner, int capacity)
            : base(owner, capacity)
        {
        }

        internal XbimArray(IPersistEntity owner, IEnumerable<T> list)
            : base(owner, list)
        {
        }


        public override string ListType
        {
            get { return "array"; }
        }
    }
}