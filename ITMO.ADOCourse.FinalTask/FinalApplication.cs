using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ITMO.ADOCourse.FinalTask
{
    public partial class FinalApplicationForm : Form
    {
        public FinalApplicationForm()
        {
            InitializeComponent();
        }
        private SqlDataAdapter SqlDataAdapter1;
        private SqlDataAdapter SqlDataAdapter2;
        private DataSet NortwindDataSet = new DataSet("Northwind");
        private DataTable EmployeesTable = new DataTable("Employees");
        private DataTable OrdersTable = new DataTable("Orders");
        private SqlConnection NorthwindConnection;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private string GetStringConnection(string name)
        //{
        //    string returnValue = null;
        //    ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
        //    if (settings != null)
        //        returnValue = settings.ConnectionString;
        //    return returnValue;

        //}

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationcsForm logForm = new AuthorizationcsForm();
            string connect = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\filma\OneDrive\Desktop\ITMO.ADOCourse\ITMO.ADOCourse.FinalTask\FinalLocalDB.mdf;Integrated Security=True;User ID=" + logForm.UserId+";Password="+logForm.Password);
            if (logForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                NorthwindConnection = new SqlConnection(connect);
                SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Employees", NorthwindConnection);
                SqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM Orders", NorthwindConnection);

                NortwindDataSet.Tables.Add(EmployeesTable);
                NortwindDataSet.Tables.Add(OrdersTable);

                SqlDataAdapter1.Fill(NortwindDataSet.Tables["Employees"]);
                SqlDataAdapter2.Fill(NortwindDataSet.Tables["Orders"]);

                DataColumn id1 = NortwindDataSet.Tables["Employees"].Columns["EmployeeID"];
                NortwindDataSet.Tables["Employees"].PrimaryKey = new DataColumn[] { id1 };
                id1.AutoIncrement = true;
                id1.AutoIncrementSeed = 1 + id1.Table.Rows.Count;
                id1.Unique = true;
                DataColumn id2 = NortwindDataSet.Tables["Orders"].Columns["OrderID"];
                NortwindDataSet.Tables["Orders"].PrimaryKey = new DataColumn[] { id2 };
                id2.AutoIncrement = true;
                id2.AutoIncrementSeed = 10248 + id2.Table.Rows.Count;
                id2.Unique = true;

                SqlCommandBuilder empCommands = new SqlCommandBuilder(SqlDataAdapter1);
                SqlCommandBuilder ordCommands = new SqlCommandBuilder(SqlDataAdapter2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                NortwindDataSet.Tables.Remove(EmployeesTable);
                NortwindDataSet.Tables.Remove(OrdersTable);
            }
            
        }

        private void ShowTableButton_Click(object sender, EventArgs e)
        {
            if (EmployeesRadioButton.Checked == true) 
            {
                dataGridView1.DataSource = EmployeesTable;
            }
            if (OrdersRadioButton.Checked == true)
            {
                dataGridView1.DataSource = OrdersTable;
            }
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NortwindDataSet.EndInit();
            SqlDataAdapter1.Update(EmployeesTable);
            SqlDataAdapter2.Update(OrdersTable);
            //SqlDataAdapter1.Update(NortwindDataSet.Tables["Employees"]);
            //SqlDataAdapter2.Update(NortwindDataSet.Tables["Orders"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            
            if (EmployeesRadioButton.Checked == true)
            {
                LastNameTextBox.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                FirstNameTextBox.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                TitleTextBox.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                TitleCourtTextBox.Text = dataGridView1.CurrentRow.Cells["TitleOfCourtesy"].Value.ToString();
                DateBirthTextBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["BirthDate"].Value);
                HireDateTextBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["HireDate"].Value);
                employeeid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            if (OrdersRadioButton.Checked == true)
            {
                EmployeeIdTextBox.Text = dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
                CustomerIdTextBox.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
                OrderDateTextBox.Text = dataGridView1.CurrentRow.Cells["OrderDate"].Value.ToString();
                RequiredDateTextBox.Text = dataGridView1.CurrentRow.Cells["RequiredDate"].Value.ToString();
                ShippedDateTextBox.Text = dataGridView1.CurrentRow.Cells["ShippedDate"].Value.ToString();
                ShipViaTextBox.Text = dataGridView1.CurrentRow.Cells["ShipVia"].Value.ToString();
                orderid.Text = dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString();
            }
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            if (EmployeesRadioButton.Checked == true)
            {
                try
                {
                    DataRow newRowEmp = EmployeesTable.NewRow();
                    newRowEmp["LastName"] = LastNameTextBox.Text;
                    newRowEmp["FirstName"] = FirstNameTextBox.Text;
                    newRowEmp["Title"] = TitleTextBox.Text;
                    newRowEmp["TitleOfCourtesy"] = TitleCourtTextBox.Text;
                    newRowEmp["BirthDate"] = Convert.ToDateTime(DateBirthTextBox.Text);
                    newRowEmp["HireDate"] = Convert.ToDateTime(HireDateTextBox.Text);
                    EmployeesTable.Rows.Add(newRowEmp);
          
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
            if (OrdersRadioButton.Checked == true)
            {
                try
                {
                    DataRow newRowOrd = OrdersTable.NewRow();
                    newRowOrd["EmployeeID"] = Int32.Parse(EmployeeIdTextBox.Text);
                    newRowOrd["CustomerID"] = CustomerIdTextBox.Text;
                    newRowOrd["OrderDate"] = Convert.ToDateTime(OrderDateTextBox.Text);
                    newRowOrd["RequiredDate"] = Convert.ToDateTime(RequiredDateTextBox.Text);
                    newRowOrd["ShippedDate"] = Convert.ToDateTime(ShippedDateTextBox.Text);
                    newRowOrd["ShipVia"] = Int32.Parse(ShipViaTextBox.Text);
                    OrdersTable.Rows.Add(newRowOrd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (EmployeesRadioButton.Checked == true)
            {
                DataRow selRowEmpl = EmployeesTable.Rows.Find(Int32.Parse(employeeid.Text));
                selRowEmpl.Delete();
            }
            else if (OrdersRadioButton.Checked == true)
            {
                DataRow selRowOrder = OrdersTable.Rows.Find(Int32.Parse(orderid.Text));
                selRowOrder.Delete();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeesRadioButton.Checked == true)
                {
                    DataRow selRowEmpl = EmployeesTable.Rows.Find(Int32.Parse(employeeid.Text));
                    selRowEmpl["LastName"] = this.LastNameTextBox.Text;
                    selRowEmpl["FirstName"] = this.FirstNameTextBox.Text;
                    selRowEmpl["Title"] = this.TitleTextBox.Text;
                    selRowEmpl["TitleOfCourtesy"] = this.TitleCourtTextBox.Text;
                    selRowEmpl["BirthDate"] = Convert.ToDateTime(this.DateBirthTextBox.Text);
                    selRowEmpl["HireDate"] = Convert.ToDateTime(this.HireDateTextBox.Text);
                }
                else if (OrdersRadioButton.Checked == true)
                {
                    DataRow selRowOrder = OrdersTable.Rows.Find(Int32.Parse(orderid.Text));
                    selRowOrder["EmployeeID"] = Int32.Parse(this.EmployeeIdTextBox.Text);
                    selRowOrder["CustomerID"] = this.CustomerIdTextBox.Text;
                    selRowOrder["OrderDate"] = Convert.ToDateTime(this.OrderDateTextBox.Text);
                    selRowOrder["RequiredDate"] = Convert.ToDateTime(this.RequiredDateTextBox.Text);
                    selRowOrder["ShippedDate"] = Convert.ToDateTime(this.ShippedDateTextBox.Text);
                    selRowOrder["ShipVia"] = Int32.Parse(this.ShipViaTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
