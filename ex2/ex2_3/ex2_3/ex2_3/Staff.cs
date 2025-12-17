class Staff : Person
{
    public string school { get; private set; }
    public double pay { get; private set; }
    public Staff(string name, string address, string school, double pay) : base(name, address)
    {
        this.school = school;
        this.pay = pay;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Department: {school}, Position: {pay}";
    }
}