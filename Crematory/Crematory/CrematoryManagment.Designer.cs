namespace Crematory
{
    partial class CrematoryForm
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
            this.Operator = new System.Windows.Forms.TabPage();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bt_changeStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_Mortuary_Recep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ManagerTab = new System.Windows.Forms.TabPage();
            this.bt_Mortuary = new System.Windows.Forms.Button();
            this.bt_Contract = new System.Windows.Forms.Button();
            this.bt_employeeManagment = new System.Windows.Forms.Button();
            this.ReceptionTab = new System.Windows.Forms.TabControl();
            this.Operator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ManagerTab.SuspendLayout();
            this.ReceptionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Operator
            // 
            this.Operator.Controls.Add(this.cb_status);
            this.Operator.Controls.Add(this.bt_changeStatus);
            this.Operator.Controls.Add(this.dataGridView1);
            this.Operator.Location = new System.Drawing.Point(4, 22);
            this.Operator.Name = "Operator";
            this.Operator.Padding = new System.Windows.Forms.Padding(3);
            this.Operator.Size = new System.Drawing.Size(549, 434);
            this.Operator.TabIndex = 2;
            this.Operator.Text = "Operator";
            this.Operator.UseVisualStyleBackColor = true;
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(348, 18);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(182, 21);
            this.cb_status.TabIndex = 2;
            // 
            // bt_changeStatus
            // 
            this.bt_changeStatus.Location = new System.Drawing.Point(348, 56);
            this.bt_changeStatus.Name = "bt_changeStatus";
            this.bt_changeStatus.Size = new System.Drawing.Size(182, 23);
            this.bt_changeStatus.TabIndex = 1;
            this.bt_changeStatus.Text = "Change Status";
            this.bt_changeStatus.UseVisualStyleBackColor = true;
            this.bt_changeStatus.Click += new System.EventHandler(this.bt_changeStatus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(316, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_Mortuary_Recep);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reception";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_Mortuary_Recep
            // 
            this.bt_Mortuary_Recep.Location = new System.Drawing.Point(24, 32);
            this.bt_Mortuary_Recep.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Mortuary_Recep.Name = "bt_Mortuary_Recep";
            this.bt_Mortuary_Recep.Size = new System.Drawing.Size(137, 61);
            this.bt_Mortuary_Recep.TabIndex = 3;
            this.bt_Mortuary_Recep.Text = "Mortuary";
            this.bt_Mortuary_Recep.UseVisualStyleBackColor = true;
            this.bt_Mortuary_Recep.Click += new System.EventHandler(this.bt_Mortuary_Recep_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contracts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerTab
            // 
            this.ManagerTab.Controls.Add(this.bt_Mortuary);
            this.ManagerTab.Controls.Add(this.bt_Contract);
            this.ManagerTab.Controls.Add(this.bt_employeeManagment);
            this.ManagerTab.Location = new System.Drawing.Point(4, 22);
            this.ManagerTab.Name = "ManagerTab";
            this.ManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManagerTab.Size = new System.Drawing.Size(549, 434);
            this.ManagerTab.TabIndex = 0;
            this.ManagerTab.Text = "Manager";
            this.ManagerTab.UseVisualStyleBackColor = true;
            // 
            // bt_Mortuary
            // 
            this.bt_Mortuary.Location = new System.Drawing.Point(29, 94);
            this.bt_Mortuary.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Mortuary.Name = "bt_Mortuary";
            this.bt_Mortuary.Size = new System.Drawing.Size(137, 65);
            this.bt_Mortuary.TabIndex = 2;
            this.bt_Mortuary.Text = "Mortuary";
            this.bt_Mortuary.UseVisualStyleBackColor = true;
            this.bt_Mortuary.Click += new System.EventHandler(this.bt_Mortuary_Click);
            // 
            // bt_Contract
            // 
            this.bt_Contract.BackColor = System.Drawing.Color.White;
            this.bt_Contract.Location = new System.Drawing.Point(29, 24);
            this.bt_Contract.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Contract.Name = "bt_Contract";
            this.bt_Contract.Size = new System.Drawing.Size(137, 65);
            this.bt_Contract.TabIndex = 1;
            this.bt_Contract.Text = "Contracts";
            this.bt_Contract.UseVisualStyleBackColor = false;
            this.bt_Contract.Click += new System.EventHandler(this.bt_Contract_Click);
            // 
            // bt_employeeManagment
            // 
            this.bt_employeeManagment.ForeColor = System.Drawing.Color.Black;
            this.bt_employeeManagment.Location = new System.Drawing.Point(29, 164);
            this.bt_employeeManagment.Margin = new System.Windows.Forms.Padding(2);
            this.bt_employeeManagment.Name = "bt_employeeManagment";
            this.bt_employeeManagment.Size = new System.Drawing.Size(137, 65);
            this.bt_employeeManagment.TabIndex = 0;
            this.bt_employeeManagment.Text = "Employee Managment";
            this.bt_employeeManagment.UseVisualStyleBackColor = true;
            this.bt_employeeManagment.Click += new System.EventHandler(this.bt_employeeManagment_Click);
            // 
            // ReceptionTab
            // 
            this.ReceptionTab.Controls.Add(this.ManagerTab);
            this.ReceptionTab.Controls.Add(this.tabPage2);
            this.ReceptionTab.Controls.Add(this.Operator);
            this.ReceptionTab.Location = new System.Drawing.Point(0, 1);
            this.ReceptionTab.Margin = new System.Windows.Forms.Padding(2);
            this.ReceptionTab.Name = "ReceptionTab";
            this.ReceptionTab.SelectedIndex = 0;
            this.ReceptionTab.Size = new System.Drawing.Size(557, 460);
            this.ReceptionTab.TabIndex = 0;
            // 
            // CrematoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 455);
            this.Controls.Add(this.ReceptionTab);
            this.Name = "CrematoryForm";
            this.Text = "Crematory Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ManagerTab.ResumeLayout(false);
            this.ReceptionTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Operator;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_Mortuary_Recep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage ManagerTab;
        private System.Windows.Forms.Button bt_Mortuary;
        private System.Windows.Forms.Button bt_Contract;
        private System.Windows.Forms.Button bt_employeeManagment;
        private System.Windows.Forms.TabControl ReceptionTab;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button bt_changeStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

