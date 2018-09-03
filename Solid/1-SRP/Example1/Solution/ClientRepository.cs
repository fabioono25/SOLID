using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Solid._1_SRP.Example1.Solution
{
    public class ClientRepository
    {
        //one responsability (insert client in database)
        //but one problem remains: don't must know about database - but important isolated
        //Repository Pattern
        public void AddClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "Test";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ... VALUES (@name...";

                cmd.Parameters.AddWithValue("name", client.Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
