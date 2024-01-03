namespace Crematory.Forms
{
    partial class DeceasedPersonDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_backToContract = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTP_DP_deathDate = new System.Windows.Forms.DateTimePicker();
            this.dateTP_DP_birthDate = new System.Windows.Forms.DateTimePicker();
            this.txt_DecreasedP_Age = new System.Windows.Forms.TextBox();
            this.txt_DecreasedP_Name = new System.Windows.Forms.TextBox();
            this.txt_DecreasedP_ID = new System.Windows.Forms.TextBox();
            this.rich_txt_DP_Details = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Edit);
            this.groupBox1.Controls.Add(this.bt_backToContract);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTP_DP_deathDate);
            this.groupBox1.Controls.Add(this.dateTP_DP_birthDate);
            this.groupBox1.Controls.Add(this.txt_DecreasedP_Age);
            this.groupBox1.Controls.Add(this.txt_DecreasedP_Name);
            this.groupBox1.Controls.Add(this.txt_DecreasedP_ID);
            this.groupBox1.Controls.Add(this.rich_txt_DP_Details);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "---";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_Edit
            // 
            this.bt_Edit.Location = new System.Drawing.Point(30, 490);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(138, 44);
            this.bt_Edit.TabIndex = 19;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_backToContract
            // 
            this.bt_backToContract.Location = new System.Drawing.Point(230, 490);
            this.bt_backToContract.Name = "bt_backToContract";
            this.bt_backToContract.Size = new System.Drawing.Size(157, 44);
            this.bt_backToContract.TabIndex = 18;
            this.bt_backToContract.Text = "Back";
            this.bt_backToContract.UseVisualStyleBackColor = true;
            this.bt_backToContract.Click += new System.EventHandler(this.bt_backToContract_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Other details";
            // 
            // dateTP_DP_deathDate
            // 
            this.dateTP_DP_deathDate.Location = new System.Drawing.Point(167, 220);
            this.dateTP_DP_deathDate.Name = "dateTP_DP_deathDate";
            this.dateTP_DP_deathDate.Size = new System.Drawing.Size(205, 22);
            this.dateTP_DP_deathDate.TabIndex = 12;
            this.dateTP_DP_deathDate.Value = new System.DateTime(2023, 4, 12, 18, 0, 33, 0);
            // 
            // dateTP_DP_birthDate
            // 
            this.dateTP_DP_birthDate.Location = new System.Drawing.Point(167, 182);
            this.dateTP_DP_birthDate.Name = "dateTP_DP_birthDate";
            this.dateTP_DP_birthDate.Size = new System.Drawing.Size(205, 22);
            this.dateTP_DP_birthDate.TabIndex = 11;
            this.dateTP_DP_birthDate.Value = new System.DateTime(2023, 4, 12, 18, 0, 29, 0);
            // 
            // txt_DecreasedP_Age
            // 
            this.txt_DecreasedP_Age.Location = new System.Drawing.Point(167, 134);
            this.txt_DecreasedP_Age.Name = "txt_DecreasedP_Age";
            this.txt_DecreasedP_Age.Size = new System.Drawing.Size(205, 22);
            this.txt_DecreasedP_Age.TabIndex = 10;
            // 
            // txt_DecreasedP_Name
            // 
            this.txt_DecreasedP_Name.Location = new System.Drawing.Point(167, 89);
            this.txt_DecreasedP_Name.Name = "txt_DecreasedP_Name";
            this.txt_DecreasedP_Name.Size = new System.Drawing.Size(205, 22);
            this.txt_DecreasedP_Name.TabIndex = 9;
            // 
            // txt_DecreasedP_ID
            // 
            this.txt_DecreasedP_ID.Location = new System.Drawing.Point(167, 42);
            this.txt_DecreasedP_ID.Name = "txt_DecreasedP_ID";
            this.txt_DecreasedP_ID.ReadOnly = true;
            this.txt_DecreasedP_ID.Size = new System.Drawing.Size(84, 22);
            this.txt_DecreasedP_ID.TabIndex = 8;
            // 
            // rich_txt_DP_Details
            // 
            this.rich_txt_DP_Details.Location = new System.Drawing.Point(30, 328);
            this.rich_txt_DP_Details.Name = "rich_txt_DP_Details";
            this.rich_txt_DP_Details.Size = new System.Drawing.Size(372, 135);
            this.rich_txt_DP_Details.TabIndex = 7;
            this.rich_txt_DP_Details.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Death date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeceasedPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 602);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeceasedPersonDetails";
            this.Text = "DeceasedPersonDetails";
            this.Load += new System.EventHandler(this.DeceasedPersonDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTP_DP_deathDate;
        private System.Windows.Forms.DateTimePicker dateTP_DP_birthDate;
        private System.Windows.Forms.TextBox txt_DecreasedP_Age;
        private System.Windows.Forms.TextBox txt_DecreasedP_Name;
        private System.Windows.Forms.TextBox txt_DecreasedP_ID;
        private System.Windows.Forms.RichTextBox rich_txt_DP_Details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_backToContract;
    }
}