using NothWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthWind.DataAccess.Abstract;

namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {

            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.ToList();
            }



        }
        public Product Get(int id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductID == id);
            }

        }
        public void Add(Product product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {

        }
    }
}
