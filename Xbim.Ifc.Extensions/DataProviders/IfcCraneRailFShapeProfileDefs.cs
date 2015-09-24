#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcCraneRailFShapeProfileDefs.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Ifc2x3.ProfileResource;

#endregion

namespace Xbim.XbimExtensions.DataProviders
{
    public class IfcCraneRailFShapeProfileDefs
    {
        private readonly IModel _model;

        public IfcCraneRailFShapeProfileDefs(IModel model)
        {
            this._model = model;
        }

        public IEnumerable<IfcCraneRailFShapeProfileDef> Items
        {
            get { return this._model.Instances.OfType<IfcCraneRailFShapeProfileDef>(); }
        }
    }
}