using System;
class Program2_2
{
    static void Main(string[] args)
    {
        Point2D A = new Point2D(0, 0);
        Point2D B = new Point2D(2, 7);
        Point2D C = new Point2D(3, 4);

        Triangle myTriangle = new Triangle(A, B, C);

        myTriangle.DisplayPoints();

        Console.WriteLine("The perimeter is " + myTriangle.Perimeter().ToString("0.00"));
        Console.WriteLine("The area is " + myTriangle.Area().ToString("0.00"));
    }
}