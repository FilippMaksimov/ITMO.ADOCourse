using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADOCourse.Lab04.CreatingDataTable.Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable CustomersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            TableGrid.DataSource = CustomersTable;
            CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
            CustomersTable.Columns.Add("City", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
            DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = CustomersTable.Columns["CustomerID"];
            CustomersTable.PrimaryKey = KeyColumns;
            CustomersTable.Columns["CustomerID"].AllowDBNull = false;
            CustomersTable.Columns["CompanyName"].AllowDBNull = false;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow CustRow = CustomersTable.NewRow();
                Object[] CustRecord = {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin",
                "Germany", "030-0074321"};
                if (CustomerIDTextBox.Text.Length > 0)
                {
                    CustRecord[0] = CustomerIDTextBox.Text;
                }
                CustRow.ItemArray = CustRecord;
                CustomersTable.Rows.Add(CustRow);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (CustomersTable.Rows.Count > 0)
                {
                    DataRow CustRow = CustomersTable.Rows.Find(DeleteCutumerIDTextBox.Text);
                    bool CustIDExist = true;
                    CustIDExist = CustomersTable.Rows.Find(DeleteCutumerIDTextBox.Text) != null;
                    if (CustIDExist)
                    {
                        CustomersTable.Rows.Remove(CustRow);
                    }
                    else
                    {
                        MessageBox.Show("Mentioned CustomerID doesn't exsist at the table");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
