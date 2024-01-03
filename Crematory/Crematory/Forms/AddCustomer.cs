using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void bt_back_to_addCustomer_Click(object sender, EventArgs e)
        {
            //var addOrderForm = new addOrder();
            //addOrderForm.Show();
            this.Hide();
        }

        private void bt_add_customer_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_phoneNumber.Text.Trim(), @"^\d{3} \d{3} \d{3}$"))
            {
                MessageBox.Show("Please enter a valid PL phone number.");
            }
            if (!Regex.IsMatch(txt_email.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email is not in proper format.");
            }
            else
            {
                var customer = new Customer(txt_Name.Text, txt_Adress.Text, txt_phoneNumber.Text, txt_email.Text);
                Customer_Menagment.Add_Customer(customer);

                // Relead customer comboBox
                var addOrder = new addOrder();
                addOrder.ReloadCustomerComboBox();

                this.Hide();
            }
            
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
