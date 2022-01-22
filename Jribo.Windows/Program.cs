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
            BrandRepo brandRepo = new BrandRepo();

            var brands = brandRepo.GetBrands();


            List<Product> List = new List<Product>();
            ProductsService productsService = new ProductsService(List);


            productsService.addProduct(RandomStrings.RandomString(10), 3000, brands[2]);
            productsService.addProduct(RandomStrings.RandomString(10), 3000, brands[2]);
            productsService.addProduct(RandomStrings.RandomString(10), 3000, brands[2]);



            foreach (var item in List)
            {
                Console.WriteLine(item.ToString());
            }


            
            var brand = productsService.getBrandByProduct(List, List[1]);
            brand = productsService.getBrandByProduct(List, List[2]);

           

            brand.Print();






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
