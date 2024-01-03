namespace Crematory.Forms
{
    partial class CustomerDetails
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
            this.bt_backToContract = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_EditCustomer = new System.Windows.Forms.Button();
            this.txt_CustomerAdress = new System.Windows.Forms.TextBox();
            this.txt_CustomerEmail = new System.Windows.Forms.TextBox();
            this.txt_CustomerPhone = new System.Windows.Forms.TextBox();
            this.txt_CustmerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.fail_labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_backToContract
            // 
            this.bt_backToContract.Location = new System.Drawing.Point(204, 269);
            this.bt_backToContract.Name = "bt_backToContract";
            this.bt_backToContract.Size = new System.Drawing.Size(94, 35);
            this.bt_backToContract.TabIndex = 0;
            this.bt_backToContract.Text = "Back";
            this.bt_backToContract.UseVisualStyleBackColor = true;
            this.bt_backToContract.Click += new System.EventHandler(this.bt_backToContract_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_EditCustomer);
            this.groupBox1.Controls.Add(this.txt_CustomerAdress);
            this.groupBox1.Controls.Add(this.bt_backToContract);
            this.groupBox1.Controls.Add(this.txt_CustomerEmail);
            this.groupBox1.Controls.Add(this.txt_CustomerPhone);
            this.groupBox1.Controls.Add(this.txt_CustmerName);
            this.groupBox1.Controls.Add(this.txt_CustomerID);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.fail_labelName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "---";
            // 
            // bt_EditCustomer
            // 
            this.bt_EditCustomer.Location = new System.Drawing.Point(22, 269);
            this.bt_EditCustomer.Name = "bt_EditCustomer";
            this.bt_EditCustomer.Size = new System.Drawing.Size(91, 35);
            this.bt_EditCustomer.TabIndex = 10;
            this.bt_EditCustomer.Text = "Edit";
            this.bt_EditCustomer.UseVisualStyleBackColor = true;
            this.bt_EditCustomer.Click += new System.EventHandler(this.bt_EditCustomer_Click);
            // 
            // txt_CustomerAdress
            // 
            this.txt_CustomerAdress.Location = new System.Drawing.Point(130, 195);
            this.txt_CustomerAdress.Name = "txt_CustomerAdress";
            this.txt_CustomerAdress.Size = new System.Drawing.Size(145, 22);
            this.txt_CustomerAdress.TabIndex = 9;
            // 
            // txt_CustomerEmail
            // 
            this.txt_CustomerEmail.Location = new System.Drawing.Point(130, 153);
            this.txt_CustomerEmail.Name = "txt_CustomerEmail";
            this.txt_CustomerEmail.Size = new System.Drawing.Size(145, 22);
            this.txt_CustomerEmail.TabIndex = 8;
            this.txt_CustomerEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_CustomerPhone
            // 
            this.txt_CustomerPhone.Location = new System.Drawing.Point(130, 109);
            this.txt_CustomerPhone.Name = "txt_CustomerPhone";
            this.txt_CustomerPhone.Size = new System.Drawing.Size(145, 22);
            this.txt_CustomerPhone.TabIndex = 7;
            // 
            // txt_CustmerName
            // 
            this.txt_CustmerName.Location = new System.Drawing.Point(130, 70);
            this.txt_CustmerName.Name = "txt_CustmerName";
            this.txt_CustmerName.Size = new System.Drawing.Size(145, 22);
            this.txt_CustmerName.TabIndex = 6;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(130, 32);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.ReadOnly = true;
            this.txt_CustomerID.Size = new System.Drawing.Size(145, 22);
            this.txt_CustomerID.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 153);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 16);
            this.label22.TabIndex = 4;
            this.label22.Text = "Email";
            this.label22.Click += new System.EventHandler(this.label5_Click);
            // 
            // fail_labelName
            // 
            this.fail_labelName.AutoSize = true;
            this.fail_labelName.Location = new System.Drawing.Point(19, 195);
            this.fail_labelName.Name = "fail_labelName";
            this.fail_labelName.Size = new System.Drawing.Size(50, 16);
            this.fail_labelName.TabIndex = 3;
            this.fail_labelName.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerID";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_backToContract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label fail_labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerAdress;
        private System.Windows.Forms.TextBox txt_CustomerEmail;
        private System.Windows.Forms.TextBox txt_CustomerPhone;
        private System.Windows.Forms.TextBox txt_CustmerName;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button bt_EditCustomer;
    }
}