using Jribo.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace Jribo.Test
{
    public class ProductsTests
    {
        private ProductsService productService ;
        private BrandRepo brandrepo ;
        private ProductRepo productRepo;


        public ProductsTests()
        {
             productService = new ProductsService();
             brandrepo = new BrandRepo();
             productRepo = new ProductRepo();
        }


        [Fact]
        public void TestANewProduct()
        {
            //arrnge

            var brands = brandrepo.GetBrands();

            var expected = new Product("dsdsd",200,brands[1]);
            //act 

            var act = productRepo.NewProduct(1);


            //assert 
            Assert.Equal(expected.ProductName, act.ProductName);

        }


        [Fact] 
        public void TestValidationAddProduct()
        {
            //arrnge

            var brands = brandrepo.GetBrands();

            var product = new Product() {

                ProductName = "",
                ProductPrice = null,
                brand = brands[1]
            };
            //act 

            var act = productService.Save(product);


            //assert 
            Assert.False(act);
        }

        [Fact]

        public void TestRemoveProduct()
        {
            //arrange 
            var brands = brandrepo.GetBrands();
            List<Product> products = productService.Data(brands);

            //act 
            var act = productService.RemoveProduct(products, 1);


            Assert.True(act);

        }


        [Fact]
        public void TestGetProductByID()
        {
            //arrange 
            var brands = brandrepo.GetBrands();
            List<Product> products = productService.Data(brands);

            var expacted = products[0];
            //act 
            var act = productService.getProductById(products, 1);


            Assert.Equal(expacted, act) ;

        }


        [Fact]
        public void TestGetProductByBrand()
        {
            //arrange 
            var brands = brandrepo.GetBrands();
            List<Product> products = productService.Data(brands);

            var expacted = products[0];
            //act 
            var act = productService.getProductByBrand(products, brands[0]);


            Assert.Equal(expacted, act);

        }


    }
}
