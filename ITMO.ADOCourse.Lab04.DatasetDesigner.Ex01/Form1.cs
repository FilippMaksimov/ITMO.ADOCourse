using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADOCourse.Lab04.DatasetDesigner.Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items != null)
            {
                CustomersListBox.Items.Clear();
            }
            NorthwindDataSet northwindDataSet1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            foreach (NorthwindDataSet.CustomersRow customersRow in northwindDataSet1.Customers.Rows)
            {
                CustomersListBox.Items.Add(customersRow.CompanyName);
            }
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items != null)
            {
                CustomersListBox.Items.Clear();
            }
            NorthwindDataSet northwindDataSet1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.OrdersTableAdapter orders = new NorthwindDataSetTableAdapters.OrdersTableAdapter();
            orders.Fill(northwindDataSet1.Orders);
            foreach (NorthwindDataSet.OrdersRow ordersRow in northwindDataSet1.Orders.Rows)
            {
                CustomersListBox.Items.Add(ordersRow.OrderID + " " + ordersRow.CustomerID + " " + ordersRow.OrderDate.ToShortDateString());
            }
        }
    }
}
