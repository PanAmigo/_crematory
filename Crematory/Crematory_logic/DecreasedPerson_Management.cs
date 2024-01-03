using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Crematory_logic
{
    public class DecreasedPerson_Management
    {
        public static void Add_DecreasedPerson(DecreasedPerson decreasedPerson)
        {
            var adp = new SqlDataAdapter();
            var insert_query = "Insert into DeceasedPerson([Name], [Age], [DateOfBirth], [DateOfDeath], [Status], [ColdRoom], [OtherDetails]) values (@Name, @Age, @DateOfBirth, @DateOfDeath, @Status, @ColdRoom, @OtherDetails)";
            var select_query = @"select * from DeceasedPerson";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            adp.InsertCommand = new SqlCommand(insert_query, ConnectionConfig.sql_Connection());

            var dsB = new DataSet();
            adp.Fill(dsB, "DeceasedPerson");

            var newRow = dsB.Tables["DeceasedPerson"].NewRow();
            newRow["Name"] = decreasedPerson.Name;
            newRow["Age"] = decreasedPerson.Age;
            newRow["DateOfBirth"] = decreasedPerson.DateOfBirth;
            newRow["DateOfDeath"] = decreasedPerson.DateOfDeath;
            newRow["Status"] = decreasedPerson.Status;
            newRow["ColdRoom"] = decreasedPerson.ColdRoom;
            newRow["OtherDetails"] = decreasedPerson.OtherDetails;
            dsB.Tables["DeceasedPerson"].Rows.Add(newRow);

            adp.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.InsertCommand.Parameters.Add("@Age", SqlDbType.Int, 100, "Age");
            adp.InsertCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date, 100, "DateOfBirth");
            adp.InsertCommand.Parameters.Add("@DateOfDeath", SqlDbType.Date, 100, "DateOfDeath");
            adp.InsertCommand.Parameters.Add("@Status", SqlDbType.Int, 100, "Status");
            adp.InsertCommand.Parameters.Add("@ColdRoom", SqlDbType.Int, 100, "ColdRoom");
            adp.InsertCommand.Parameters.Add("@OtherDetails", SqlDbType.NVarChar, 255, "OtherDetails");

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

        public static int GetLastRecordInsertedID()
        {
            var adp = new SqlDataAdapter();
            var select_query = @"select * from DeceasedPerson";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());

            var dsB = new DataSet();
            adp.Fill(dsB, "DeceasedPerson");

            var lastRecordInsertedID = (int)dsB.Tables[("DeceasedPerson")].AsEnumerable().Last().ItemArray[0];

            return lastRecordInsertedID;
        }


        public static void Edit_DecreasedPerson(DecreasedPerson decreasedPerson, int decreasedPersonID)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from DeceasedPerson where DeceasedPersonID = @DeceasedPersonID";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "update DeceasedPerson SET Name = @Name, Age = @Age, DateOfBirth = @DateOfBirth, DateOfDeath = @DateOfDeath, OtherDetails = @OtherDetails WHERE DeceasedPersonID = @DeceasedPersonID";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@DeceasedPersonID", decreasedPersonID);
            var dsB = new DataSet();
            adp.Fill(dsB, "DeceasedPerson");

            var table = dsB.Tables["DeceasedPerson"];

            table.Rows[0]["Name"] = decreasedPerson.Name;
            table.Rows[0]["Age"] = decreasedPerson.Age;
            table.Rows[0]["DateOfBirth"] = decreasedPerson.DateOfBirth;
            table.Rows[0]["DateOfDeath"] = decreasedPerson.DateOfDeath;
            table.Rows[0]["OtherDetails"] = decreasedPerson.OtherDetails;
            


            adp.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.UpdateCommand.Parameters.Add("@Age", SqlDbType.Int, 100, "Age");
            adp.UpdateCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date, 100, "DateOfBirth");
            adp.UpdateCommand.Parameters.Add("@DateOfDeath", SqlDbType.Date, 100, "DateOfDeath");
            adp.UpdateCommand.Parameters.Add("@OtherDetails", SqlDbType.NVarChar, 255, "OtherDetails");

            adp.UpdateCommand.Parameters.AddWithValue("@DeceasedPersonID", decreasedPersonID);

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

    }
}
