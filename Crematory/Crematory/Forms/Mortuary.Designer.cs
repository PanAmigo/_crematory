namespace Crematory
{
    partial class Mortuary
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
            this.dGV_occupied = new System.Windows.Forms.DataGridView();
            this.dGV_free = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_occupied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_free)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_backToMain
            // 
            this.bt_backToMain.Location = new System.Drawing.Point(360, 295);
            this.bt_backToMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_backToMain.Name = "bt_backToMain";
            this.bt_backToMain.Size = new System.Drawing.Size(105, 60);
            this.bt_backToMain.TabIndex = 1;
            this.bt_backToMain.Text = "Back";
            this.bt_backToMain.UseVisualStyleBackColor = true;
            this.bt_backToMain.Click += new System.EventHandler(this.bt_backToMain_Click);
            // 
            // dGV_occupied
            // 
            this.dGV_occupied.AllowUserToAddRows = false;
            this.dGV_occupied.AllowUserToDeleteRows = false;
            this.dGV_occupied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_occupied.Location = new System.Drawing.Point(11, 27);
            this.dGV_occupied.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGV_occupied.Name = "dGV_occupied";
            this.dGV_occupied.ReadOnly = true;
            this.dGV_occupied.RowHeadersWidth = 51;
            this.dGV_occupied.RowTemplate.Height = 24;
            this.dGV_occupied.Size = new System.Drawing.Size(345, 198);
            this.dGV_occupied.TabIndex = 2;
            // 
            // dGV_free
            // 
            this.dGV_free.AllowUserToAddRows = false;
            this.dGV_free.AllowUserToDeleteRows = false;
            this.dGV_free.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_free.Location = new System.Drawing.Point(11, 254);
            this.dGV_free.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_free.Name = "dGV_free";
            this.dGV_free.ReadOnly = true;
            this.dGV_free.RowHeadersWidth = 51;
            this.dGV_free.RowTemplate.Height = 24;
            this.dGV_free.Size = new System.Drawing.Size(345, 101);
            this.dGV_free.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Zajęte";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Wolne";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mortuary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dGV_free);
            this.Controls.Add(this.dGV_occupied);
            this.Controls.Add(this.bt_backToMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mortuary";
            this.Text = "Mortuary";
            this.Load += new System.EventHandler(this.Mortuary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_occupied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_backToMain;
        private System.Windows.Forms.DataGridView dGV_occupied;
        private System.Windows.Forms.DataGridView dGV_free;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}