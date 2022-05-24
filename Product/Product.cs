namespace ProductClasses
{
    class Product
    {
        public string name;
        public double price;
        public double weight;

        public Product(string name, double price, double weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public void ChangePrice(double percentage)
        {
            this.price = this.price * (percentage / 100);
        }

        public override string ToString()
        {
            return $"Name: {this.name}\nPrice: {this.price}\nWeight: {this.weight}";
        }
    }

    class Meat : Product
    {
        public string category;
        public string type;
        public Meat(string name, double price, double weight, string category, string type) : base(name, price, weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
            this.category = category;
            this.type = type;
        }
    }

    class DairyProduct : Product
    {
        public int expirationDate;
        public DairyProduct(string name, double price, double weight, int expirationDate) : base(name, price, weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
            this.expirationDate = expirationDate;
        }

        public void ChangePrice(double percentage)
        {
            this.price = this.price * ((percentage - expirationDate) / 100);
        }
    }

    class Buy
    {
        public int quantity;
        public double order_total;
        public double order_weight;

        public Buy(int quantity, double order_total, double order_weight)
        {
            this.quantity = quantity;
            this.order_total = order_total;
            this.order_weight = order_weight;
        }
    }

    class Check
    {
        public void showProduct(Product p)
        {
            Console.WriteLine($"Name: {p.name}");
            Console.WriteLine($"Price: {p.price}");
            Console.WriteLine($"Weight: {p.weight}");
        }
        public void showOrder(Buy b)
        {
            Console.WriteLine($"Quantity: {b.quantity}");
            Console.WriteLine($"Total Price: {b.order_total}");
            Console.WriteLine($"Order Weight: {b.order_weight}");
        }
    }
}