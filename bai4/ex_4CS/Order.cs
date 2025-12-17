class Order
{
    public string ID;
    public List<Item> items;
    public Order(string d)
    {
        ID = d;
        items = new List<Item>();
    }
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    public static double CalculateAverageCost(List<Order> orders)
    {
        double totalGia = 0;
        int totalItems = 0;

        foreach (Order order in orders)
        {
            foreach (Item item in order.items)
            {
                totalGia += item.gia;
                totalItems++;
            }
        }

        if (totalItems == 0) return 0;
        return totalGia / totalItems;
    }
}