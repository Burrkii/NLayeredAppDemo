using NothWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


    }
}
