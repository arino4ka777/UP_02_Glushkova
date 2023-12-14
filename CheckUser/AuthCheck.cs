using System;
using System.Data.SqlClient;

namespace CheckUser
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public bool AuthenticateUser(string login, string pass)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=ADCLG1;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                string query = $"Select * From [Пользователи] Where [Логин] = '{login}' AND [Пароль] = '{pass}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", pass);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                }
            }
        }

        public void InsertLoginHistory(string login, string role, string name, string surname)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            DateTime currentTime = DateTime.Now;
            string query = "INSERT INTO [История входа] (Время, Фамилия, Имя, Логин, Роль) VALUES (@currentTime, @surname, @name, @login, @role)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@currentTime", currentTime);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@role", role);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
}


       
     