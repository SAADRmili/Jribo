using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jribo.Core
{
   
    public class BrandRepo
    {

       
        public List<Brand> GetBrands()
        {
            
            var addList = new List<Brand>();
            var guid = Guid.NewGuid();
            for (int i = 0; i < 10; i++)
            {
                addList.Add(new Brand(RandomStrings.RandomString(10)));
            }

            return addList;
        }
    }
}
