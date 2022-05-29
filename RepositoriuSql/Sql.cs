using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp2.Models;
namespace RepositoriuSql
{
    internal class Sql
    {
        private string stringConnection;
        public Sql(string connectionString)
        {
            this.stringConnection = connectionString;
        }
        public bool tryLogin(string username, string password)
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            { connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Login WHERE userLogin = '" + username + "' AND userPassword= '"+password+"'" ;
    SqlDataAdapter adapter= new SqlDataAdapter(command.CommandText,connection);
                DataTable data =new  DataTable();
                adapter.Fill(data);
                if (data.Rows.Count==1)
                {
                    return true;
                }
                else return false;
                connection.Close();
            }} }}