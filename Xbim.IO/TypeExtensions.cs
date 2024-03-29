﻿using System;
using Xbim.Common;

namespace Xbim.IO
{
    public static class TypeExtensions
    {
        internal static Type GetItemTypeFromGenericType(this Type genericType)
        {
            while (true)
            {
                //if (genericType == typeof (ICoordinateList))
                //    return typeof (IfcLengthMeasure); //special case for coordinates
                if (genericType.IsGenericType || genericType.IsInterface)
                {
                    var genericTypes = genericType.GetGenericArguments();
                    return genericTypes.GetUpperBound(0) >= 0 ? genericTypes[genericTypes.GetUpperBound(0)] : null;
                }
                if (genericType.BaseType == null) return null;
                genericType = genericType.BaseType;
            }
        }

        internal static short? ExpressTypeId(this Type type)
        {
            return ExpressMetaData.ExpressTypeId(type);
        }
    }
}
