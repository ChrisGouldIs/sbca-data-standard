using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Point
    {
        // Right hand rule, orthogonal coordinates
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;
        public double Z { get; set; } = 0.0;

        public Point (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
