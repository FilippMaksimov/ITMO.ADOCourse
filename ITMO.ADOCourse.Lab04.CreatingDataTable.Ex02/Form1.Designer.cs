namespace ITMO.ADOCourse.Lab04.CreatingDataTable.Ex02
{
    partial class Form1
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
            this.AddRowButton = new System.Windows.Forms.Button();
            this.TableGrid = new System.Windows.Forms.DataGridView();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.DeleteCutumerIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(12, 12);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(166, 47);
            this.AddRowButton.TabIndex = 0;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // TableGrid
            // 
            this.TableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.Location = new System.Drawing.Point(12, 226);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowHeadersWidth = 51;
            this.TableGrid.RowTemplate.Height = 24;
            this.TableGrid.Size = new System.Drawing.Size(776, 212);
            this.TableGrid.TabIndex = 1;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(15, 124);
            this.CustomerIDTextBox.Multiline = true;
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(110, 30);
            this.CustomerIDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CustomerID Input";
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteRowButton.Location = new System.Drawing.Point(291, 13);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(211, 46);
            this.DeleteRowButton.TabIndex = 4;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = false;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // DeleteCutumerIDTextBox
            // 
            this.DeleteCutumerIDTextBox.Location = new System.Drawing.Point(291, 123);
            this.DeleteCutumerIDTextBox.Multiline = true;
            this.DeleteCutumerIDTextBox.Name = "DeleteCutumerIDTextBox";
            this.DeleteCutumerIDTextBox.Size = new System.Drawing.Size(211, 31);
            this.DeleteCutumerIDTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the CustomerID to be deleted";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteCutumerIDTextBox);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.TableGrid);
            this.Controls.Add(this.AddRowButton);
            this.Name = "Form1";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.DataGridView TableGrid;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.TextBox DeleteCutumerIDTextBox;
        private System.Windows.Forms.Label label2;
    }
}

