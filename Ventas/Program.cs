using System;

namespace Ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            SellerWoman seller1 = new SellerWoman();
            seller1.Name = "Ana";
            seller1.Age = 20;

            SellerWoman seller2 = new SellerWoman();
            seller2.Name = "Luisa";
            seller2.Age = 30;

            SellerWoman seller3 = new SellerWoman();
            seller3.Name = "Juana";
            seller3.Age = 40;

            Product product1 = new Product();
            product1.Name = "Lápiz";
            product1.Cost = 1000;

            Product product2 = new Product();
            product2.Name = "Borrador";
            product2.Cost = 700;

            Product product3 = new Product();
            product3.Name = "Cuaderno";
            product3.Cost = 3000;

            Sale s1 = new Sale();
            s1.SellerWoman = seller1.Name;
            s1.Product = product2.Name;
            s1.Coment = 1;
            s1.value = product2.Cost;

            Sale s2 = new Sale();
            s2.SellerWoman = seller2.Name;
            s2.Product = product1.Name;
            s2.Coment = 0;
            s2.value = product2.Cost;

            Sale s3 = new Sale();
            s3.SellerWoman = seller3.Name;
            s3.Product = product3.Name;
            s3.Coment = 1;
            s3.value = product3.Cost;
            //¿Cuál es el valor total de las 3 ventas? $4.400

            int totalsale(Sale value1, Sale value2, Sale value3)
                {
                int salecalculation = value1.value + value2.value + value3.value;
                return salecalculation;

            }
            
            Console.WriteLine("Sales total amount: " + totalsale(s1, s2, s3));
        }
    }
}
