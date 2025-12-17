using System;
class Rectangle
{
    public double Width;
    public double Height;
    public double width
    {
        get { return Width; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Warning: Input width is negative");
                Width = 1;
            }
            else Width = value;
        }
    }
    public double height
    {
        get { return Height; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Warning: Input height is negative");
                Height = 1;
            }
            else Height = value;
        }
    }
    public void Visualize()
    {
        for (int i = 0; i < Height; i++)
        {
            System.Console.WriteLine(new string('*', (int)Width));
        }
    }
}