class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("John Doe", "123 Main St", "Computer Science", 2, 15000);
        Staff staff = new Staff("Jane Smith", "456 Elm St", "Engineering", 60000);
        Console.WriteLine(student.ToString());
        Console.WriteLine(staff.ToString());
    }
}