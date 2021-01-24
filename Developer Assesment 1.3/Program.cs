using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Developer_Assesment_1._3
{
    class Program
    {
        //i make the string out here so its easier to change, rather than changing it multiple areas in the code.
        static string connectionString = "Data Source=DESKTOP-ULJRT69;Initial Catalog=IntelligentSystemsTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            //insert the values in the database
            insert();
            //get the values out of the database
            Get();

            //wait for user input before closing
            Console.ReadKey();
            //method to empty the DB while not needed i like to have it to make sure i can test on an empty DB when performing the insert method;
            emptyTable();
        }

        static void insert() 
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that inserts
            string sql = "INSERT INTO TestTable (Integer, String, DateTime)" +
            "VALUES( 45021, 'Hello Database!', '2013-12-31 23:59');";
            
            //opening the connection, and executing the insert query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            sqlCon.Close();
        }

        static void Get()
        {
            //variables to insert values into
            int intFromDB = -1;
            DateTime dateFromDB = new DateTime();
            string stringFromDB = "";

            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL to select
            string sql = "SELECT TOP 1 * FROM TestTable ORDER BY _ID DESC";

            //opening the connection, and executing the read query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    //cast the values from the DB into specific variables
                    intFromDB = (int)reader["Integer"];
                    stringFromDB = (string)reader["String"];
                    dateFromDB = (DateTime)reader["DateTime"];

                    //an alternative was to use "reader["DB Column name"].GetType().Name" to figure out the types, then assign them accordingly.
                }
            }
            //close the connection
            sqlCon.Close();

            //print the results, just so there is something visible for the user
            Console.WriteLine("Int: " + intFromDB);
            Console.WriteLine("String: " + stringFromDB);
            Console.WriteLine("DateTime: " + dateFromDB);
        }

        static void emptyTable()
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand command;

            //typing in the SQL that will delete from the table
            string sql = "DELETE FROM TestTable";

            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
