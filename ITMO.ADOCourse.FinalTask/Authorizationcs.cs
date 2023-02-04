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

namespace ITMO.ADOCourse.FinalTask
{
    public partial class AuthorizationcsForm : Form
    {
        public AuthorizationcsForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "ItmoPractice",
            };
            AutoCompleteStringCollection passwordSource = new AutoCompleteStringCollection()
            {
                "123456789"
            };
            UserIdTextBox.AutoCompleteCustomSource = source;
            UserIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            UserIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PasswordTextBox.AutoCompleteCustomSource = passwordSource;
            PasswordTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PasswordTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        
        public string UserId
        {
            get { return UserIdTextBox.Text; }
            set { UserIdTextBox.Text = value; }
        }
        public string Password
        {
            get { return PasswordTextBox.Text; }
            set { PasswordTextBox.Text = value; }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.Text.Normalize();
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
