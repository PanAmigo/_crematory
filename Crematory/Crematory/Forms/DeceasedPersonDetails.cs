using Crematory_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crematory.Forms
{
    public partial class DeceasedPersonDetails : Form
    {
        public DeceasedPersonDetails(int decreasedPersonId)
        {
            InitializeComponent();
            
            var cb_query_decreasedPerson = $"Select * from DeceasedPerson where DeceasedPersonID = {decreasedPersonId}";
            var cb_tb_decreasedPerson = "DeceasedPerson";
            var ds = ConnectionConfig.select_querry(cb_query_decreasedPerson, cb_tb_decreasedPerson);

            var decreasedPerson = ds.Tables[0];

            txt_DecreasedP_ID.Text = decreasedPerson.Rows[0]["DeceasedPersonID"].ToString();
            txt_DecreasedP_Name.Text = decreasedPerson.Rows[0]["Name"].ToString();
            txt_DecreasedP_Age.Text = decreasedPerson.Rows[0]["Age"].ToString();
            dateTP_DP_birthDate.Text = decreasedPerson.Rows[0]["DateOfBirth"].ToString();
            dateTP_DP_deathDate.Text = decreasedPerson.Rows[0]["DateOfDeath"].ToString();
            //cBox_Status.Text = decreasedPerson.Rows[0]["Status"].ToString();
            //cBox_ColdRoomNumber.Text = decreasedPerson.Rows[0]["ColdRoom"].ToString();
            rich_txt_DP_Details.Text = decreasedPerson.Rows[0]["OtherDetails"].ToString();

           

        }

        private void bt_backToContract_Click(object sender, EventArgs e)
        {
            //var contractForm = new Contract();
            //contractForm.Show();
            this.Hide();
        }
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            var decreasedPersonID = Convert.ToInt32(txt_DecreasedP_ID.Text);
            var decPer = new DecreasedPerson(txt_DecreasedP_Name.Text, Convert.ToInt32(txt_DecreasedP_Age.Text), dateTP_DP_birthDate.Value, dateTP_DP_deathDate.Value, rich_txt_DP_Details.Text);
            DecreasedPerson_Management.Edit_DecreasedPerson(decPer, decreasedPersonID);
            this.Hide();
        }

        private void DeceasedPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void cBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
