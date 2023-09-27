using NorthWind.Business.Abstract;
using NorthWind.Business.Concrete;
using NorthWind.Business.Concrete.EntityFramework;
using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IProductService _productService = new ProductManeger(new EfProductDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            
            DgwProduct.DataSource = _productService.GetAll() ;
        }
    }
}
