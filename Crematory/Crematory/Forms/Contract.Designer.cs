namespace Crematory
{
    partial class Contract
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
            this.bt_show_customer_details = new System.Windows.Forms.Button();
            this.bt_show_deceasedPerson_details = new System.Windows.Forms.Button();
            this.bt_add_order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_editOrderDetails = new System.Windows.Forms.Button();
            this.dateTP_DP_funeralDate = new System.Windows.Forms.DateTimePicker();
            this.dateTP_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.cBox_Staff = new System.Windows.Forms.ComboBox();
            this.txt_spetialInstructions = new System.Windows.Forms.RichTextBox();
            this.chB_creamtory_consent = new System.Windows.Forms.CheckBox();
            this.chB_death_certificate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_backToMain
            // 
            this.bt_backToMain.Location = new System.Drawing.Point(593, 388);
            this.bt_backToMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_backToMain.Name = "bt_backToMain";
            this.bt_backToMain.Size = new System.Drawing.Size(111, 53);
            this.bt_backToMain.TabIndex = 1;
            this.bt_backToMain.Text = "Back";
            this.bt_backToMain.UseVisualStyleBackColor = true;
            this.bt_backToMain.Click += new System.EventHandler(this.bt_backToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(422, 370);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowClick);
            // 
            // bt_show_customer_details
            // 
            this.bt_show_customer_details.Location = new System.Drawing.Point(176, 323);
            this.bt_show_customer_details.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_show_customer_details.Name = "bt_show_customer_details";
            this.bt_show_customer_details.Size = new System.Drawing.Size(89, 38);
            this.bt_show_customer_details.TabIndex = 3;
            this.bt_show_customer_details.Text = "Customer Details";
            this.bt_show_customer_details.UseVisualStyleBackColor = true;
            this.bt_show_customer_details.Click += new System.EventHandler(this.bt_show_customer_details_Click);
            // 
            // bt_show_deceasedPerson_details
            // 
            this.bt_show_deceasedPerson_details.Location = new System.Drawing.Point(93, 323);
            this.bt_show_deceasedPerson_details.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_show_deceasedPerson_details.Name = "bt_show_deceasedPerson_details";
            this.bt_show_deceasedPerson_details.Size = new System.Drawing.Size(89, 38);
            this.bt_show_deceasedPerson_details.TabIndex = 4;
            this.bt_show_deceasedPerson_details.Text = "Deceased Person Details";
            this.bt_show_deceasedPerson_details.UseVisualStyleBackColor = true;
            this.bt_show_deceasedPerson_details.Click += new System.EventHandler(this.bt_show_deceasedPerson_details_Click);
            // 
            // bt_add_order
            // 
            this.bt_add_order.Location = new System.Drawing.Point(9, 388);
            this.bt_add_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_add_order.Name = "bt_add_order";
            this.bt_add_order.Size = new System.Drawing.Size(99, 53);
            this.bt_add_order.TabIndex = 5;
            this.bt_add_order.Text = "Add Order";
            this.bt_add_order.UseVisualStyleBackColor = true;
            this.bt_add_order.Click += new System.EventHandler(this.bt_add_order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_editOrderDetails);
            this.groupBox1.Controls.Add(this.dateTP_DP_funeralDate);
            this.groupBox1.Controls.Add(this.bt_show_customer_details);
            this.groupBox1.Controls.Add(this.bt_show_deceasedPerson_details);
            this.groupBox1.Controls.Add(this.dateTP_OrderDate);
            this.groupBox1.Controls.Add(this.cBox_Staff);
            this.groupBox1.Controls.Add(this.txt_spetialInstructions);
            this.groupBox1.Controls.Add(this.chB_creamtory_consent);
            this.groupBox1.Controls.Add(this.chB_death_certificate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(439, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(270, 362);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit order details";
            // 
            // bt_editOrderDetails
            // 
            this.bt_editOrderDetails.Location = new System.Drawing.Point(7, 323);
            this.bt_editOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_editOrderDetails.Name = "bt_editOrderDetails";
            this.bt_editOrderDetails.Size = new System.Drawing.Size(89, 38);
            this.bt_editOrderDetails.TabIndex = 19;
            this.bt_editOrderDetails.Text = "Edit order";
            this.bt_editOrderDetails.UseVisualStyleBackColor = true;
            this.bt_editOrderDetails.Click += new System.EventHandler(this.bt_editOrderDetails_Click);
            // 
            // dateTP_DP_funeralDate
            // 
            this.dateTP_DP_funeralDate.Location = new System.Drawing.Point(83, 87);
            this.dateTP_DP_funeralDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTP_DP_funeralDate.Name = "dateTP_DP_funeralDate";
            this.dateTP_DP_funeralDate.Size = new System.Drawing.Size(174, 20);
            this.dateTP_DP_funeralDate.TabIndex = 18;
            this.dateTP_DP_funeralDate.Value = new System.DateTime(2023, 4, 12, 17, 59, 34, 0);
            // 
            // dateTP_OrderDate
            // 
            this.dateTP_OrderDate.Location = new System.Drawing.Point(83, 54);
            this.dateTP_OrderDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTP_OrderDate.Name = "dateTP_OrderDate";
            this.dateTP_OrderDate.Size = new System.Drawing.Size(174, 20);
            this.dateTP_OrderDate.TabIndex = 17;
            this.dateTP_OrderDate.Value = new System.DateTime(2023, 4, 12, 17, 59, 18, 0);
            // 
            // cBox_Staff
            // 
            this.cBox_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Staff.FormattingEnabled = true;
            this.cBox_Staff.Location = new System.Drawing.Point(83, 26);
            this.cBox_Staff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBox_Staff.Name = "cBox_Staff";
            this.cBox_Staff.Size = new System.Drawing.Size(174, 21);
            this.cBox_Staff.TabIndex = 16;
            // 
            // txt_spetialInstructions
            // 
            this.txt_spetialInstructions.Location = new System.Drawing.Point(4, 179);
            this.txt_spetialInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_spetialInstructions.Name = "txt_spetialInstructions";
            this.txt_spetialInstructions.Size = new System.Drawing.Size(251, 140);
            this.txt_spetialInstructions.TabIndex = 14;
            this.txt_spetialInstructions.Text = "";
            // 
            // chB_creamtory_consent
            // 
            this.chB_creamtory_consent.AutoSize = true;
            this.chB_creamtory_consent.Location = new System.Drawing.Point(115, 127);
            this.chB_creamtory_consent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chB_creamtory_consent.Name = "chB_creamtory_consent";
            this.chB_creamtory_consent.Size = new System.Drawing.Size(120, 17);
            this.chB_creamtory_consent.TabIndex = 13;
            this.chB_creamtory_consent.Text = "Creamatory consent";
            this.chB_creamtory_consent.UseVisualStyleBackColor = true;
            // 
            // chB_death_certificate
            // 
            this.chB_death_certificate.AutoSize = true;
            this.chB_death_certificate.Location = new System.Drawing.Point(4, 127);
            this.chB_death_certificate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chB_death_certificate.Name = "chB_death_certificate";
            this.chB_death_certificate.Size = new System.Drawing.Size(104, 17);
            this.chB_death_certificate.TabIndex = 12;
            this.chB_death_certificate.Text = "Death certificate";
            this.chB_death_certificate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Special Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Funeral date";
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_add_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_backToMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_backToMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_show_customer_details;
        private System.Windows.Forms.Button bt_show_deceasedPerson_details;
        private System.Windows.Forms.Button bt_add_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chB_creamtory_consent;
        private System.Windows.Forms.CheckBox chB_death_certificate;
        private System.Windows.Forms.RichTextBox txt_spetialInstructions;
        private System.Windows.Forms.ComboBox cBox_Staff;
        private System.Windows.Forms.Button bt_editOrderDetails;
        private System.Windows.Forms.DateTimePicker dateTP_DP_funeralDate;
        private System.Windows.Forms.DateTimePicker dateTP_OrderDate;
    }
}