using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crematory_logic;

namespace Crematory
{
    public partial class employeeManagment : Form
    {
        public employeeManagment()
        {
            InitializeComponent();
        }

        private void bt_backToMain_Click(object sender, EventArgs e)
        {
            var crematoryForm = new CrematoryForm();
            crematoryForm.Show();
            this.Hide();
        }

        private void bt_add_employee_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_PhoneNumber.Text.Trim(), @"^\d{3} \d{3} \d{3}$"))
            {
                MessageBox.Show("Please enter a valid PL phone number.");
            }
            if (!Regex.IsMatch(txt_Email.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email is not in proper format.");               
            }
            else
            {
                if(txt_Surname.Text.Trim().Length == 0)
                {
                    txt_Surname.Text = "";
                }

                string inputnName = $"{txt_Name.Text.Trim()} {txt_Surname.Text.Trim()}";

                var employe = new Employee(inputnName, txt_Surname.Text, txt_PhoneNumber.Text, txt_Email.Text, txt_OtherDetails.Text);
                var role_id = cBox_Role.SelectedIndex;
                Employee_Menagment.Add_Employee(employe, role_id);

                MessageBox.Show("Insert success.");
                employeeManagment_Load(Owner, e);
            }
        }

        private void employeeManagment_Load(object sender, EventArgs e)
        {
            var query = "SELECT StaffID, Name, s.JobTitle, PhoneNumber, EmailAddress, OtherDetails from Staff as st Inner Join StaffRoles as s On st.Role = s.StaffRoleID";
            var tb_name = "Employee";
            var ds = ConnectionConfig.select_querry(query, tb_name);
            dataGridView1.DataSource = ds.Tables[tb_name];
            dataGridView1.Columns["StaffId"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClearSelection();


            var cb_query = "Select JobTitle from StaffRoles";
            var cb_tb_name = "StaffRoles";
            var cb_ds = ConnectionConfig.select_querry(cb_query, cb_tb_name);
            var roles = new List<string>();

            cBox_Role.DataSource = cb_ds.Tables[cb_tb_name].DefaultView;
            cBox_Role.DisplayMember = cb_tb_name;
            cBox_Role.ValueMember = "JobTitle";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0)
                {
                    string inputNameSurname = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    string[] splitInput = inputNameSurname.Split(' ');

                    txt_Name.Text = splitInput[0];
                    txt_Surname.Text = string.Join(" ", splitInput.Skip(1));

                    txt_PhoneNumber.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    txt_Email.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    txt_OtherDetails.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    cBox_Role.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                }
            }
        }

        private void bt_edit_employee_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_PhoneNumber.Text.Trim(), @"^\d{3} \d{3} \d{3}$"))
            {
                MessageBox.Show("Please enter a valid PL phone number.");
            }
            if (!Regex.IsMatch(txt_Email.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email is not in proper format.");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var employe = new Employee(txt_Name.Text, txt_Surname.Text, txt_PhoneNumber.Text, txt_Email.Text, txt_OtherDetails.Text);
                    var employe_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells["StaffId"].Value.ToString());
                    var role_id = cBox_Role.SelectedIndex;
                    Employee_Menagment.Edit_Emplyee(employe, employe_id, role_id);

                    MessageBox.Show("Edit success.");
                    employeeManagment_Load(Owner, e);
                }
            }
        }

        private void bt_delete_employee_Click(object sender, EventArgs e)
        {
            var selectedOption = MessageBox.Show("Are you sure you want to remove an employee?", "Confirmation of removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(selectedOption == DialogResult.Yes)
            {

                if (dataGridView1.SelectedRows.Count>0)
                {
                    var employe_id = Int32.Parse(dataGridView1.SelectedRows[0].Cells["StaffId"].Value.ToString());
                    Employee_Menagment.Delete_Employee(employe_id);
                    employeeManagment_Load(Owner, e);
                    txt_Name.Text = "";
                    txt_Surname.Text = "";
                    txt_PhoneNumber.Text = "";
                    txt_Email.Text = "";
                    txt_OtherDetails.Text = "";
                }

            }
        }
    }
}
