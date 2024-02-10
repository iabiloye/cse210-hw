using System;
using System.Collections.Generic;

namespace EncapsulationWithOnlineOrdering
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.products = new List<Product>();
            this.customer = customer;
        }

        public List<Product> Products
        {
            get { return products; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string label = $"Packing Label:\nCustomer: {customer.Name}\nAddress: {customer.Address}\nProducts:\n";
            foreach (var product in products)
            {
                label += $"{product.Name} - {product.Quantity}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\nCustomer: {customer.Name}\nAddress: {customer.Address}";
        }
    }
}
