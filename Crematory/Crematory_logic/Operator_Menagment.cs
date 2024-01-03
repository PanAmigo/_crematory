using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class Operator_Menagment
    {
        public static void Edit_DeceasedPersonStatus(int DeceasedPersonID, int status_id)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from DeceasedPerson where DeceasedPersonID = @DeceasedPersonID";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "UPDATE DeceasedPerson SET Status = @Status WHERE DeceasedPersonID = @DeceasedPersonID";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@DeceasedPersonID", DeceasedPersonID);
            var dsB = new DataSet();
            adp.Fill(dsB, "DeceasedPerson");

            var table = dsB.Tables["DeceasedPerson"];
            table.Rows[0]["Status"] = status_id;

            adp.UpdateCommand.Parameters.Add("@Status", SqlDbType.Int, 3, "Status");
            adp.UpdateCommand.Parameters.AddWithValue("@DeceasedPersonID", DeceasedPersonID);


            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "DeceasedPerson");
                }
            }
        }
        public static void Edit_ColdRoom_status(int ColdRoomId)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from ColdRoom where ColdRoomID = @ColdRoomId";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "UPDATE ColdRoom SET Status = 0 WHERE ColdRoomID = @ColdRoomId";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@ColdRoomId", ColdRoomId);
            var dsB = new DataSet();
            adp.Fill(dsB, "ColdRoom");

            var table = dsB.Tables["ColdRoom"];
            table.Rows[0]["ColdRoomId"] = ColdRoomId;

            adp.UpdateCommand.Parameters.Add("@ColdRoomId", SqlDbType.Bit, 1, "ColdRoomId");
            adp.UpdateCommand.Parameters.AddWithValue("@ColdRoomId", ColdRoomId);


            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "ColdRoom");
                }
            }
        }
    }
}
