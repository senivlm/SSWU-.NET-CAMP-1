using System.Collections.Generic;

namespace ProductClasses
{
    class Storage
    {
        List<Product> Products = new List<Product>();

        public static Product newProduct()
        {
            Console.Write("Name of Product: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = Double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            double weight = Double.Parse(Console.ReadLine());

            return new Product(name, price, weight);
        }
        public static Buy newOrder()
        {
            Console.Write("Quantity: ");
            int quantity = Int32.Parse(Console.ReadLine());
            Console.Write("Price: ");
            double price = Double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            double weight = Double.Parse(Console.ReadLine());

            return new Buy(quantity, price, weight);
        }
        public static Meat newMeat()
        {
            Console.Write("Name of Product: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = Double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            double weight = Double.Parse(Console.ReadLine());
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Type: ");
            string type = Console.ReadLine();

            return new Meat(name, price, weight, category, type);
        }
        public static DairyProduct newDairyProduct()
        {
            Console.Write("Name of Product: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = Double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            double weight = Double.Parse(Console.ReadLine());
            Console.Write("Expiration Date: ");
            int expirationDate = Int32.Parse(Console.ReadLine());

            return new DairyProduct(name, price, weight, expirationDate);
        }

        public void printAllProducts()
        {
            foreach (Product prod in Products)
            {
                prod.ToString();
            }
        }
        public void changePrices(double percentage)
        {
            foreach (Product prod in Products)
            {
                prod.ChangePrice(percentage);
            }
        }
    }
}
