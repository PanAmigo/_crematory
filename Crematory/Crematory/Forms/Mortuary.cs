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
    public partial class Mortuary : Form
    {
        public Mortuary()
        {
            InitializeComponent();
        }

        private void bt_backToMain_Click(object sender, EventArgs e)
        {
            var crematoryForm = new CrematoryForm();
            crematoryForm.Show();
            this.Hide();
        }

        private void Mortuary_Load(object sender, EventArgs e)
        {
            var query = "SELECT DeceasedPersonID, Name, Age, DateOfBirth, DateOfDeath, DeceasedPerson.Status, ColdRoom, OtherDetails FROM DeceasedPerson JOIN ColdRoom ON DeceasedPerson.ColdRoom = ColdRoom.ColdRoomID WHERE ColdRoom.Status = 1 and DeceasedPerson.Status in (1,2)";
            var tb_name = "DeceasedPerson";
            var ds = ConnectionConfig.select_querry(query, tb_name);
            dGV_occupied.DataSource = ds.Tables[tb_name];
            dGV_occupied.Columns["DeceasedPersonID"].Visible = false;
            dGV_occupied.RowHeadersVisible = false;
            dGV_occupied.ClearSelection();

            var query_free = "SELECT ColdRoomID, Status from ColdRoom where Status = 0";
            var tb_name_free = "ColdRoom";
            var ds_free = ConnectionConfig.select_querry(query_free, tb_name_free);
            dGV_free.DataSource = ds_free.Tables[tb_name_free];
            dGV_free.RowHeadersVisible = false;
            dGV_free.ClearSelection();
        }
    }
}
