class Triangle 
{
    private Point2D p1;
    private Point2D p2;
    private Point2D p3;

    public Triangle(Point2D a, Point2D b, Point2D c)
    {
        p1 = a;
        p2 = b;
        p3 = c;
    }

    public double Perimeter()  // chu vi
    {
        double a = p1.Distance(p2);
        double b = p2.Distance(p3);
        double c = p3.Distance(p1);
        return a + b + c;
    }

    public double Area() // dien tich
    {
        double a = p1.Distance(p2);
        double b = p2.Distance(p3);
        double c = p3.Distance(p1);
        double s = (a + b + c) / 2; 
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // heron
    }

    public void DisplayPoints() 
    {
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}