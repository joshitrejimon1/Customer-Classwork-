
using System.Collections.Generic;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
        Orders = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }
}
