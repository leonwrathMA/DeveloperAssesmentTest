using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DeveloperAssesment_1._4;
using System.Data.SqlClient;

namespace DeveloperAssesment_1._5
{
    [TestClass]
    public class unitTests
    {
        Controller control;
        [TestInitialize]
        public void testInit()
        {
            //when initializing we get what data we need before the test is run, in this case i will initialize the controller, and add the test data to the tables
            control = new Controller();
            control.RegUser("unitTestPerson", 999);
            control.RegBook("unitTestBook", "UnitTestProgram", 9999);
        }

        [TestMethod]
        public void rentBookUnitTest()
        {
            //setting up the query and connection variables needed to test.
            string connectionString = "Data Source=DESKTOP-ULJRT69;Initial Catalog=IntelligentSystemsLibraryTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "SELECT _id FROM BookTable WHERE LibraryUserNumber=999 AND ISBNNumber=9999";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, sqlCon);
            
            //calling the method to test
            control.RentBook(999, 9999);

            //open the connection
            sqlCon.Open();
            SqlDataReader reader = command.ExecuteReader();
            //check if it has any result
            bool result = reader.HasRows;
            sqlCon.Close();

            //check if the test is a success or a failure
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void returnBookUnitTest()
        {
            //setting up the query and connection variables needed to test.
            string connectionString = "Data Source=DESKTOP-ULJRT69;Initial Catalog=IntelligentSystemsLibraryTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "SELECT _id FROM BookTable WHERE LibraryUserNumber=999 AND ISBNNumber=9999";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, sqlCon);

            //renting a book to test
            control.RentBook(999, 9999);

            //calling the method to test
            control.ReturnBook(9999, 999);

            //open the connection
            sqlCon.Open();
            SqlDataReader reader = command.ExecuteReader();
            //check if it has any result
            bool result = reader.HasRows;
            sqlCon.Close();

            //check if the test is a success or a failure
            Assert.AreEqual(false, result);
        }

        [TestCleanup]
        public void cleanUp()
        {
            //cleanup after the tests are done, here i simply just delete the test data i created during the initialization
            control.deleteBook(9999);
            control.deleteUser(999);
        }
    }
}
