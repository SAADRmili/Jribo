using System;
using Xunit;
using AutoFixture;
using Jribo.Core;

namespace Jribo.Test
{
    public class BrandTests
    {
        private Fixture fixture;
        private BrandRepo brandrepo;
        public BrandTests()
        {
            fixture = new Fixture();
            brandrepo = new BrandRepo();


        }
       
        [Fact]
        public void TestIfBrandValid()
        {
            var brand = new Brand()
            {
                Name =""
            };


            var act = brandrepo.Save(brand);


            Assert.False(act);
        }

    }
}
