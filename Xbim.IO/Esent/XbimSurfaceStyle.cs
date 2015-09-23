using System.Reflection;
using Xbim.Common;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.IO.Esent
{
    /// <summary>
    /// Represents a material used to render a surface of a geometry
    /// </summary>
    public struct XbimSurfaceStyle
    {
        private readonly int _styleId;
        private readonly short _expressTypeId;
        private readonly Module _module;

        /// <summary>
        /// Holds the material used by the graphics engine to render the surface style
        /// Set to a value to suite  specific needs of the graphics environment being used
        /// </summary>
        public object TagRenderMaterial;
        ///// <summary>
        ///// List of Geometry data objects rendererd by this style
        ///// </summary>
        //public List<XbimGeometryData> GeometryData = new List<XbimGeometryData>();


        public short ExpressTypeId
        {
            get { return _expressTypeId; }
        }

        public XbimSurfaceStyle(short expressTypeId, int ifcSurfaceStyleId, Module module)
        {

            _expressTypeId = expressTypeId;
            _styleId = ifcSurfaceStyleId;
            _module = module;
            TagRenderMaterial = null;
        }


        public int IfcSurfaceStyleLabel
        {
            get { return _styleId; }
          
        }

        public IfcSurfaceStyle IfcSurfaceStyle(EsentModel model)
        {
            if (IsIfcSurfaceStyle) return (IfcSurfaceStyle)model.Instances[_styleId]; else return null;
        }

        public ExpressType ExpressType
        {
            get { return ExpressMetaData.ExpressType(_expressTypeId, _module); }
           
        }

        public bool IsIfcSurfaceStyle
        {
            get
            {
                return _styleId > 0;
            }
        }


        public override int GetHashCode()
        {
            if (IsIfcSurfaceStyle) return _styleId; else return _expressTypeId * -1;
        }

        public override bool Equals(object obj)
        {
            
            if (obj is XbimSurfaceStyle)
            {
                var compareTo = (XbimSurfaceStyle) obj;
                if (IsIfcSurfaceStyle && _styleId == compareTo._styleId) //if it is a surface style then this takes priority
                    return true;
                else if (IsIfcSurfaceStyle)
                    return false;
                else
                    return _expressTypeId == compareTo._expressTypeId; //otherwise the ifc type is precedent
            }
            else
                return false;
           
        }


    }
}
