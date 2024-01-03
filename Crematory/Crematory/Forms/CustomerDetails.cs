using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory.Forms
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails(int selectedCustomerID)
        {
            InitializeComponent();

            var cb_query_Customer = $"Select * from Customer where CustomerID = {selectedCustomerID}";
            var cb_tb_Customer = "Customer";
            var ds = ConnectionConfig.select_querry(cb_query_Customer, cb_tb_Customer);

            var customer = ds.Tables[0];

            txt_CustomerID.Text = customer.Rows[0]["CustomerID"].ToString();
            txt_CustmerName.Text = customer.Rows[0]["Name"].ToString();
            txt_CustomerPhone.Text = customer.Rows[0]["PhoneNumber"].ToString();
            txt_CustomerEmail.Text = customer.Rows[0]["EmailAddress"].ToString();
            txt_CustomerAdress.Text = customer.Rows[0]["Address"].ToString();

        }

        private void bt_EditCustomer_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_CustomerPhone.Text.Trim(), @"^\d{3} \d{3} \d{3}$"))
            {
                MessageBox.Show("Please enter a valid PL phone number.");
            }
            if (!Regex.IsMatch(txt_CustomerEmail.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email is not in proper format.");
            }
            else
            {
                var customerID = Convert.ToInt32(txt_CustomerID.Text);
                var customer = new Customer(txt_CustmerName.Text, txt_CustomerAdress.Text, txt_CustomerPhone.Text, txt_CustomerEmail.Text);
                Customer_Menagment.Edit_Customer(customer, customerID);

                MessageBox.Show("Edit success.");
                this.Hide();
            }           
        }

        private void bt_backToContract_Click(object sender, EventArgs e)
        {
            //var contractForm = new Contract();
            //contractForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //fail click
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //fail click
        }

        
    }
}
