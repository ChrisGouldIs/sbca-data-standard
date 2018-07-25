using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SBCA_DataStandard
{
    public class Vector3D
    {
        // Right hand rule, orthogonal vector
        public double DX { get; set; } = 0.0;
        public double DY { get; set; } = 0.0;
        public double DZ { get; set; } = 0.0;

        public Vector3D()
        {
            DX = DY = DZ = 0.0;
        }

        public Vector3D (double x, double y, double z)
        {
            DX = x;
            DY = y;
            DZ = z;
        }

        public Vector3D (Point3D beginPoint, Point3D endPoint)
        {
            DX = endPoint.X - beginPoint.X;
            DY = endPoint.Y - beginPoint.Y;
            DZ = endPoint.Z - beginPoint.Z;
        }

        [JsonIgnore]
        public double Magnitude
        {
            get
            {
                return Math.Sqrt(DX * DX + DY * DY + DZ * DZ);
            }
        }

        public void Normalize()
        {
            double magnitude = Magnitude;

            if (magnitude > double.Epsilon)
            {
                DX /= magnitude;
                DY /= magnitude;
                DZ /= magnitude;
            }
        }

        public static Vector3D XAxis = new Vector3D(1.0, 0.0, 0.0);
        public static Vector3D YAxis = new Vector3D(0.0, 1.0, 0.0);
        public static Vector3D ZAxis = new Vector3D(0.0, 0.0, 1.0);
    }
}
