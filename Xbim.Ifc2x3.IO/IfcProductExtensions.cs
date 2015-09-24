using System.Collections.Generic;
using Xbim.Ifc2x3.Kernel;
using Xbim.IO.Esent;
using Xbim.XbimExtensions;
using XbimGeometry.Interfaces;

namespace Xbim.IO
{
    public static class IfcProductExtensions
    {
        public static IEnumerable<XbimGeometryData> GeometryData(this  IfcProduct product, XbimGeometryType geomType)
        {
            var model = product.Model as EsentModel;
            if (model != null)
            {
                foreach (var item in model.GetGeometryData(product.EntityLabel, geomType))
                {
                    yield return item;
                }
            }
        }
    }
}
