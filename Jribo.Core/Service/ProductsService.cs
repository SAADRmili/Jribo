using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Jribo.Core
{
    public class ProductsService
    {
        private List<Product> List;
        private ProductRepo repo = new ProductRepo();


        public ProductsService()
        {
                
        }
        public ProductsService(List<Product> l)
        {
            List = l; 
        }
      
        public Product addProduct(string name , double price,Brand brand)
        {
            Product a = new Product(name, price, brand);
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


        public Product getProductByBrand(List<Product> list , Brand brand)
        {
            foreach (var item in List)
            {
                if (item.brand == brand) return item;

            }
            return null;
        }



        public Brand getBrandByProduct(List<Product> list, Product p)
        {
            foreach (var item in List)
            {
                if (item == p)
                {

                    item.brand.GetSetProduct.Add(p);
                    return item.brand;
                        }

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
                    newPrice = (double)(item.ProductPrice - (promo * item.ProductPrice));
                }

            }
            return newPrice;
        }
        public List<Product> Data(List<Brand> brands)
        {
            List = repo.GetProducts(brands);
            return List;
        }


        public bool Save (Product p)
        {
            var success = true; 
            if(!p.Validate())
            {
                success = false;
            }

            return success;
        }

    }
}
