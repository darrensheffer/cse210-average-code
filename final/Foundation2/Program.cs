using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new();
        Order order;

        Console.Clear();
        order = new("John", "555 N Main St,Richmond,VI,USA");
        order.AddProduct("Eggs", "4624", 6.00, 2);
        order.AddProduct("Bacon", "L59A", 8.00, 3);
        order.AddProduct("Pancake Mix", "2851", 16.00, 1);
        orders.Add(order);

        order = new("Jane", "Kossuth Lajos tér 1-3,Budapest,1011,Hungary");
        order.AddProduct("Pencil", "737B", .25, 2);
        order.AddProduct("Notebook", "P24", .50, 6);
        order.AddProduct("Ruler", "R12", .10, 5);
        orders.Add(order);

        order = new("Doe", "50 N W Temple St,Salt Lake City,UT,USA");
        order.AddProduct("Book of Mormon", "777", 15.00, 2);
        order.AddProduct("White Shoe Covers", "C2F", .10, 10);
        orders.Add(order);

        int orderCount = 1;
        foreach (Order o in orders)
        {
            double total = o.GetTotal();
            Console.WriteLine($"Order{orderCount} Total Cost: ${total}");
            o.DisplayPackagingLabel();
            o.DisplayShippingLabel();
            
            Console.WriteLine("");
            orderCount ++;
        }
    }
}