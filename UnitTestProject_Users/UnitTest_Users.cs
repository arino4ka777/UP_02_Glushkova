using CheckUser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Users
{
    [TestClass]
    public class UnitTest_Users
    {
        [TestMethod]
        public void TestAuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string login = "tur";
            string password = "tur";
            DatabaseManager dbManager = new DatabaseManager(@"Data Source=ADCLG1;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

            // Act
            bool result = dbManager.AuthenticateUser(login, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string login = "333";
            string password = "333";
            DatabaseManager dbManager = new DatabaseManager(@"Data Source=ADCLG1;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

            // Act
            bool result = dbManager.AuthenticateUser(login, password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertLoginHistory_ValidData_InsertsRecord()
        {
            // Arrange
            string login = "1";
            string role = "Администратор";
            string name = "Арина";
            string surname = "Глушкова";
            DatabaseManager dbManager = new DatabaseManager(@"Data Source=ADCLG1;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

            // Act
            dbManager.InsertLoginHistory(login, role, name, surname);

            // Assert
            // Add your assertion here to check if the record was successfully inserted into the login history table
        }
    }
}
