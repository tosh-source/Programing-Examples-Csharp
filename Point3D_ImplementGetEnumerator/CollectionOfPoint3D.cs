using System.Collections;
using System.Collections.Generic;

namespace Point3D_ImplementGetEnumerator
{
    class CollectionOfPoint3D
    {
        private ICollection<Point3D> points;

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public CollectionOfPoint3D()
        {
            this.points = new List<Point3D>();
        }

        //Implement IEnumerable interface **
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this.points.GetEnumerator();
        }
    }
}
//** link-> https://support.microsoft.com/en-us/help/322022/how-to-make-a-visual-c-class-usable-in-a-foreach-statement
