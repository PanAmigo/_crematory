using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class CremationOrderManagement
    {
        public static void Add_CremationOrder(CremationOrder cremationOrder)
        {
            var adp = new SqlDataAdapter();
            var insert_query = "INSERT INTO CremationOrder ([CustomerID], [DeceasedPersonID], [StaffID], [OrderDate], [SpecialInstructions], [FuneralDate], [DeathCertificate], [CremationConsent]) VALUES (@CustomerID, @DeceasedPersonID, @StaffID, @OrderDate, @SpecialInstructions, @FuneralDate, @DeathCertificate, @CremationConsent);";
            var select_query = @"select * from CremationOrder";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            adp.InsertCommand = new SqlCommand(insert_query, ConnectionConfig.sql_Connection());

            var dsB = new DataSet();
            adp.Fill(dsB, "CremationOrder");

            var newRow = dsB.Tables["CremationOrder"].NewRow();
            newRow["CustomerID"] = cremationOrder.CustomerID;
            newRow["DeceasedPersonID"] = cremationOrder.DeceasedPersonID;
            newRow["StaffID"] = cremationOrder.StaffID;
            newRow["OrderDate"] = cremationOrder.OrderDate;
            newRow["SpecialInstructions"] = cremationOrder.SpecialInstructions;
            newRow["FuneralDate"] = cremationOrder.FuneralDate;
            newRow["DeathCertificate"] = cremationOrder.DeathCertificate;
            newRow["CremationConsent"] = cremationOrder.CremationConsent;

            dsB.Tables["CremationOrder"].Rows.Add(newRow);

            adp.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 100, "CustomerID");
            adp.InsertCommand.Parameters.Add("@DeceasedPersonID", SqlDbType.Int, 100, "DeceasedPersonID");
            adp.InsertCommand.Parameters.Add("@StaffID", SqlDbType.Int, 100, "StaffID");
            adp.InsertCommand.Parameters.Add("@OrderDate", SqlDbType.DateTime, 0, "OrderDate");
            adp.InsertCommand.Parameters.Add("@SpecialInstructions", SqlDbType.NVarChar, 100, "SpecialInstructions");
            adp.InsertCommand.Parameters.Add("@FuneralDate", SqlDbType.DateTime, 0, "FuneralDate");
            adp.InsertCommand.Parameters.Add("@DeathCertificate", SqlDbType.Bit, 100, "DeathCertificate");
            adp.InsertCommand.Parameters.Add("@CremationConsent", SqlDbType.Bit, 100, "CremationConsent");


            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "CremationOrder");
                }
            }
        }

        public static void Edit_CremationOrder(CremationOrder cremationOrder, int orderID)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from CremationOrder where OrderID = @OrderID";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "UPDATE CremationOrder SET CustomerID = @CustomerID, DeceasedPersonID = @DeceasedPersonID, StaffID = @StaffID, OrderDate = @OrderDate, SpecialInstructions = @SpecialInstructions, FuneralDate = @FuneralDate, DeathCertificate = @DeathCertificate, CremationConsent = @CremationConsent WHERE OrderID = @OrderID";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@OrderID", orderID);
            var dsB = new DataSet();
            adp.Fill(dsB, "CremationOrder");

            var table = dsB.Tables["CremationOrder"];

            table.Rows[0]["CustomerID"] = cremationOrder.CustomerID;
            table.Rows[0]["DeceasedPersonID"] = cremationOrder.DeceasedPersonID;
            table.Rows[0]["StaffID"] = cremationOrder.StaffID;
            table.Rows[0]["OrderDate"] = cremationOrder.OrderDate;
            table.Rows[0]["SpecialInstructions"] = cremationOrder.SpecialInstructions;
            table.Rows[0]["FuneralDate"] = cremationOrder.FuneralDate;
            table.Rows[0]["DeathCertificate"] = cremationOrder.DeathCertificate;
            table.Rows[0]["CremationConsent"] = cremationOrder.CremationConsent; 

            adp.UpdateCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 100, "CustomerID");
            adp.UpdateCommand.Parameters.Add("@DeceasedPersonID", SqlDbType.NVarChar, 100, "DeceasedPersonID");
            adp.UpdateCommand.Parameters.Add("@StaffID", SqlDbType.NVarChar, 100, "StaffID");
            adp.UpdateCommand.Parameters.Add("@OrderDate", SqlDbType.DateTime, 0, "OrderDate");
            adp.UpdateCommand.Parameters.Add("@SpecialInstructions", SqlDbType.NVarChar, 1000, "SpecialInstructions");
            adp.UpdateCommand.Parameters.Add("@FuneralDate", SqlDbType.DateTime, 0, "FuneralDate");
            adp.UpdateCommand.Parameters.Add("@DeathCertificate", SqlDbType.NVarChar, 100, "DeathCertificate");
            adp.UpdateCommand.Parameters.Add("@CremationConsent", SqlDbType.NVarChar, 100, "CremationConsent");

            adp.UpdateCommand.Parameters.AddWithValue("@OrderID", orderID);

            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "CremationOrder");
                }
            }

        }

        public static void Edit_ColdRoom_status_to_occupied(int ColdRoomId)
        {
            var adp = new SqlDataAdapter();
            var select_query = "SELECT * FROM ColdRoom WHERE ColdRoomID = @ColdRoomId";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@ColdRoomId", ColdRoomId);

            var update_query = "UPDATE ColdRoom SET Status = 1 WHERE ColdRoomID = @ColdRoomId";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.UpdateCommand.Parameters.AddWithValue("@ColdRoomId", ColdRoomId);
            adp.UpdateCommand.Parameters.Add("@Status", SqlDbType.Int, 1, "Status");
            adp.UpdateCommand.Parameters["@Status"].Value = 1;

            var dsB = new DataSet();
            adp.Fill(dsB, "ColdRoom");

            var table = dsB.Tables["ColdRoom"];
            table.Rows[0]["ColdRoomId"] = ColdRoomId;

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
