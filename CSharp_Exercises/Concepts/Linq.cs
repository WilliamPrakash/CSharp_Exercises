using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;


namespace CSharp_Exercises.Concepts
{
    internal class Linq
    {
        private SqlConnection connection;
        public Linq()
        {
            // Get SQL connection string and create connection
            GrabLocalDatabaseCredentials credentialGrabber = new GrabLocalDatabaseCredentials();
            connection = new SqlConnection(credentialGrabber.sqlConnStr);
        }

        public void TestConnection()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from master.dbo.Employees", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(3));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
