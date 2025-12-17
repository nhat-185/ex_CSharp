class Program
{
    static void Main(string[] args)
    {
        Point2D p1 = new Point2D();
        Point2D p2 = new Point2D(4, 7);        
        Point2D p3 = new Point2D(p2);            

        Console.WriteLine("The initial value of p1: " + p1);
        Console.WriteLine("Is p1 at the origin?: " + p1.IsOrigin().ToString().ToLower());

        p1.Input(); 

        Console.WriteLine("The new value of p1: " + p1);
        Console.WriteLine("The value of p2: " + p2);
        Console.WriteLine("The value of p3: " + p3);

        Console.WriteLine("First way to calculate distance between p1 and p2: " + p1.Distance(p2).ToString("0.00"));
        Console.WriteLine("Second way to calculate distance between p1 and p2: " + Point2D.Distance(p1, p2).ToString("0.00"));

        Console.WriteLine("First way to calculate distance between p2 and p3: " + p2.Distance(p3).ToString("0.00"));
        Console.WriteLine("Second way to calculate distance between p2 and p3: " + Point2D.Distance(p2, p3).ToString("0.00"));
    }
}