using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Vector
    {
        // Right hand rule, orthogonal vector
        public double X { get { return TailPoint.X - OriginPoint.X; } }
        public double Y { get { return TailPoint.Y - OriginPoint.Y; } }
        public double Z { get { return TailPoint.Z - OriginPoint.Z; } }

        public Point OriginPoint { get; set; } = new Point(0.0, 0.0, 0.0);
        public Point TailPoint { get; set; } = new Point(0.0, 0.0, 0.0);

        public Vector (double x, double y, double z)
        {
            TailPoint = new Point(x, y, z);
        }

        public Vector (Point beginPoint, Point endPoint)
        {
            OriginPoint = beginPoint;
            TailPoint = endPoint;
        }

        public double Magnitude
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public void Normalize()
        {
            TailPoint.X -= OriginPoint.X;
            TailPoint.Y -= OriginPoint.Y;
            TailPoint.Z -= OriginPoint.Z;

            OriginPoint = new Point(0.0, 0.0, 0.0);

            double magnitude = Magnitude;

            if (magnitude > double.Epsilon)
            {
                TailPoint.X /= magnitude;
                TailPoint.Y /= magnitude;
                TailPoint.Z /= magnitude;
            }
        }

        public static Vector XAxis = new Vector(1.0, 0.0, 0.0);
        public static Vector YAxis = new Vector(0.0, 1.0, 0.0);
        public static Vector ZAxis = new Vector(0.0, 0.0, 1.0);
    }
}
