using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crematory_logic
{
    public static class ConnectionConfig
    {
        

        //static SqlConnection con = new SqlConnection();
        //con.ConnectionString = @"Data Source=DESKTOP-KHBU506\MSSQLSERVER01;Initial Catalog=crematory_database;Integrated Security=True";
        //con.ConnectionString = @"Data Source=MICHAL;Initial Catalog=crematory_database;Integrated Security=True";

        public static SqlConnection sql_Connection() 
        {
            var conn = new SqlConnection();
            string con_string;
            //var pc_name = System.Windows.Forms.SystemInformation.ComputerName;
            var pc_name = System.Environment.MachineName;
            //Console.WriteLine(pc_name);
            //Console.ReadLine();
            //"DESKTOP-KHBU506"
            if (pc_name == "DESKTOP-KHBU506")
            {
                conn.ConnectionString = @"Data Source=DESKTOP-KHBU506\MSSQLSERVER01;Initial Catalog=crematory_database;Integrated Security=True";
            }
            else if (pc_name == "MICHAL")
            {
                conn.ConnectionString = @"Data Source=MICHAL;Initial Catalog=crematory_database;Integrated Security=True";
            }
            else
            {
                return null;
            }
            return conn;
        }

        public static DataSet select_querry(string query, string tb_name)
        {
            var con = ConnectionConfig.sql_Connection();
            var cmd = new SqlCommand(query);
            var ds = new DataSet();
            using (con)
            {
                var sqlda = new SqlDataAdapter();
                cmd.Connection = con;
                sqlda.SelectCommand = cmd;
                sqlda.TableMappings.Add("Table", tb_name);
                sqlda.Fill(ds);
            }
            return ds;
        }
    }
}
