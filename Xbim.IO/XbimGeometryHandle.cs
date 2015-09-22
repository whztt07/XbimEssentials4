using System.Reflection;
using Xbim.IO.Esent;
using XbimGeometry.Interfaces;

namespace Xbim.IO
{
    public struct XbimGeometryHandle
    {
        /// <summary>
        /// The unique ID of the geometry
        /// </summary>
        public int GeometryLabel;
        /// <summary>
        /// The label of the Ifc Entity that holds the surface style render
        /// </summary>
        public int SurfaceStyleLabel;
        /// <summary>
        /// The label of the Ifc Entity that the geomtry represents
        /// </summary>
        public int ProductLabel;
        /// <summary>
        /// The id of the Ifc Type of the Product represented
        /// </summary>
        public short ExpressTypeId;
        /// <summary>
        /// The type of geometric representation
        /// </summary>
        public XbimGeometryType GeometryType;

        /// <summary>
        /// The hash code of the geometry vertex data
        /// </summary>
        public int? GeometryHashCode;

        private readonly Module _module;

        /// <summary>
        /// A handle to a geometry object
        /// </summary>
        /// <param name="geometryLabel">The unique ID of the geometry</param>
        /// <param name="geometryType">The type of geometric representation</param>
        /// <param name="productLabel">The label of the Ifc Entity that the geomtry represents</param>
        /// <param name="expressTypeId">The id of the Ifc Type of the Product represented</param>
        /// <param name="surfaceStyleLabel">The label of the Ifc Entity that holds the surface style render</param>
        /// <param name="geometryHashCode"></param>
        public XbimGeometryHandle(int geometryLabel, XbimGeometryType geometryType, int productLabel, short expressTypeId, int surfaceStyleLabel, int? geometryHashCode, Module module)
        {
            GeometryLabel = geometryLabel;
            SurfaceStyleLabel = surfaceStyleLabel;
            ProductLabel = productLabel;
            ExpressTypeId = expressTypeId;
            GeometryType = geometryType;
            GeometryHashCode = geometryHashCode;
            _module = module;
        }
        public XbimGeometryHandle(int geometryLabel, XbimGeometryType geometryType, int productLabel, short expressTypeId, int surfaceStyleLabel, Module module)
            : this(geometryLabel, geometryType, productLabel, expressTypeId, surfaceStyleLabel, null, module)
        {
        }

        public XbimGeometryHandle(int geometryLabel)
        {
            GeometryLabel = geometryLabel;
            GeometryType = XbimGeometryType.Undefined;
            SurfaceStyleLabel = 0;
            ProductLabel = 0;
            ExpressTypeId = 0;
            GeometryHashCode = null;
            _module = null;
        }

        /// <summary>
        /// Returns the surface style for rendering this object
        /// </summary>
        public XbimSurfaceStyle SurfaceStyle
        {
            get
            {
                return new XbimSurfaceStyle(ExpressTypeId, SurfaceStyleLabel, _module);
            }
        }
    }
}
