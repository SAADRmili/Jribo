using System;
using System.Threading;

namespace Jribo.Core
{
    public class Product
    {
        private static int _counter;
        public int IdProduct { get; private set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }

        public Brand brand { get; set; }

        public Product()
        {
            IdProduct = Interlocked.Increment(ref _counter); 
        }
        public  bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(ProductName))
            {
                isValid = false;
            }
            if (ProductPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }


        public Product(string productName, double productPrice,Brand  Brand)
        {
            IdProduct = Interlocked.Increment(ref _counter); 
            ProductName = productName;
            ProductPrice = productPrice;
            brand = Brand;
        }

        public override string ToString()
        {
            return " Product ID:- " + IdProduct + "\n  -> Product Name:- " +ProductName + " ---> Product Price:- " + ProductPrice +" Brand: --> "+brand.Name;
        }
    }

}
