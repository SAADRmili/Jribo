using Jribo.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jribo.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> List = new List<Product>();

            BrandRepo brandRepo = new BrandRepo();

            var brands = brandRepo.GetBrands();


            ProductsService productsService = new ProductsService();

            List = productsService.Data(brands);


            foreach (var item in List)
            {
                Console.WriteLine(item.ToString());
            }


            //Product a = new Product();

            //a.ProductName = "Alto";

            //Product b = new Product();

            //b.ProductName = "Namo";

            //List.Add(a);

            //List.Add(b);


         

          

           



            Console.ReadLine();
        }
    }
}
