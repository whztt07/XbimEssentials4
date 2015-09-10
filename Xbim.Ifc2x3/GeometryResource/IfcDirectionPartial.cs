using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common.Geometry;

namespace Xbim.Ifc2x3.GeometryResource
{

    public partial class IfcDirection
    {

        public XbimVector3D XbimVector3D()
        {
            return new XbimVector3D(_x, _y, double.IsNaN(_z) ? 0 : _z);
        }
    }
}
