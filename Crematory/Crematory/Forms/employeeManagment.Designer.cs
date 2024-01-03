namespace Crematory
{
    partial class employeeManagment
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
            this.bt_backToMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_add_employee = new System.Windows.Forms.Button();
            this.bt_edit_employee = new System.Windows.Forms.Button();
            this.bt_delete_employee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_OtherDetails = new System.Windows.Forms.TextBox();
            this.cBox_Role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_backToMain
            // 
            this.bt_backToMain.Location = new System.Drawing.Point(575, 375);
            this.bt_backToMain.Margin = new System.Windows.Forms.Padding(2);
            this.bt_backToMain.Name = "bt_backToMain";
            this.bt_backToMain.Size = new System.Drawing.Size(91, 33);
            this.bt_backToMain.TabIndex = 0;
            this.bt_backToMain.Text = "Back";
            this.bt_backToMain.UseVisualStyleBackColor = true;
            this.bt_backToMain.Click += new System.EventHandler(this.bt_backToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(320, 329);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // bt_add_employee
            // 
            this.bt_add_employee.Location = new System.Drawing.Point(4, 28);
            this.bt_add_employee.Margin = new System.Windows.Forms.Padding(2);
            this.bt_add_employee.Name = "bt_add_employee";
            this.bt_add_employee.Size = new System.Drawing.Size(100, 48);
            this.bt_add_employee.TabIndex = 2;
            this.bt_add_employee.Text = "Add";
            this.bt_add_employee.UseVisualStyleBackColor = true;
            this.bt_add_employee.Click += new System.EventHandler(this.bt_add_employee_Click);
            // 
            // bt_edit_employee
            // 
            this.bt_edit_employee.Location = new System.Drawing.Point(110, 28);
            this.bt_edit_employee.Margin = new System.Windows.Forms.Padding(2);
            this.bt_edit_employee.Name = "bt_edit_employee";
            this.bt_edit_employee.Size = new System.Drawing.Size(100, 48);
            this.bt_edit_employee.TabIndex = 3;
            this.bt_edit_employee.Text = "Edit";
            this.bt_edit_employee.UseVisualStyleBackColor = true;
            this.bt_edit_employee.Click += new System.EventHandler(this.bt_edit_employee_Click);
            // 
            // bt_delete_employee
            // 
            this.bt_delete_employee.Location = new System.Drawing.Point(214, 28);
            this.bt_delete_employee.Margin = new System.Windows.Forms.Padding(2);
            this.bt_delete_employee.Name = "bt_delete_employee";
            this.bt_delete_employee.Size = new System.Drawing.Size(100, 48);
            this.bt_delete_employee.TabIndex = 4;
            this.bt_delete_employee.Text = "Delete";
            this.bt_delete_employee.UseVisualStyleBackColor = true;
            this.bt_delete_employee.Click += new System.EventHandler(this.bt_delete_employee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_add_employee);
            this.groupBox1.Controls.Add(this.bt_delete_employee);
            this.groupBox1.Controls.Add(this.bt_edit_employee);
            this.groupBox1.Location = new System.Drawing.Point(9, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(320, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(512, 59);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(107, 20);
            this.txt_Name.TabIndex = 6;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(512, 100);
            this.txt_Surname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(107, 20);
            this.txt_Surname.TabIndex = 7;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(512, 141);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(104, 20);
            this.txt_PhoneNumber.TabIndex = 8;
            // 
            // txt_OtherDetails
            // 
            this.txt_OtherDetails.Location = new System.Drawing.Point(512, 255);
            this.txt_OtherDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OtherDetails.Name = "txt_OtherDetails";
            this.txt_OtherDetails.Size = new System.Drawing.Size(104, 20);
            this.txt_OtherDetails.TabIndex = 9;
            // 
            // cBox_Role
            // 
            this.cBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Role.FormattingEnabled = true;
            this.cBox_Role.Location = new System.Drawing.Point(512, 184);
            this.cBox_Role.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_Role.Name = "cBox_Role";
            this.cBox_Role.Size = new System.Drawing.Size(104, 21);
            this.cBox_Role.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Other details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(512, 223);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(104, 20);
            this.txt_Email.TabIndex = 17;
            // 
            // employeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 418);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Role);
            this.Controls.Add(this.txt_OtherDetails);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_backToMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "employeeManagment";
            this.Text = "Employee Managment";
            this.Load += new System.EventHandler(this.employeeManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_backToMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_add_employee;
        private System.Windows.Forms.Button bt_edit_employee;
        private System.Windows.Forms.Button bt_delete_employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_OtherDetails;
        private System.Windows.Forms.ComboBox cBox_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
    }
}