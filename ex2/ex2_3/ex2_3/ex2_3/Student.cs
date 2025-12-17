class Student : Person
{
    public string program { get; private set; }
    public int year { get; private set; }
    public double fee { get; private set; }
    public Student(string name, string address, string program, int year, double fee) : base(name, address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Program: {program}, Year: {year}, Fee: {fee}";
    }
}