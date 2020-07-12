using System;

namespace Point3D_ImplementGetEnumerator
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            //Declare few points of 3D space.
            Point3D firstPoint = new Point3D() { X = 1, Y = 2, Z = 3 };
            Point3D secondPoint = new Point3D() { X = 22, Y = 44, Z = 55 };

            //Add point to collection.
            CollectionOfPoint3D points = new CollectionOfPoint3D();
            points.AddPoint(firstPoint);
            points.AddPoint(secondPoint);
            points.AddPoint(Point3D.StartCoordinate);
            points.AddPoint(new Point3D { X = 3, Y = 3, Z = 3 });

            //Use implemented GetEnumerator() in foreach loop.
            foreach (var currentPoint in points)
            {
                Console.WriteLine(currentPoint);
            }
        }
    }
}
