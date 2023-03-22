using System;

class Program
{
    static void Main(string[] args)
    {
        //-----Customer 1-----
        Console.Clear();
        Order order1 = new Order();
        order1.GetCustomerInfo("Jon Smiff", "5435 Somewhere Ave", "Las Vegas", "Nevada", "USA");
        order1.AddProduct("Wood", "WD2B4", 20, 9);
        order1.AddProduct("Nails", "HW737", 7.65, 5);
        order1.AddProduct("Hammer", "TL115", 15, 1);
        Console.WriteLine("Order #1");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();
        order1.GetTotal();
        Console.WriteLine("-------------------------------------"); // Separates orders in console

        //-----Customer 2-----
        Order order2 = new Order();
        order2.GetCustomerInfo("Jayne Dough", "6425 Street Ave", "Stokeinteignhead", "Devon", "England");
        order2.AddProduct("Cement", "CM458", 10.65, 20);
        order2.AddProduct("Border Wood", "WD1B10", 5.70, 10);
        order2.AddProduct("Wheelbarrow", "WB001", 42.50, 1);
        Console.WriteLine("Order #2");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();
        order2.GetTotal();
        Console.WriteLine();
    }
}