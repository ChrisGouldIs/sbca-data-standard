using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Point3D
    {
        // Right hand rule, orthogonal coordinates
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;
        public double Z { get; set; } = 0.0;

        public Point3D (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D Origin = new Point3D(0.0, 0.0, 0.0);
    }
}
