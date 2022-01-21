using Jribo.Core;
using System;
using System.Collections.Generic;

namespace Jribo.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> List = new List<Product>();


            ProductsService productsService = new ProductsService();

            List = productsService.Data();

           var d =  productsService.RemoveProduct(List, 1);

            Console.WriteLine("deleted is --> "+d);
            
            //Product a = new Product();

            //a.ProductName = "Alto";

            //Product b = new Product();

            //b.ProductName = "Namo";

            //List.Add(a);

            //List.Add(b);




            Brand p = new Brand();

            p.Name = "sourav";

            p.GetSetProduct = List;

            p.Print();



            Console.ReadLine();
        }
    }
}
