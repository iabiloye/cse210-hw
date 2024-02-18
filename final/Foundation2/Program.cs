using System;

namespace EncapsulationWithOnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation
            Address customerAddress = new Address("No 7. Ita Emphraim, Asari Iso.", "Calabar", "CRS", "NG");
            Customer customer = new Customer("Blessing Emmanuel Udoh", customerAddress);

            // products
            Product product1 = new Product("HP Elitebook ", "12gb/500gb", 920, 1);
            Product product2 = new Product("iphone 12 mini", "6gb/256gb", 420, 2);
            Product product3 = new Product("Laptop Bag ", "Size 12", 12, 1);
            Product product4 = new Product("Power Bank", "200,000mph", 70, 1);


            // Creating an order
            Order order = new Order(customer);
            order.Products.Add(product1);
            order.Products.Add(product2);
            order.Products.Add(product3);
            order.Products.Add(product4);

            // order information
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("\nTotal Price: $" + order.GetTotalPrice());
        }
    }
}
