using System;

namespace Xbim.IO
{
    //todo: Rename to be schema independent (just Step21, Xml, ...)
    [Flags]
    public enum XbimStorageType
    {
        /// <summary>
        /// Invalid Xbim storage type
        /// </summary>
        INVALID = 0,

        /// <summary>
        ///   IFC in XML format
        /// </summary>
        IFCXML = 1,

        /// <summary>
        ///   Native IFC format
        /// </summary>
        IFC = 2,

        /// <summary>
        ///   compressed IFC format
        /// </summary>
        IFCZIP = 4,

        // IFCXMLX = 8,
        /// <summary>
        ///   Compressed IfcXml
        /// </summary>
        /// <summary>
        ///   Xbim binary format
        /// </summary>
        XBIM = 16
    }
}
