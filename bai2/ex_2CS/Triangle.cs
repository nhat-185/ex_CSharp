using System;
class Triangle
{
    private int Canh1;
    private int Canh2;
    private int Canh3;
    public int Canh_1
    {
        get { return Canh1; }
        set
        {
            if (value > 0) Canh1 = value;
            else
            {
                Console.WriteLine("Input is error");
            }
        }
    }
    public int Canh_2
    {
        get { return Canh2; }
        set
        {
            if (value > 0) Canh2 = value;
            else
            {
                Console.WriteLine("Input is error");
            }
        }
    }
    public int Canh_3
    {
        get { return Canh3; }
        set
        {
            if (value > 0) Canh3 = value;
            else
            {
                Console.WriteLine("Input is error");
            }
        }
    }
    public void Verify()
    {
        if (Canh1 + Canh2 > Canh3 && Canh1 + Canh3 > Canh2 && Canh2 + Canh3 > Canh1)
        {
            if (Canh1 == Canh2 && Canh2 == Canh3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (Canh1 == Canh2 || Canh1 == Canh3 || Canh2 == Canh3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else if (Canh1 * Canh1 + Canh2 * Canh2 == Canh3 * Canh3 ||
                     Canh1 * Canh1 + Canh3 * Canh3 == Canh2 * Canh2 ||
                     Canh2 * Canh2 + Canh3 * Canh3 == Canh1 * Canh1)
            {
                Console.WriteLine("Scalene Triangle");
            }
            else
            {
                Console.WriteLine("Normal Triangle");
            }
        }
        else         {
            Console.WriteLine("Not Triangle");
        }
    }
}