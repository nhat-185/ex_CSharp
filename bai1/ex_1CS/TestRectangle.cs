class TestRectangle
{
    static void Main()
    {
        Rectangle a = new Rectangle();
        a.width = -3;
        Rectangle b = new Rectangle();
        b.height = 3;
        Rectangle rect = new Rectangle();
        rect.width = a.width;
        rect.height = b.height;
        rect.Visualize();
    }
}

