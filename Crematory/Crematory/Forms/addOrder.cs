using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory.Forms
{
    public partial class addOrder : Form
    {
        public addOrder()
        {
            InitializeComponent();
        }

        private void bt_back_to_Contract_Click(object sender, EventArgs e)
        {
            var contractForm = new Contract();
            contractForm.Show();
            this.Hide();
        }


        private void bt_add_customer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomer();
            addCustomerForm.Show();
            //this.Hide();
        }
        private void addOrder_Load(object sender, EventArgs e)
        {
            //Load Customer comboBox 
            ReloadCustomerComboBox();

            // Load Operator comboBox
            var cb_query_staff = "Select StaffID, Name from Staff where Role = 3";
            var cb_tb_staff = "Staff";
            var cb_ds_op = ConnectionConfig.select_querry(cb_query_staff, cb_tb_staff);
            cBox_Staff.DataSource = cb_ds_op.Tables[cb_tb_staff].DefaultView;
            cBox_Staff.DisplayMember = cb_tb_staff;
            cBox_Staff.ValueMember = "Name";

            // Load ColdRoom comboBox
            var cb_query_coldRoom = "Select ColdRoomID, Status from ColdRoom where Status = 0";
            var cb_tb_coldRoom = "ColdRoom";
            var cb_ds_cR = ConnectionConfig.select_querry(cb_query_coldRoom, cb_tb_coldRoom);
            cBox_ColdRoom.DataSource = cb_ds_cR.Tables[cb_tb_coldRoom].DefaultView;
            cBox_ColdRoom.DisplayMember = cb_tb_coldRoom;
            cBox_ColdRoom.ValueMember = "ColdRoomID";
            
        }

        public void ReloadCustomerComboBox()
        {
            var cb_query_customer = "Select CustomerID, Name from Customer";
            var cb_tb_customer = "Customer";
            var cb_ds = ConnectionConfig.select_querry(cb_query_customer, cb_tb_customer);
            //var customers = new List<string>();

            cBox_Customer.DataSource = cb_ds.Tables[cb_tb_customer].DefaultView;
            cBox_Customer.DisplayMember = cb_tb_customer;
            cBox_Customer.ValueMember = "Name";
        }
        private void bt_add_order_Click(object sender, EventArgs e)
        {
            var query_free = "SELECT ColdRoomID, Status from ColdRoom where Status = 0";
            var tb_name_free = "ColdRoom";
            var ds_free = ConnectionConfig.select_querry(query_free, tb_name_free);


            if (ds_free.Tables[0].Rows.Count > 0)
            {
                string inputnName = $"{txt_DP_Name.Text.Trim()} {txt_DP_Surname.Text.Trim()}";
                // Insert new decreased person to database
                int baseStatus = 1;
                var decreasedPerson = new DecreasedPerson(inputnName, Convert.ToInt32(txt_DP_Age.Text), dateTP_DP_birthDate.Value, dateTP_DP_deathDate.Value, baseStatus, Convert.ToInt32(cBox_ColdRoom.Text), rich_txt_DP_Details.Text);
                //Convert.ToInt32(cBox_ColdRoom.Text)
                DecreasedPerson_Management.Add_DecreasedPerson(decreasedPerson);

                // get inserted id of Decreased person
                int insertedDecreasedPerson = DecreasedPerson_Management.GetLastRecordInsertedID();

                // Insert new order to CremationOrder
                DateTime dateTimeNow = DateTime.Now;

                var cb_query_staff = "Select StaffID, Name from Staff where Role = 3";
                var cb_tb_staff = "Staff";
                var cb_ds_op_s = ConnectionConfig.select_querry(cb_query_staff, cb_tb_staff);
                var table_staff = cb_ds_op_s.Tables[0];
                var index_staff = Convert.ToInt32(table_staff.Rows[cBox_Staff.SelectedIndex]["StaffID"]);


                var cb_query_customer = "Select CustomerID, Name from Customer";
                var cb_tb_customer = "Customer";
                var cb_ds_c = ConnectionConfig.select_querry(cb_query_customer, cb_tb_customer);
                var table_customer = cb_ds_c.Tables[0];
                var index_customer = Convert.ToInt32(table_customer.Rows[cBox_Customer.SelectedIndex]["CustomerID"]);

            
                var cremationOrder = new CremationOrder(index_customer, insertedDecreasedPerson, index_staff, dateTimeNow, rich_txt_OD_SpetialInstructions.Text, dateTP_OD_funeralDate.Value, chB_death_certificate.Checked, chB_creamtory_consent.Checked);

                CremationOrderManagement.Add_CremationOrder(cremationOrder);

                //Change status of cold room
                CremationOrderManagement.Edit_ColdRoom_status_to_occupied(Convert.ToInt32(cBox_ColdRoom.Text));
                

                var contract = new Contract();
                contract.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cold room has no free space");
            }
        }

    }
}
