using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class Employee_Menagment
    {
        public static void Add_Employee(Employee employee, int role_id)
        {
            var adp = new SqlDataAdapter();
            var insert_query = "Insert into Staff (Name, Role, PhoneNumber, EmailAddress, OtherDetails) values (@Name, @Role, @PhoneNumber, @EmailAddress, @OtherDetails)";
            var select_query = @"select * from staff";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            adp.InsertCommand = new SqlCommand(insert_query, ConnectionConfig.sql_Connection());

            var dsB = new DataSet();
            adp.Fill(dsB, "Staff");

            var newRow = dsB.Tables["Staff"].NewRow();
            newRow["Name"] = employee.Name;
            newRow["Role"] = role_id + 1;
            newRow["PhoneNumber"] = employee.Phone;
            newRow["EmailAddress"] = employee.Email;
            newRow["OtherDetails"] = employee.Other_details;
            dsB.Tables["Staff"].Rows.Add(newRow);

            adp.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.InsertCommand.Parameters.Add("@Role", SqlDbType.Int, 3, "Role");
            adp.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 100, "PhoneNumber");
            adp.InsertCommand.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 100, "EmailAddress");
            adp.InsertCommand.Parameters.Add("@OtherDetails", SqlDbType.NVarChar, 100, "OtherDetails");


            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "Staff");
                }
            }
        }

        public static void Edit_Emplyee(Employee employee, int employee_id, int role_id)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from staff where StaffID = @employee_id";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "update Staff SET Name = @Name, Role = @Role, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, OtherDetails = @OtherDetails WHERE StaffID = @StaffID";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@employee_id", employee_id);
            var dsB = new DataSet();
            adp.Fill(dsB, "Staff");

            var table = dsB.Tables["Staff"];
            table.Rows[0]["Name"] = employee.Name;
            table.Rows[0]["Role"] = role_id + 1;
            table.Rows[0]["PhoneNumber"] = employee.Phone;
            table.Rows[0]["EmailAddress"] = employee.Email;
            table.Rows[0]["OtherDetails"] = employee.Other_details;

            adp.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.UpdateCommand.Parameters.Add("@Role", SqlDbType.Int, 3, "Role");
            adp.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 100, "PhoneNumber");
            adp.UpdateCommand.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 100, "EmailAddress");
            adp.UpdateCommand.Parameters.Add("@OtherDetails", SqlDbType.NVarChar, 100, "OtherDetails");
            adp.UpdateCommand.Parameters.Add("@StaffID", SqlDbType.Int, 3).Value = employee_id;


            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "Staff");
                }
            }
        }

        public static void Delete_Employee(int employee_id)
        {

            var adp = new SqlDataAdapter();
            var select_query = "select * from Staff where StaffID = @employee_id";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var delete_query = "delete from Staff where StaffID = @employee_id";
            adp.DeleteCommand = new SqlCommand(delete_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@employee_id", employee_id);
            adp.DeleteCommand.Parameters.AddWithValue("@employee_id", employee_id);
            var dsB = new DataSet();
            adp.Fill(dsB, "Staff");

            var table = dsB.Tables["Staff"];
            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                row.Delete();

                if (dsB.HasChanges())
                {
                    var dsF = dsB.GetChanges();
                    if (dsF.HasErrors)
                    {
                        dsB.RejectChanges();
                    }
                    else
                    {
                        adp.Update(dsF, "Staff");
                    }
                }
            }
        }
    }
}
