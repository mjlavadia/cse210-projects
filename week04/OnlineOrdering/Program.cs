using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Address address1 = new Address("174 Rr 2", "Wyalusing", "Pennsylvania", "USA");
            Customer customer1 = new Customer("Linda Williams", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Book", "B001", 10.00, 2));
            order1.AddProduct(new Product("Pen", "P001", 1.50, 5));

            Address address2 = new Address("3748 Scarth St.", "Calgary", "Alberta", "Canada");
            Customer customer2 = new Customer("Liam Miller", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Notebook", "N001", 5.00, 3));
            order2.AddProduct(new Product("Pencil", "PN001", 0.75, 10));

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
            Console.WriteLine("-----------------------------");
        }
    }
}
