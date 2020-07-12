namespace Point3D_ImplementGetEnumerator
{
    public struct Point3D
    {
        private static readonly Point3D startCoordinate;
        private double x;
        private double y;
        private double z;

        public static Point3D StartCoordinate
        {
            get
            {
                return startCoordinate;
            }
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        static Point3D()
        {
            startCoordinate = new Point3D() { X = 0, Y = 0, Z = 0 };
        }
        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("X:{0} Y:{1} Z:{2}", X, Y, Z);

            return result;
        }
    }
}
