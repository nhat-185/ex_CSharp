
class Particle
{
    public int X { get; set; }
    public int Y { get; set; }

    public Particle(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int maxWidth, int maxHeight)
    // Di chuye n hạt ngẫu nhiên trong phạm vi của hộp
    {
        Random random = new Random();
        X += random.Next(-1, 2);
        Y += random.Next(-1, 2);

        if (X < 0) X = 0;
        if (Y < 0) Y = 0;
        if (X >= maxWidth) X = maxWidth - 1;
        if (Y >= maxHeight) Y = maxHeight - 1;
    }
}