using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jribo.Core
{
  public class ProductRepo
    {

        public List<Product> GetProducts()
        {
            Random random = new Random();
            Guid guid = Guid.NewGuid();
            var addlist = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                addlist.Add(new Product(i, guid.ToString(), random.NextDouble()));
            }
            return addlist;
        }
    }
}
