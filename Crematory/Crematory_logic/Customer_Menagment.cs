using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class Customer_Menagment
    {
       public static void Add_Customer(Customer customer)
       {
            var adp = new SqlDataAdapter();
            var insert_query = "Insert into Customer (Name, Address, PhoneNumber, EmailAddress) values (@Name, @Address, @PhoneNumber, @EmailAddress)";
            var select_query = @"select * from Customer";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            adp.InsertCommand = new SqlCommand(insert_query, ConnectionConfig.sql_Connection());

            var dsB = new DataSet();
            adp.Fill(dsB, "Customer");

            var newRow = dsB.Tables["Customer"].NewRow();
            newRow["Name"] = customer.Name;
            newRow["Address"] = customer.Address;
            newRow["PhoneNumber"] = customer.Phone;
            newRow["EmailAddress"] = customer.Email;
            dsB.Tables["Customer"].Rows.Add(newRow);

            adp.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.InsertCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 100, "Address");
            adp.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 100, "PhoneNumber");
            adp.InsertCommand.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 100, "EmailAddress");

            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "Customer");
                }
            }
       }
        public static void Edit_Customer(Customer customer, int customerID)
        {
            var adp = new SqlDataAdapter();
            var select_query = "select * from Customer where CustomerID = @CustomerID";
            adp.SelectCommand = new SqlCommand(select_query, ConnectionConfig.sql_Connection());
            var update_query = "update Customer SET Name = @Name, Address = @Address, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress WHERE CustomerID = @CustomerID";
            adp.UpdateCommand = new SqlCommand(update_query, ConnectionConfig.sql_Connection());
            adp.SelectCommand.Parameters.AddWithValue("@CustomerID", customerID);
            var dsB = new DataSet();
            adp.Fill(dsB, "Customer");

            var table = dsB.Tables["Customer"];
            table.Rows[0]["Name"] = customer.Name;
            table.Rows[0]["Address"] = customer.Address;
            table.Rows[0]["PhoneNumber"] = customer.Phone;
            table.Rows[0]["EmailAddress"] = customer.Email;

            adp.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            adp.UpdateCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 100, "Address");
            adp.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 100, "PhoneNumber");
            adp.UpdateCommand.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 100, "EmailAddress");

            adp.UpdateCommand.Parameters.AddWithValue("@CustomerID", customerID);

            if (dsB.HasChanges())
            {
                var dsF = dsB.GetChanges();
                if (dsF.HasErrors)
                {
                    dsB.RejectChanges();
                }
                else
                {
                    adp.Update(dsF, "Customer");
                }
            }
        }
    }
}
