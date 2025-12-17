using System;
class Person
{
    public string name { get; private set; }
    public string address { get; private set; }
    protected Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public override string ToString()
    {
        return $"Name: {name}, Address: {address}";
    }
}