using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jribo.Core
{
    public class ProductsService
    {
        List<Brand> brands; 
        public ProductsService()
        {
            
        }
        private ProductRepo repo = new ProductRepo();
        private List<Product> List = new List<Product>();

       
        public Product addProduct(string name , double price)
        {
            Product a = new Product();
            a.IdProduct = 1;
            a.ProductName =name;
            a.ProductPrice = price;
            List.Add(a);
            return a; 
        }


        public Product getProductById(List<Product> List, int id)
        {
            foreach (var item in List)
            {
                if (item.IdProduct == id) return item;

            }
            return null;
        }

        public bool RemoveProduct (List<Product> List,int id)
        {
            foreach (var item in List)
            {
                if (item.IdProduct == id)
                {
                    List.Remove(item);
                    return true;
                }

            }
            return false;
        }

        public double AddPromo(List<Product> List, int id, double promo)
        {
            double newPrice = 0; 
            foreach (var item in List)
            {
                if (item.IdProduct == id)
                {
                    newPrice = item.ProductPrice - (promo * item.ProductPrice);
                }

            }
            return newPrice;
        }
        public List<Product> Data(List<Brand> brands)
        {
            List = repo.GetProducts( brands);
            return List;
        }

    }
}
