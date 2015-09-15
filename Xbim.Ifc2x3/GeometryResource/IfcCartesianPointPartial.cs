using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common;
using Xbim.Ifc2x3.MeasureResource;

namespace Xbim.Ifc2x3.GeometryResource
{
    public partial class IfcCartesianPoint
    {
        public double X
        {
            get
            {
                return Coordinates.Count == 0 ? double.NaN : (double)Coordinates[0];
            }
            set
            {
                if (Coordinates.Count == 0)
                    Coordinates.Add(value);
                else
                    Coordinates[0] = value;
            }
        }

        public double Y
        {
            get
            {
                return Coordinates.Count < 2 ? double.NaN : (double)Coordinates[1];
            }
            set
            {
                if (Coordinates.Count < 2)
                {
                    if (Coordinates.Count == 0) Coordinates.Add(0);
                    Coordinates.Add(value);
                }
                else
                    Coordinates[1] = value;
            }
        }

        public double Z
        {
            get
            {
                return Coordinates.Count < 3 ? double.NaN : (double)Coordinates[2];
            }
            set
            {
                if (Coordinates.Count < 3)
                {
                    if (Coordinates.Count == 0) Coordinates.Add(0);
                    if (Coordinates.Count == 1) Coordinates.Add(0);
                    Coordinates.Add(value);
                }
                else
                    Coordinates[2] = value;
            }
        }

        public void SetXY(double x, double y)
        {
            Coordinates = new ItemSet<IfcLengthMeasure>(Model, new []
            {
                new IfcLengthMeasure(x), 
                new IfcLengthMeasure(y)
            });
        }

        public void SetXYZ(double x, double y, double z)
        {
            Coordinates = new ItemSet<IfcLengthMeasure>(Model, new[]
            {
                new IfcLengthMeasure(x), 
                new IfcLengthMeasure(y),
                new IfcLengthMeasure(z)
            });
        }
    }
}
