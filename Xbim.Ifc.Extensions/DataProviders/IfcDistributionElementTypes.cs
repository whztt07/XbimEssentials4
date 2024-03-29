#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcDistributionElementTypes.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Ifc2x3.ProductExtension;

#endregion

namespace Xbim.XbimExtensions.DataProviders
{
    public class IfcDistributionElementTypes
    {
        private readonly IModel _model;

        public IfcDistributionElementTypes(IModel model)
        {
            this._model = model;
        }

        public IEnumerable<IfcDistributionElementType> Items
        {
            get { return this._model.Instances.OfType<IfcDistributionElementType>(); }
        }

        public IfcDistributionFlowElementTypes IfcDistributionFlowElementTypes
        {
            get { return new IfcDistributionFlowElementTypes(_model); }
        }

        public IfcDistributionControlElementTypes IfcDistributionControlElementTypes
        {
            get { return new IfcDistributionControlElementTypes(_model); }
        }
    }
}