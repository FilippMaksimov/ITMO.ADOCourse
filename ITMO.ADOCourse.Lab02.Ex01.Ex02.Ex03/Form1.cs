using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ITMO.ADOCourse.Lab02.Ex01.Ex02.Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();

        //Returning the value of label of Connection by name.
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }
        //For testConnect variable to be assigned the name of connection string from configuration (look into the App.config file)
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL error code" + se.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Unexpected Exception",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
            {
                MessageBox.Show("Соединение с базой данных уже закрыто");
            }

        }

        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ProductName FROM Products";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Items.Add(reader["ProductName"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, подключитесь к БД");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Пожалуйста, подключитесь к БД");
                return;
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Products";
                int number = (int)command.ExecuteScalar();
                label1.Text = number.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(testConnect);
            connection.Open();
            SqlTransaction OleTran = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = OleTran;
            try
            {
                command.CommandText = "INSERT INTO Products (ProductName) VALUES('Wrong size')";
                    command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Products (ProductName) VALUES('Wrong color')";
                    command.ExecuteNonQuery();
                OleTran.Commit();
                MessageBox.Show("Both records were written to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    OleTran.Rollback();
                }
                catch (Exception exRollBack)
                {
                    MessageBox.Show(exRollBack.Message);
                }
            }
            connection.Close();
        }
    }
}
