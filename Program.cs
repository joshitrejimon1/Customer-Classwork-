using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(1, "Joshit");
        Customer customer2 = new Customer(2, "Albin");

        Product product1 = new Product(101, "Product A", 10.0, 5.0);
        Product product2 = new Product(102, "Product B", 20.0, 10.0);

        LineItem lineItem1 = new LineItem(1, 3, product1);
        LineItem lineItem2 = new LineItem(2, 2, product2);

        Order order1 = new Order(1001, DateTime.Now);
        order1.AddLineItem(lineItem1);

        Order order2 = new Order(1002, DateTime.Now);
        order2.AddLineItem(lineItem2);

        customer1.AddOrder(order1);
        customer2.AddOrder(order2);

        Console.WriteLine("Customer 1:");
        foreach (var order in customer1.Orders)
        {
            Console.WriteLine($"Order ID: {order.Id}, Order Date: {order.Date}");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"Line Item ID: {item.Id}, Product: {item.Product.Name}, Quantity: {item.Quantity}, Total Cost: {item.CalculateLineItemCost():C}");
            }
            Console.WriteLine($"Total Order Cost: {order.CalculateOrderPrice():C}");
        }

        Console.WriteLine("Customer 2:");
        foreach (var order in customer2.Orders)
        {
            Console.WriteLine($"Order ID: {order.Id}, Order Date: {order.Date}");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"Line Item ID: {item.Id}, Product: {item.Product.Name}, Quantity: {item.Quantity}, Total Cost: {item.CalculateLineItemCost():C}");
            }
            Console.WriteLine($"Total Order Cost: {order.CalculateOrderPrice():C}");
        }
    }
}
