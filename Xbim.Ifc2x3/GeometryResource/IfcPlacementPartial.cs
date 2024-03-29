﻿using Xbim.Common.Geometry;

namespace Xbim.Ifc2x3.GeometryResource
{
    public partial class IfcPlacement
    {
        public XbimMatrix3D ToMatrix3D()
        {
            var ax3 = this as IfcAxis2Placement3D;
            if (ax3 != null)
                return ax3.ToMatrix3D();

            var ax2 = this as IfcAxis2Placement2D;
            return ax2 != null ? ax2.ToMatrix3D() : XbimMatrix3D.Identity;
        }

        /// <summary>
        ///   Derived. The space dimensionality of this class, derived from the dimensionality of the location.
        /// </summary>

        public IfcDimensionCount Dim
        {
            get { return Location == null ? 0 : Location.Dim; }
        }
    }
}
