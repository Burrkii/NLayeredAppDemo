using NorthWind.Business.Abstract;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete;
using NorthWind.DataAccess.Concrete.EntityFramework;
using NothWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Concrete.EntityFramework
{
    public class ProductManeger:IProductService
    {
        private IProductDal _productDal;

        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Cod
            //get
            //getall/
            //delete
            //update
            //add
            
            return _productDal.GetAll();
        }
    }
}
