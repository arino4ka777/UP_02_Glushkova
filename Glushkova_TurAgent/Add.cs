using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Glushkova_TurAgent
{
    public partial class Add : Form
    {
        DataBase db = new DataBase();

        private int _table;
        private string _selectedTable;
        private string _userRole;
        private string _userName;
        private string _userSurname;

        public Add(int table, string selectedTable, string userRole, string userName, string userSurname)
        {
            InitializeComponent();
            _userRole = userRole;
            _userName = userName;
            _userSurname = userSurname;
            _selectedTable = selectedTable;
            _table = table;

            int tabs = tabControl1.TabCount;
            int count = 0;

            for (int i = 0; i < tabs; i++)
            {
                if (i != table)
                {
                    tabControl1.TabPages.RemoveAt(count);
                }
                else
                {
                    count++;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.OpenCon();
            switch (_selectedTable)
            {
                case "Клиенты":
                    string sql = $"Insert into Клиенты values ('{surnameTextBox.Text}', '{nameTextBox.Text}', '{patronymicTextBox.Text}', '{DateTime.Parse(dateBirthTextBox.Text)}', '{ageTextBox.Text}', '{phoneTextBox.Text}')";
                    SqlCommand cmd = new SqlCommand(sql, db.getCon());
                    cmd.ExecuteNonQuery();
                    break;
                case "Пользователи":
                    sql = $"Insert into Пользователи values ('{loginTextBox.Text}','{passTextBox.Text}','{surnameUserTextBox.Text}','{nameUserTextBox.Text}','{roleComboBox.Text}')";
                    cmd = new SqlCommand(sql, db.getCon());
                    cmd.ExecuteNonQuery();
                    break;
                case "История входа":
                    MessageBox.Show("Данные в эту таблицу добавить нельзя.");
                    break;
                case "Маршруты":
                    sql = $"Insert into Маршруты values ('{routeNameTextBox.Text}','{idCountryComboBox.Text}','{cityComboBox.Text}','{daysTextBox.Text}','{idHotelComboBox.Text}','{costRouteTextBox.Text}')";
                    cmd = new SqlCommand(sql, db.getCon());
                    cmd.ExecuteNonQuery();
                    break;
                case "Отели":
                    sql = $"Insert into Отели values ('{nameCountryСomboBox.Text}','{nameHotelTextBox.Text}','{classComboBox.Text}','{costDayTextBox.Text}')";
                    cmd = new SqlCommand(sql, db.getCon());
                    cmd.ExecuteNonQuery();
                    break;
                case "Страны":
                    sql = $"Insert into Страны values ('{countryTextBox.Text}','{costVisaTextBox.Text}')";
                    cmd = new SqlCommand(sql, db.getCon());
                    cmd.ExecuteNonQuery();
                    break;
            }
            MessageBox.Show("Запись успешно добавлена!");
            Close();
            Form1 form1 = new Form1(_userRole, _userName, _userSurname);
            form1.FillDataGrid();
        }
    }
}
