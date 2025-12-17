using System;
using System.Collections.Generic;
class Item
{
    private string ID;
    private string Ten;
    private double Gia;
    public string id
    {
        get { return ID; }
        set { ID = value; }
    }
    public string ten
    {
        get { return Ten; }
        set { Ten = value; }
    }
    public double gia
    {
        get { return Gia; }
        set
        {
            if (value < 0) Console.WriteLine("No match");
            else Gia = value;
        }
    }
    public Item(string a, string b, double c)
    {
        ID = a;
        Ten = b;
        Gia = c;
    }
}