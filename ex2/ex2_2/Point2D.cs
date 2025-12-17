using System;

class Point2D
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point2D()
    {
        X = 0;
        Y = 0;
    }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point2D(Point2D p)
    {
        X = p.X;
        Y = p.Y;
    }

    public void Input()
    {
        Console.WriteLine("Asking user to change values for p1!");
        Console.Write("Enter X: ");
        X = int.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        Y = int.Parse(Console.ReadLine());
    }

    public void Move(int newX, int newY)
    {
        X = newX;
        Y = newY;
    }

    public override string ToString()
    {
        return $"({X},{Y})";
    }

    public bool IsOrigin()
    {
        return X == 0 && Y == 0;
    }

    public double Distance(Point2D p)
    {
        int dx = X - p.X;
        int dy = Y - p.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    public static double Distance(Point2D p1, Point2D p2)
    {
        int dx = p1.X - p2.X;
        int dy = p1.Y - p2.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}