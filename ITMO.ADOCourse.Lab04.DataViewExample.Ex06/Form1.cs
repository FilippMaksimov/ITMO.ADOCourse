using ITMO.ADOCourse.Lab04.DataViewExample.Ex06.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADOCourse.Lab04.DataViewExample.Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView customersDataView;
        DataView ordersDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            CustomersGrid.DataSource = customersDataView;
        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustRow = customersDataView.AddNew();
            newCustRow["CustomerID"] = "WINGT";
            newCustRow["CompanyName"] = "Wing Tip Toys";
            newCustRow.EndEdit();
        }

        private void GetOrdersbutton_Click(object sender, EventArgs e)
        {
            string SelectedCustID = (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView SelectedRow = customersDataView[customersDataView.Find(SelectedCustID)];
            ordersDataView = SelectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            ordersGrid.DataSource = ordersDataView;
        }
    }
}
