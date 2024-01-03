namespace Crematory.Forms
{
    partial class addOrder
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
            this.bt_back_to_Contract = new System.Windows.Forms.Button();
            this.cBox_Staff = new System.Windows.Forms.ComboBox();
            this.cBox_Customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTP_DP_deathDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.rich_txt_DP_Details = new System.Windows.Forms.RichTextBox();
            this.dateTP_DP_birthDate = new System.Windows.Forms.DateTimePicker();
            this.txt_DP_Age = new System.Windows.Forms.TextBox();
            this.txt_DP_Name = new System.Windows.Forms.TextBox();
            this.cBox_ColdRoom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chB_creamtory_consent = new System.Windows.Forms.CheckBox();
            this.chB_death_certificate = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTP_OD_funeralDate = new System.Windows.Forms.DateTimePicker();
            this.rich_txt_OD_SpetialInstructions = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_add_order = new System.Windows.Forms.Button();
            this.bt_add_customer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DP_Surname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back_to_Contract
            // 
            this.bt_back_to_Contract.Location = new System.Drawing.Point(667, 564);
            this.bt_back_to_Contract.Name = "bt_back_to_Contract";
            this.bt_back_to_Contract.Size = new System.Drawing.Size(136, 55);
            this.bt_back_to_Contract.TabIndex = 0;
            this.bt_back_to_Contract.Text = "Back";
            this.bt_back_to_Contract.UseVisualStyleBackColor = true;
            this.bt_back_to_Contract.Click += new System.EventHandler(this.bt_back_to_Contract_Click);
            // 
            // cBox_Staff
            // 
            this.cBox_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Staff.FormattingEnabled = true;
            this.cBox_Staff.Location = new System.Drawing.Point(149, 74);
            this.cBox_Staff.Name = "cBox_Staff";
            this.cBox_Staff.Size = new System.Drawing.Size(254, 24);
            this.cBox_Staff.TabIndex = 1;
            // 
            // cBox_Customer
            // 
            this.cBox_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Customer.FormattingEnabled = true;
            this.cBox_Customer.Location = new System.Drawing.Point(147, 39);
            this.cBox_Customer.Name = "cBox_Customer";
            this.cBox_Customer.Size = new System.Drawing.Size(256, 24);
            this.cBox_Customer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Operator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_DP_Surname);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTP_DP_deathDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rich_txt_DP_Details);
            this.groupBox1.Controls.Add(this.dateTP_DP_birthDate);
            this.groupBox1.Controls.Add(this.txt_DP_Age);
            this.groupBox1.Controls.Add(this.txt_DP_Name);
            this.groupBox1.Controls.Add(this.cBox_ColdRoom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 537);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dectreased Person Details";
            // 
            // dateTP_DP_deathDate
            // 
            this.dateTP_DP_deathDate.Location = new System.Drawing.Point(135, 144);
            this.dateTP_DP_deathDate.Name = "dateTP_DP_deathDate";
            this.dateTP_DP_deathDate.Size = new System.Drawing.Size(193, 22);
            this.dateTP_DP_deathDate.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date of death";
            // 
            // rich_txt_DP_Details
            // 
            this.rich_txt_DP_Details.Location = new System.Drawing.Point(19, 232);
            this.rich_txt_DP_Details.Name = "rich_txt_DP_Details";
            this.rich_txt_DP_Details.Size = new System.Drawing.Size(309, 284);
            this.rich_txt_DP_Details.TabIndex = 10;
            this.rich_txt_DP_Details.Text = "";
            // 
            // dateTP_DP_birthDate
            // 
            this.dateTP_DP_birthDate.Location = new System.Drawing.Point(135, 112);
            this.dateTP_DP_birthDate.Name = "dateTP_DP_birthDate";
            this.dateTP_DP_birthDate.Size = new System.Drawing.Size(193, 22);
            this.dateTP_DP_birthDate.TabIndex = 9;
            // 
            // txt_DP_Age
            // 
            this.txt_DP_Age.Location = new System.Drawing.Point(135, 84);
            this.txt_DP_Age.Name = "txt_DP_Age";
            this.txt_DP_Age.Size = new System.Drawing.Size(193, 22);
            this.txt_DP_Age.TabIndex = 7;
            // 
            // txt_DP_Name
            // 
            this.txt_DP_Name.Location = new System.Drawing.Point(135, 24);
            this.txt_DP_Name.Name = "txt_DP_Name";
            this.txt_DP_Name.Size = new System.Drawing.Size(193, 22);
            this.txt_DP_Name.TabIndex = 6;
            // 
            // cBox_ColdRoom
            // 
            this.cBox_ColdRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ColdRoom.FormattingEnabled = true;
            this.cBox_ColdRoom.Location = new System.Drawing.Point(135, 180);
            this.cBox_ColdRoom.Name = "cBox_ColdRoom";
            this.cBox_ColdRoom.Size = new System.Drawing.Size(193, 24);
            this.cBox_ColdRoom.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Other details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cold room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chB_creamtory_consent);
            this.groupBox2.Controls.Add(this.chB_death_certificate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTP_OD_funeralDate);
            this.groupBox2.Controls.Add(this.rich_txt_OD_SpetialInstructions);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(371, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 412);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            // 
            // chB_creamtory_consent
            // 
            this.chB_creamtory_consent.AutoSize = true;
            this.chB_creamtory_consent.Location = new System.Drawing.Point(21, 97);
            this.chB_creamtory_consent.Name = "chB_creamtory_consent";
            this.chB_creamtory_consent.Size = new System.Drawing.Size(141, 20);
            this.chB_creamtory_consent.TabIndex = 7;
            this.chB_creamtory_consent.Text = "Crematory consent";
            this.chB_creamtory_consent.UseVisualStyleBackColor = true;
            // 
            // chB_death_certificate
            // 
            this.chB_death_certificate.AutoSize = true;
            this.chB_death_certificate.Location = new System.Drawing.Point(15, 50);
            this.chB_death_certificate.Name = "chB_death_certificate";
            this.chB_death_certificate.Size = new System.Drawing.Size(125, 20);
            this.chB_death_certificate.TabIndex = 6;
            this.chB_death_certificate.Text = "Death certificate";
            this.chB_death_certificate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Funeral date";
            // 
            // dateTP_OD_funeralDate
            // 
            this.dateTP_OD_funeralDate.Location = new System.Drawing.Point(135, 19);
            this.dateTP_OD_funeralDate.Name = "dateTP_OD_funeralDate";
            this.dateTP_OD_funeralDate.Size = new System.Drawing.Size(200, 22);
            this.dateTP_OD_funeralDate.TabIndex = 2;
            // 
            // rich_txt_OD_SpetialInstructions
            // 
            this.rich_txt_OD_SpetialInstructions.Location = new System.Drawing.Point(15, 203);
            this.rich_txt_OD_SpetialInstructions.Name = "rich_txt_OD_SpetialInstructions";
            this.rich_txt_OD_SpetialInstructions.Size = new System.Drawing.Size(311, 203);
            this.rich_txt_OD_SpetialInstructions.TabIndex = 1;
            this.rich_txt_OD_SpetialInstructions.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Special instructions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cBox_Customer);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cBox_Staff);
            this.groupBox3.Location = new System.Drawing.Point(371, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 120);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select other";
            // 
            // bt_add_order
            // 
            this.bt_add_order.Location = new System.Drawing.Point(31, 555);
            this.bt_add_order.Name = "bt_add_order";
            this.bt_add_order.Size = new System.Drawing.Size(136, 64);
            this.bt_add_order.TabIndex = 9;
            this.bt_add_order.Text = "Add Order";
            this.bt_add_order.UseVisualStyleBackColor = true;
            this.bt_add_order.Click += new System.EventHandler(this.bt_add_order_Click);
            // 
            // bt_add_customer
            // 
            this.bt_add_customer.Location = new System.Drawing.Point(503, 564);
            this.bt_add_customer.Name = "bt_add_customer";
            this.bt_add_customer.Size = new System.Drawing.Size(136, 55);
            this.bt_add_customer.TabIndex = 10;
            this.bt_add_customer.Text = "Add Customer";
            this.bt_add_customer.UseVisualStyleBackColor = true;
            this.bt_add_customer.Click += new System.EventHandler(this.bt_add_customer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Surname";
            // 
            // txt_DP_Surname
            // 
            this.txt_DP_Surname.Location = new System.Drawing.Point(135, 52);
            this.txt_DP_Surname.Name = "txt_DP_Surname";
            this.txt_DP_Surname.Size = new System.Drawing.Size(193, 22);
            this.txt_DP_Surname.TabIndex = 14;
            // 
            // addOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 631);
            this.Controls.Add(this.bt_add_customer);
            this.Controls.Add(this.bt_add_order);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_back_to_Contract);
            this.Name = "addOrder";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.addOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back_to_Contract;
        private System.Windows.Forms.ComboBox cBox_Staff;
        private System.Windows.Forms.ComboBox cBox_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox_ColdRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rich_txt_DP_Details;
        private System.Windows.Forms.DateTimePicker dateTP_DP_birthDate;
        private System.Windows.Forms.TextBox txt_DP_Age;
        private System.Windows.Forms.TextBox txt_DP_Name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_add_order;
        private System.Windows.Forms.CheckBox chB_creamtory_consent;
        private System.Windows.Forms.CheckBox chB_death_certificate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTP_OD_funeralDate;
        private System.Windows.Forms.RichTextBox rich_txt_OD_SpetialInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_add_customer;
        private System.Windows.Forms.DateTimePicker dateTP_DP_deathDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DP_Surname;
        private System.Windows.Forms.Label label11;
    }
}