using Crematory.Forms;
using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void bt_backToMain_Click(object sender, EventArgs e)
        {
            var crematoryForm = new CrematoryForm();
            crematoryForm.Show();
            this.Hide();
        }

        private void bt_add_order_Click(object sender, EventArgs e)
        {
            var addOrderForm = new addOrder();
            addOrderForm.Show();
            this.Hide();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            // Load dataGreedView
            var query = "Select CremOr.[OrderID] ,\r\n\t\t CremOr.[CustomerID],\r\n\t\t CremOr.[DeceasedPersonID],\r\n\t\t CremOr.[StaffID],\r\n\t\t Cus.[Name] as CustomerName,\r\n\t\t DecP.[Name] as DecreasedPersonName, \r\n\t\t DecP.[Status] as StatusOfDecreasedPerson, \r\n\t\t s.[Name]  as StaffName,\r\n\t\t CremOr.[OrderDate],\r\n\t\t CremOr.[SpecialInstructions],\r\n\t\t CremOr.[FuneralDate],\r\n\t\t CremOr.[DeathCertificate],\r\n\t\t CremOr.[CremationConsent]\r\n  from CremationOrder as CremOr\r\n  Inner Join Customer as Cus\r\n  On CremOr.CustomerID = Cus.CustomerID\r\n  Inner Join DeceasedPerson as DecP\r\n  On CremOr.DeceasedPersonID = DecP.DeceasedPersonID\r\n  Inner Join Staff as s\r\n  On CremOr.StaffID = s.StaffID";
            var tb_name = "Contract";
            var ds = ConnectionConfig.select_querry(query, tb_name);
            dataGridView1.DataSource = ds.Tables[tb_name];
            dataGridView1.Columns["OrderID"].Visible = false;
            dataGridView1.Columns["CustomerID"].Visible = false;
            dataGridView1.Columns["DeceasedPersonID"].Visible = false;
            dataGridView1.Columns["StaffId"].Visible = false;
            //dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClearSelection();



            // Load operator comboBox
            var cb_query_staff = "Select StaffID, Name from Staff where StaffID = 3";
            var cb_tb_staff = "Staff";
            var cb_ds_op = ConnectionConfig.select_querry(cb_query_staff, cb_tb_staff);
            cBox_Staff.DataSource = cb_ds_op.Tables[cb_tb_staff].DefaultView;
            cBox_Staff.DisplayMember = cb_tb_staff;
            cBox_Staff.ValueMember = "Name";
        }

        private void dataGridView1_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0)
                {
                    cBox_Staff.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    dateTP_OrderDate.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    dateTP_DP_funeralDate.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
                    chB_death_certificate.Checked = (bool)dataGridView1.Rows[index].Cells[11].Value;
                    chB_creamtory_consent.Checked = (bool)dataGridView1.Rows[index].Cells[12].Value;
                    txt_spetialInstructions.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
                    
                }
            }
        }

        private void bt_show_customer_details_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0)
                {
                    int customerIndex = (int)dataGridView1.Rows[index].Cells[1].Value;

                    var customerDetailsForm = new CustomerDetails(customerIndex);
                    customerDetailsForm.ShowDialog();
                    //this.Hide();
                }
            }
        }
        private void bt_show_deceasedPerson_details_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0)
                {
                    int decreasedPersonIndex = (int)dataGridView1.SelectedRows[0].Cells[2].Value;

                    var deceasedPersonDetailsForm = new DeceasedPersonDetails(decreasedPersonIndex); ;
                    deceasedPersonDetailsForm.Show();
                    //this.Hide();
                }

            }


            
        }

        private void bt_editOrderDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0)
                {
                    int orederID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                    var cb_query_staff = "Select StaffID, Name from Staff where Role = 3";
                    var cb_tb_staff = "Staff";
                    var cb_ds_op_s = ConnectionConfig.select_querry(cb_query_staff, cb_tb_staff);
                    var table_staff = cb_ds_op_s.Tables[0];
                    var index_staff = Convert.ToInt32(table_staff.Rows[cBox_Staff.SelectedIndex]["StaffID"]);

                    var customer_ID = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                    var decreasedPerson_ID = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
                    

                    var cremationOrder = new CremationOrder(customer_ID, decreasedPerson_ID, index_staff, dateTP_OrderDate.Value, txt_spetialInstructions.Text, dateTP_DP_funeralDate.Value, chB_death_certificate.Checked, chB_creamtory_consent.Checked);

                    CremationOrderManagement.Edit_CremationOrder(cremationOrder, orederID);

                }
                Contract_Load(Owner, e);
            }
        }
    }
}
