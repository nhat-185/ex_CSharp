class Program4
{
    static void Main(string[] args)
    {
        Item nhap1 = new Item("0001", "Book", 500); 
        Item nhap2 = new Item("0002", "Fan", 800);
        Item nhap3 = new Item("0003", "Pen", 100);
        Order orders1 = new Order(nhap1.id);
        Order orders2 = new Order(nhap2.id);
        Order orders3 = new Order(nhap3.id);
        orders3.AddItem(nhap3);
        orders1.AddItem(nhap1);
        orders2.AddItem(nhap2);
        Console.WriteLine($"ID: {nhap1.id}, Ten: {nhap1.ten}, Gia: {nhap1.gia}");
        Console.WriteLine($"ID: {nhap2.id}, Ten: {nhap2.ten}, Gia: {nhap2.gia}");
        Console.WriteLine($"ID: {nhap3.id}, Ten: {nhap3.ten}, Gia: {nhap3.gia}");
        double avgAll = Order.CalculateAverageCost(new List<Order> { orders1, orders2, orders3});
        Console.WriteLine($"Trung binh gia cua tat ca san pham trong: {avgAll.ToString("F2")}");
    }
}