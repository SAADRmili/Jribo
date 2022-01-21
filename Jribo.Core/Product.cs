using System;

namespace Jribo.Core
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Brand brand { get; set; }

        public Product()
        {

        }

        public Product(int idProduct, string productName, double productPrice,Brand  Brand)
        {
            IdProduct = idProduct;
            ProductName = productName;
            ProductPrice = productPrice;
            brand = Brand;
        }

        public override string ToString()
        {
            return " Product ID:- " + IdProduct + "  -> Product Name:- " +ProductName + " ---> Product Price:- " + ProductPrice +" Brand: --> "+brand.Name;
        }
    }

}
