using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //sellers 

            Seller seller1 = new Seller();
            seller1.Name = "Juan";
            seller1.Age = 35;

            Seller seller2 = new Seller();
            seller2.Name = "Carlos";
            seller2.Age = 28;

            Seller seller3 = new Seller();
            seller3.Name = "Andres";
            seller3.Age = 45;

            //Products

            Product product1 = new Product();
            product1.Name = "Mouse";
            product1.Price = 25000d;

            Product product2 = new Product();
            product2.Name = "keyboard";
            product2.Price = 34000d;

            Product product3 = new Product();
            product3.Name = "monitor";
            product3.Price = 290000d;

            //sales

            Sale sale1 = new Sale();
            sale1.Product = product1;
            sale1.Seller = seller1;
            sale1.Comments = "without discount";

            Sale sale2 = new Sale();
            sale2.Product = product2;
            sale2.Seller = seller2;
            sale2.Comments = "without discount";

            Sale sale3 = new Sale();
            sale3.Product = product3;
            sale3.Seller = seller3;
            sale3.Comments = "without discount";

            double total = sale1.Product.Price + sale2.Product.Price + sale3.Product.Price;

            System.Console.WriteLine("Sales total amount: " + total);

            System.Console.WriteLine("sales made by:\n" + sale1.Seller.Name + "\n" + sale2.Seller.Name + "\n" + sale3.Seller.Name);


        }
    }
}
