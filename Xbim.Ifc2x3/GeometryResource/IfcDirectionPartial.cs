﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common.Geometry;

namespace Xbim.Ifc2x3.GeometryResource
{

    public partial class IfcDirection
    {

        public double X
        {
            get
            {
                return DirectionRatios.Count == 0 ? double.NaN : DirectionRatios[0];
            }
            set
            {
                if(DirectionRatios.Count == 0)
                    DirectionRatios.Add(value);
                else
                    DirectionRatios[0] = value;
            }
        }

        public double Y
        {
            get
            {
                return DirectionRatios.Count < 2 ? double.NaN : DirectionRatios[1];
            }
            set
            {
                if (DirectionRatios.Count < 2)
                {
                    if (DirectionRatios.Count == 0) DirectionRatios.Add(double.NaN);
                    DirectionRatios.Add(value);
                }
                else
                    DirectionRatios[1] = value;
            }
        }

        public double Z
        {
            get
            {
                return DirectionRatios.Count < 3 ? double.NaN : DirectionRatios[2];
            }
            set
            {
                if (DirectionRatios.Count < 3)
                {
                    if (DirectionRatios.Count == 0) DirectionRatios.Add(double.NaN);
                    if (DirectionRatios.Count == 1) DirectionRatios.Add(double.NaN);
                    DirectionRatios.Add(value);
                }
                else
                    DirectionRatios[2] = value;
            }
        }
        public XbimVector3D XbimVector3D()
        {
            return new XbimVector3D(X, Y, double.IsNaN(Z) ? 0 : Z);
        }

        public int Dim { get { return DirectionRatios.Count; } }

        public XbimVector3D Normalise()
        {
            if (Dim == 3)
            {
                var v3D = new XbimVector3D(X, Y, Z);
                v3D.Normalize();
                return v3D;
            }
                throw new ArgumentException("Only 3D Directions are supported for normalised at present");
        }
    }
}
