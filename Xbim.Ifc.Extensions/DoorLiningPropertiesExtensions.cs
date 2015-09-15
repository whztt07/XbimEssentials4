﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc.Extensions
// Filename:    DoorLiningPropertiesExtensions.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.SharedBldgElements;

#endregion

namespace Xbim.Ifc2x3.Extensions
{
    public static class DoorLiningPropertiesExtensions
    {
        /// <summary>
        ///   If the DoorLiningProperties contain a ShapeAspectStyle, returns the model whose RepresentationIdentifier equals identifier
        /// </summary>
        /// <param name = "lProps"></param>
        /// <param name = "identifier">The RepresentationIdentifier to retrieve</param>
        /// <returns></returns>
        public static IfcShapeModel GetShapeModel(this IfcDoorLiningProperties lProps, string identifier)
        {
            if (lProps.ShapeAspectStyle == null)
                return null;
            else
                return lProps.ShapeAspectStyle.ShapeRepresentations.Lookup(identifier);
        }

        //TODO: Commented out as it requires non-generic structure of the generated class. ShapeModelList is a representation specific list of entities
        ///// <summary>
        /////   if the DoorLiningProperties contain a ShapeAspectStyle, returns the the ShapeModelList
        ///// </summary>
        ///// <param name = "lProps"></param>
        ///// <returns></returns>
        //public static ShapeModelList GetShapeModels(this IfcDoorLiningProperties lProps)
        //{
        //    if (lProps.ShapeAspectStyle == null)
        //        return null;
        //    else
        //        return lProps.ShapeAspectStyle.ShapeRepresentations;
        //}
    }
}