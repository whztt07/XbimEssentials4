﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xbim.Common;

namespace Xbim.IO.Esent
{
    /// <summary>
    /// An ordered Collection of geometry handles
    /// </summary>
    public class XbimGeometryHandleCollection : List<XbimGeometryHandle>
    {
        private readonly Module _schemaModule;

        public XbimGeometryHandleCollection(IEnumerable<XbimGeometryHandle> enumerable, Module module)
            : base(enumerable)
        {
            _schemaModule = module;
        }

        public XbimGeometryHandleCollection(Module module)
            : base()
        {
            _schemaModule = module;
            // TODO: Complete member initialization
        }
        /// <summary>
        /// Returns a list of unique surface style for this collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<XbimSurfaceStyle> GetSurfaceStyles()
        {
            var uniqueStyles = new HashSet<XbimSurfaceStyle>();
            foreach (var item in this)
            {
                uniqueStyles.Add(item.SurfaceStyle);
            }
            return uniqueStyles;
        }

        /// <summary>
        /// Returns all handles that are not of type to exclude
        /// </summary>
        /// <param name="exclude"></param>
        /// <returns></returns>
        public IEnumerable<XbimGeometryHandle> Exclude(params int[] exclude)
        {
            var excludeSet = new HashSet<int>(exclude);
            foreach (var ex in exclude)
            {
                
                var type = ExpressMetaData.ExpressType((short)ex, _schemaModule);
                // bugfix here: loop did not use to include all implementations, but only first level down.
                foreach (var sub in type.NonAbstractSubTypes)
                {
                    var ifcSub = ExpressMetaData.ExpressType(sub);
                        excludeSet.Add(ifcSub.TypeId);
                }
            }

            return this.Where(h => !excludeSet.Contains(h.ExpressTypeId));          
        }

        /// <summary>
        /// returns all handles that of of type to include
        /// </summary>
        /// <param name="include"></param>
        /// <returns></returns>
        public IEnumerable<XbimGeometryHandle> Include(params int[] include)
        {
            var includeSet = new HashSet<int>(include);
            foreach (var inc in include)
            {
                var type = ExpressMetaData.ExpressType((short)inc, _schemaModule);
                foreach (var sub in type.SubTypes)
                    includeSet.Add(sub.TypeId);
            }
            return this.Where(h => includeSet.Contains(h.ExpressTypeId));

        }

      
        /// <summary>
        /// Returns all the Geometry Handles for a specified SurfaceStyle
        /// Obtain the SurfaceStyle by calling the GetSurfaceStyles function
        /// </summary>
        /// <param name="forStyle"></param>
        public IEnumerable<XbimGeometryHandle> GetGeometryHandles(XbimSurfaceStyle forStyle)
        {
            return this.Where(gh => gh.SurfaceStyle.Equals(forStyle));
        }

        /// <summary>
        /// Returns a map of all the unique surface style and the geometry objects that the style renders
        /// </summary>
        /// <returns></returns>
        public XbimSurfaceStyleMap ToSurfaceStyleMap(Module module)
        {
            var result = new XbimSurfaceStyleMap();
            foreach (var style in GetSurfaceStyles())
            {
                result.Add(style, new XbimGeometryHandleCollection(module));
            }
            foreach (var item in this)
            {
                result[item.SurfaceStyle].Add(item);
            }
            return result;
        }
    }
}
