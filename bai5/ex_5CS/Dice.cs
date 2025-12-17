using System;

class Dice
{
    private static Random r = new Random();
    public int Roll()
    {
        return r.Next(1, 7);
    }
}
