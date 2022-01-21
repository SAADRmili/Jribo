using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jribo.Core
{
  public class ProductRepo
    {

        public List<Product> GetProducts( List<Brand> brands)
        {
            Random random = new Random();
            var addlist = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                addlist.Add(new Product( RandomStrings.RandomString(10), random.NextDouble(),brands[i]));
            }
            return addlist;
        }


        public Product NewProduct(int id)
        {
            Product product = new Product();

            if (id == 2)
            {
                product.IdProduct = id;
                product.ProductName = "PS5";
              
                product.ProductPrice = 500.39;
            }
            return product;
        }
    }


}
