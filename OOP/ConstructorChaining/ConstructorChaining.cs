using System;

class ConstructorChaining
{
    static void Main(string[] args)
    {
        //Reusing constructors (chaining)
        Point p1 = new Point(3, 3);
        Point p2 = new Point(1, 4);

        Point res = new Point();
        res = Point.add(p1, p2);

        Console.WriteLine(res.ToString());
    }
}

class Point
{
    private int xCoord;
    private int yCoord;

    public Point() : this(0, 0)
    {

    }

    public Point(int xCoord, int yCoord)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }

    public static Point add(Point first, Point second)
    {
        Point result = new Point();

        result.xCoord = first.xCoord + second.xCoord;
        result.yCoord = first.yCoord + second.yCoord;

        return result;
    }

    public override string ToString()
    {
        string resultAsString = null;

        resultAsString = string.Format("The sum of calculated coordinate is: X={0}, Y={1}", xCoord, yCoord);

        return resultAsString;
    }
}
