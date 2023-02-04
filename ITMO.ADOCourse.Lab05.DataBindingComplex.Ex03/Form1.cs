using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADOCourse.Lab05.DataBindingComplex.Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BindGridButton_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(NorthwindDataSet1.Products);
            BindingSource productsBindingSource= new BindingSource(NorthwindDataSet1, "Products");
            ProductsGrid.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
