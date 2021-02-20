using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            Sale sale1 = new Sale();
            Sale sale2 = new Sale();
            Sale sale3 = new Sale();

            Seller seller1 = new Seller();
            Seller seller2 = new Seller();
            Seller seller3 = new Seller();

            p1.nameProduct = "Milk";
            p1.price = 2800;

            p2.nameProduct = "Chocolate";
            p2.price = 5500;

            p3.nameProduct = "Cookies";
            p3.price = 2000;

            seller1.name = "Antonio";
            seller1.age = 24;

            seller2.name = "Maria";
            seller2.age = 21;

            seller3.name = "Rodrigo";
            seller3.age = 38;

            sale1.sale = (p1.price + p2.price); //2800 + 5500
            sale1.comments = ("Se vendio " + p1.nameProduct +" y " + p2.nameProduct +" por " + sale1.sale);

            sale2.sale = (p2.price + p3.price + p1.price); //5500 + 2800 + 2000
            sale1.comments = ("Se vendio " + p2.nameProduct + ", " + p3.nameProduct +" y " + p1.nameProduct + " por " + sale2.sale);

            sale3.sale = (p3.price); //2000
            sale1.comments = ("Se vendio " + p3.nameProduct + " por " + sale3.sale);

            float salesTotal = sale1.sale + sale2.sale + sale3.sale;

            Console.WriteLine("El total de ventas es: " + salesTotal);

            

        }
    }
}
