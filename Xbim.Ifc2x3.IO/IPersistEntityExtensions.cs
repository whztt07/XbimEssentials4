using System;
using System.Collections.Generic;
using System.IO;
using Xbim.IO.Parser;
using Xbim.Common.Exceptions;
using System.Collections.Specialized;
using Xbim.Common;
using Xbim.Common.Metadata;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.IO.Esent;
using Xbim.IO.Step21;
using Xbim.IO.Step21.Parser;

namespace Xbim.IO
{
    public static class PersistEntityExtensions
    {
       

        #region Write the properties of an IPersistEntity to a stream

        /// <summary>
        /// Returns the index value of this type for use in Xbim database storage
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static short ExpressTypeId(this  IPersist entity)
        {
            return ExpressMetaData.ExpressTypeId(entity);
        }

        /// <summary>
        /// Returns the Xbim meta data about the Ifc Properties of the Type
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static ExpressType ExpressType(this  IPersist entity)
        {
            return ExpressMetaData.ExpressType(entity);
        }

        public static StringCollection SummaryString(this IPersistEntity entity)
        {
            var sc = new StringCollection {"Entity\t = #" + entity.EntityLabel};
            if (!(entity is IfcRoot)) return sc;

            var root = (IfcRoot) entity;
            sc.Add("Guid\t = " + root.GlobalId);
            sc.Add("Type\t = " + root.GetType().Name);
            sc.Add("Name\t = " + (root.Name.HasValue ? root.Name.Value.ToString() : root.ToString()));
            return sc;
        }

        #endregion

       

        
    }
}
