using System.Data.SqlClient;

namespace Glushkova_TurAgent
{
    public class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getCon() { return connection; }
    }
}
