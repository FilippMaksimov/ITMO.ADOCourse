namespace ITMO.ADOCourse.FinalTask
{
    partial class FinalApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderid = new System.Windows.Forms.Label();
            this.employeeid = new System.Windows.Forms.Label();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ShowTableButton = new System.Windows.Forms.Button();
            this.OrdersRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.DateBirthTextBox = new System.Windows.Forms.TextBox();
            this.TitleCourtTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShipViaTextBox = new System.Windows.Forms.TextBox();
            this.ShippedDateTextBox = new System.Windows.Forms.TextBox();
            this.RequiredDateTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.saveChangesToolStripMenuItem});
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.openToolStripMenuItem.Text = "Data Base";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saveChangesToolStripMenuItem.Text = "Save Changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderid);
            this.groupBox1.Controls.Add(this.employeeid);
            this.groupBox1.Controls.Add(this.AddRowButton);
            this.groupBox1.Controls.Add(this.DeleteRowButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.ShowTableButton);
            this.groupBox1.Controls.Add(this.OrdersRadioButton);
            this.groupBox1.Controls.Add(this.EmployeesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(677, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // orderid
            // 
            this.orderid.AutoSize = true;
            this.orderid.Location = new System.Drawing.Point(185, 252);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(0, 16);
            this.orderid.TabIndex = 7;
            // 
            // employeeid
            // 
            this.employeeid.AutoSize = true;
            this.employeeid.Location = new System.Drawing.Point(7, 252);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(0, 16);
            this.employeeid.TabIndex = 6;
            // 
            // AddRowButton
            // 
            this.AddRowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddRowButton.Location = new System.Drawing.Point(7, 106);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(282, 39);
            this.AddRowButton.TabIndex = 5;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = false;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteRowButton.Location = new System.Drawing.Point(7, 199);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(282, 38);
            this.DeleteRowButton.TabIndex = 4;
            this.DeleteRowButton.Text = "Delete Selected Row";
            this.DeleteRowButton.UseVisualStyleBackColor = false;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditButton.Location = new System.Drawing.Point(7, 151);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(282, 36);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Selected Row";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ShowTableButton
            // 
            this.ShowTableButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowTableButton.Location = new System.Drawing.Point(7, 57);
            this.ShowTableButton.Name = "ShowTableButton";
            this.ShowTableButton.Size = new System.Drawing.Size(282, 39);
            this.ShowTableButton.TabIndex = 2;
            this.ShowTableButton.Text = "Show Table";
            this.ShowTableButton.UseVisualStyleBackColor = false;
            this.ShowTableButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // OrdersRadioButton
            // 
            this.OrdersRadioButton.AutoSize = true;
            this.OrdersRadioButton.Location = new System.Drawing.Point(185, 21);
            this.OrdersRadioButton.Name = "OrdersRadioButton";
            this.OrdersRadioButton.Size = new System.Drawing.Size(69, 20);
            this.OrdersRadioButton.TabIndex = 1;
            this.OrdersRadioButton.TabStop = true;
            this.OrdersRadioButton.Text = "Orders";
            this.OrdersRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesRadioButton
            // 
            this.EmployeesRadioButton.AutoSize = true;
            this.EmployeesRadioButton.Location = new System.Drawing.Point(6, 21);
            this.EmployeesRadioButton.Name = "EmployeesRadioButton";
            this.EmployeesRadioButton.Size = new System.Drawing.Size(97, 20);
            this.EmployeesRadioButton.TabIndex = 0;
            this.EmployeesRadioButton.TabStop = true;
            this.EmployeesRadioButton.Text = "Employees";
            this.EmployeesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HireDateTextBox);
            this.groupBox2.Controls.Add(this.DateBirthTextBox);
            this.groupBox2.Controls.Add(this.TitleCourtTextBox);
            this.groupBox2.Controls.Add(this.TitleTextBox);
            this.groupBox2.Controls.Add(this.FirstNameTextBox);
            this.groupBox2.Controls.Add(this.LastNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of hireing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title of courtesy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(145, 247);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(171, 22);
            this.HireDateTextBox.TabIndex = 5;
            // 
            // DateBirthTextBox
            // 
            this.DateBirthTextBox.Location = new System.Drawing.Point(145, 202);
            this.DateBirthTextBox.Name = "DateBirthTextBox";
            this.DateBirthTextBox.Size = new System.Drawing.Size(171, 22);
            this.DateBirthTextBox.TabIndex = 4;
            // 
            // TitleCourtTextBox
            // 
            this.TitleCourtTextBox.Location = new System.Drawing.Point(145, 157);
            this.TitleCourtTextBox.Name = "TitleCourtTextBox";
            this.TitleCourtTextBox.Size = new System.Drawing.Size(171, 22);
            this.TitleCourtTextBox.TabIndex = 3;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(145, 115);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(171, 22);
            this.TitleTextBox.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(145, 74);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(145, 36);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ShipViaTextBox);
            this.groupBox3.Controls.Add(this.ShippedDateTextBox);
            this.groupBox3.Controls.Add(this.RequiredDateTextBox);
            this.groupBox3.Controls.Add(this.OrderDateTextBox);
            this.groupBox3.Controls.Add(this.CustomerIdTextBox);
            this.groupBox3.Controls.Add(this.EmployeeIdTextBox);
            this.groupBox3.Location = new System.Drawing.Point(340, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ship via";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Shipped date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Required date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date of order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employee ID";
            // 
            // ShipViaTextBox
            // 
            this.ShipViaTextBox.Location = new System.Drawing.Point(145, 247);
            this.ShipViaTextBox.Name = "ShipViaTextBox";
            this.ShipViaTextBox.Size = new System.Drawing.Size(180, 22);
            this.ShipViaTextBox.TabIndex = 5;
            // 
            // ShippedDateTextBox
            // 
            this.ShippedDateTextBox.Location = new System.Drawing.Point(145, 202);
            this.ShippedDateTextBox.Name = "ShippedDateTextBox";
            this.ShippedDateTextBox.Size = new System.Drawing.Size(180, 22);
            this.ShippedDateTextBox.TabIndex = 4;
            // 
            // RequiredDateTextBox
            // 
            this.RequiredDateTextBox.Location = new System.Drawing.Point(145, 157);
            this.RequiredDateTextBox.Name = "RequiredDateTextBox";
            this.RequiredDateTextBox.Size = new System.Drawing.Size(180, 22);
            this.RequiredDateTextBox.TabIndex = 3;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(145, 115);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(180, 22);
            this.OrderDateTextBox.TabIndex = 2;
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(145, 73);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(180, 22);
            this.CustomerIdTextBox.TabIndex = 1;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(145, 36);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(180, 22);
            this.EmployeeIdTextBox.TabIndex = 0;
            // 
            // FinalApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 610);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinalApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrdersRadioButton;
        private System.Windows.Forms.RadioButton EmployeesRadioButton;
        private System.Windows.Forms.Button ShowTableButton;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.TextBox DateBirthTextBox;
        private System.Windows.Forms.TextBox TitleCourtTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label orderid;
        private System.Windows.Forms.Label employeeid;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShipViaTextBox;
        private System.Windows.Forms.TextBox ShippedDateTextBox;
        private System.Windows.Forms.TextBox RequiredDateTextBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
    }
}

