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
                addlist.Add(new Product(i+1, RandomStrings.RandomString(10), random.NextDouble(),brands[i]));
            }
            return addlist;
        }
    }
}
