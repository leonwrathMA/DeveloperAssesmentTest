using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeveloperAssesment_1._4
{
    public class Controller
    {
        //i make the string out here so its easier to change, rather than changing it multiple areas in the code.
        private string connectionString = "Data Source=DESKTOP-ULJRT69;Initial Catalog=IntelligentSystemsLibraryTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void ReturnBook(int ISBN, int LibNum)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that is needed to return a book
            string sql = "UPDATE BookTable " +
            string.Format("SET LibraryUserNumber= NULL WHERE _id=(SELECT TOP 1 _id FROM BookTable WHERE ISBNNumber={0} AND LibraryUserNumber={1} ORDER BY _id)", ISBN, LibNum);

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            //close the connection
            sqlCon.Close();
        }

        public void RentBook(int LibNum, int ISBN)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that is needed to rent a book
            string sql = "UPDATE BookTable " +
            string.Format("SET LibraryUserNumber={0} WHERE _id=(SELECT TOP 1 _id FROM BookTable WHERE ISBNNumber={1} AND LibraryUserNumber IS null ORDER BY _id)", LibNum, ISBN);

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            //close the connection
            sqlCon.Close();
        }

        public void RegUser(string Name, int LibNum)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that is needed to register a user
            string sqlInsert = "INSERT INTO UserTable (name, libUserNumber)" +
            string.Format("VALUES('{0}', {1});", Name, LibNum);
            string sql = string.Format("IF NOT EXISTS(SELECT * FROM UserTable WHERE libUserNumber = {0}) " + sqlInsert, LibNum);

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            //close the connection
            sqlCon.Close();
        }

        public void RegBook(string Title, string Author, int ISBN)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            
            SqlCommand command;

            //typing in the SQL that is needed to register a book in the info table
            string sqlInsert = "INSERT INTO BookInfoTable (title, author, ISBNNumber)" +
            string.Format("VALUES('{0}', '{1}', {2});", Title, Author, ISBN);

            string sql = string.Format("IF NOT EXISTS(SELECT * FROM BookInfoTable WHERE ISBNNumber = {0}) " + sqlInsert, ISBN);

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();

            //typing in the SQL that is needed to register a book in the book table
            sql = "INSERT INTO bookTable (ISBNNumber)" +
            string.Format("VALUES({0});", ISBN);

            //executing the query
            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            //close the connection
            sqlCon.Close();
        }

        public List<string[]> getUserList()
        {
            List<string[]> userList = new List<string[]>();
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that is needed to get users
            string sql = "SELECT * FROM UserTable ORDER BY libUserNumber DESC";

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //format DB values into a string[]
                    string[] userRow = { String.Format("{0}", reader["name"]), String.Format("{0}", reader["libUserNumber"]) };
                    //adding the row to the userList
                    userList.Add(userRow);
                }
            }
            //close the connection
            sqlCon.Close();

            //returns the list of string[]
            return userList;
        }

        public List<string[]> getBookList()
        {
            List<string[]> bookList = new List<string[]>();
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command;

            //typing in the SQL that is needed to get all books with their respective bookinfo
            string sql = "SELECT BookTable.ISBNNumber, BookTable.LibraryUserNumber, BookInfoTable.title, BookInfoTable.author " +
                "FROM IntelligentSystemsLibraryTest.dbo.BookTable " +
                "INNER JOIN BookInfoTable ON BookInfoTable.ISBNNumber = BookTable.ISBNNumber";

            //opening the connection, and executing the query
            sqlCon.Open();
            command = new SqlCommand(sql, sqlCon);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //format DB values into a string[]
                    string[] bookRow = { String.Format("{0}", reader["title"]), String.Format("{0}", reader["author"]), String.Format("{0}", reader["ISBNNumber"]), String.Format("{0}", reader["LibraryUserNumber"]) };
                    //adding the row to the bookList
                    bookList.Add(bookRow);
                }
            }
            //close the connection
            sqlCon.Close();

            //returns the list of string[]
            return bookList;
        }

        public void deleteBook(int isbn)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand command;

            //typing in the SQL that is needed to delete a book from bookTable
            string sql = "DELETE FROM BookTable " +
            string.Format("WHERE ISBNNumber={0}", isbn);

            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();

            //typing in the SQL that is needed to delete a book from bookinfo
            sql = "DELETE FROM BookInfoTable " +
            string.Format("WHERE ISBNNumber={0}", isbn);
            //close the connection
            sqlCon.Close();
        }

        public void deleteUser(int libNum)
        {
            //setup on the SQL connection
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand command;

            //typing in the SQL that is needed to delete a user
            string sql = "DELETE FROM UserTable " +
            string.Format("WHERE libUserNumber={0}", libNum);

            command = new SqlCommand(sql, sqlCon);
            command.ExecuteNonQuery();
            //close the connection
            sqlCon.Close();
        }
    }
}
