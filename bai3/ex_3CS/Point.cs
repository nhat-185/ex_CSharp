using System;

class Point
{
    private double x;
    private double y;

    public Point(double a, double b)
    {
        x = a;
        y = b;
    }

    public void Distance(Point target)
    {
        double dx = x - target.x;
        double dy = y - target.y;
        Console.WriteLine("The distance between X and Y is: " + (Math.Sqrt(dx * dx + dy * dy)).ToString("F2"));
    }
}
