using NothWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
