namespace EncapsulationWithOnlineOrdering
{
    public class Product
    {
        private string name;
        private string productId;
        private decimal price;
        private int quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
