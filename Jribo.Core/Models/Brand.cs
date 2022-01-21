using System;
using System.Collections.Generic;

namespace Jribo.Core
{
    public class Brand
    {
        List<Product> Lst = new List<Product>();
        public string Name { get; set; }
        public List<Product> GetSetProduct

        {
           get  {  return Lst; }

            set {  Lst = value; }
        }

        public Brand()
        {

        }

        public Brand(string name)
        {
            Name = name;
        }

        public void Print()

        {
            Console.WriteLine("Brand:- " + this.Name);

            Console.WriteLine("Product Owns : ");

            foreach (Product c in this.GetSetProduct)

            {
                Console.WriteLine("Product ID:- " + c.IdProduct + "  -> Product Name:- " + c.ProductName + " ---> Product Price:- " + c.ProductPrice);
            }

        }

    }
}
