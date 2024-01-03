using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory
{
    public partial class CrematoryForm : Form
    {
        public CrematoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query = "SELECT CO.FuneralDate, DP.ColdRoom, DP.DeceasedPersonID, DP.Name, DP.Age, DP.DateOfBirth, DP.DateOfDeath, S.StatusName, DP.OtherDetails FROM CremationOrder CO JOIN DeceasedPerson DP ON CO.DeceasedPersonID = DP.DeceasedPersonID JOIN Status S ON DP.Status = S.StatusID ORDER BY DP.DeceasedPersonID DESC";
            var tb_name = "DeceasedPerson";
            var ds = ConnectionConfig.select_querry(query, tb_name);
            dataGridView1.DataSource = ds.Tables[tb_name];
            dataGridView1.Columns["DeceasedPersonID"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClearSelection();


            var cb_query = "Select StatusID, StatusName from Status";
            var cb_tb_name = "Status";
            var cb_ds = ConnectionConfig.select_querry(cb_query, cb_tb_name);
            var statuses = new List<string>();

            cb_status.DataSource = cb_ds.Tables[cb_tb_name].DefaultView;
            cb_status.DisplayMember = cb_tb_name;
            cb_status.ValueMember = "StatusName";
        }

        private void bt_employeeManagment_Click(object sender, EventArgs e)
        {

            var employeeManagment = new employeeManagment();        
            employeeManagment.Show();
            this.Hide();
        }

        private void bt_Contract_Click(object sender, EventArgs e)
        {
            var contract = new Contract();
            contract.Show();
            this.Hide();
        }

        private void bt_Mortuary_Click(object sender, EventArgs e)
        {
            var mortuary = new Mortuary();
            mortuary.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Contracts from Receptionist view
            var contract = new Contract();
            contract.Show();
            this.Hide();
        }

        private void bt_Mortuary_Recep_Click(object sender, EventArgs e)
        {
            var mortuary = new Mortuary();
            mortuary.Show();
            this.Hide();
        }

        private void bt_changeStatus_Click(object sender, EventArgs e)
        {
            var x = dataGridView1.SelectedCells;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (cb_status.Text != "Done")
                {
                    var status = cb_status.Text;
                    var cb_query = "Select StatusID, StatusName from Status WHERE StatusName = '" + status.ToString() + "'";
                    var cb_tb_name = "Status";
                    var cb_ds = ConnectionConfig.select_querry(cb_query, cb_tb_name);
                    var new_status_index = Convert.ToInt32(cb_ds.Tables[0].Rows[0]["StatusID"].ToString());
                    var deceasedPersonIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DeceasedPersonID"].Value.ToString());
                    Operator_Menagment.Edit_DeceasedPersonStatus(deceasedPersonIndex, new_status_index);
                }
                else if(dataGridView1.CurrentRow.Cells["StatusName"].Value.ToString()=="Done")
                {
                    MessageBox.Show("Nie można przywrócić zmarłego");
                }
                else {
                    var status = cb_status.Text;
                    var cb_query = "Select StatusID, StatusName from Status WHERE StatusName = '" + status.ToString() + "'";
                    var cb_tb_name = "Status";
                    var cb_ds = ConnectionConfig.select_querry(cb_query, cb_tb_name);
                    var new_status_index = Convert.ToInt32(cb_ds.Tables[0].Rows[0]["StatusID"].ToString());
                    var deceasedPersonIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DeceasedPersonID"].Value.ToString());
                    Operator_Menagment.Edit_DeceasedPersonStatus(deceasedPersonIndex, new_status_index);
                    Operator_Menagment.Edit_ColdRoom_status(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColdRoom"].Value.ToString()));
                }

            }

            var query = "SELECT CO.FuneralDate, DP.ColdRoom, DP.DeceasedPersonID, DP.Name, DP.Age, DP.DateOfBirth, DP.DateOfDeath, S.StatusName, DP.OtherDetails FROM CremationOrder CO JOIN DeceasedPerson DP ON CO.DeceasedPersonID = DP.DeceasedPersonID JOIN Status S ON DP.Status = S.StatusID ORDER BY DP.DeceasedPersonID DESC";
            var tb_name = "DeceasedPerson";
            var ds = ConnectionConfig.select_querry(query, tb_name);
            dataGridView1.DataSource = ds.Tables[tb_name];
            dataGridView1.Columns["DeceasedPersonID"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClearSelection();
        }
    }
}
