#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcStructuralLoadSingleForceWarpings.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Ifc2x3.StructuralLoadResource;

#endregion

namespace Xbim.XbimExtensions.DataProviders
{
    public class IfcStructuralLoadSingleForceWarpings
    {
        private readonly IModel _model;

        public IfcStructuralLoadSingleForceWarpings(IModel model)
        {
            this._model = model;
        }

        public IEnumerable<IfcStructuralLoadSingleForceWarping> Items
        {
            get { return this._model.Instances.OfType<IfcStructuralLoadSingleForceWarping>(); }
        }
    }
}