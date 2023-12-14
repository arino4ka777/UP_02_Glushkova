using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Glushkova_TurAgent
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataBase db = new DataBase();
        DataTable dataTable = new DataTable();

        private string _userRole;
        private string _userName;
        private string _userSurname;

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

        public Form1(string userRole, string userName, string userSurname)
        {
            InitializeComponent();
            _userRole = userRole;
            _userName = userName;
            _userSurname = userSurname;

            if (_userRole == "Клиент")
            {
                groupBox1.Hide();
                deleteBtn.Hide();
                dbSwitch.Items.RemoveAt(2);
                dbSwitch.Items.RemoveAt(1);
                dbSwitch.Items.RemoveAt(0);
                addBtn.Hide();

            }

            if (_userRole == "Турагент")
            {
                deleteBtn.Hide();
                dbSwitch.Items.RemoveAt(2);
                dbSwitch.Items.RemoveAt(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            notesLabel.Visible = false;
            RoleLabel.Text = "Роль:  " + _userRole;
            NameSurLabel.Text = _userSurname + " " + _userName;
        }

        private void AddColumnsInTable()
        {
            dataGridView1.Columns.Clear();

            switch (dbSwitch.Text)
            {
                case "Клиенты":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Фамилия", "Фамилия");
                    dataGridView1.Columns.Add("Имя", "Имя");
                    dataGridView1.Columns.Add("Отчество", "Отчество");
                    dataGridView1.Columns.Add("Дата рождения", "Дата рождения");
                    dataGridView1.Columns.Add("Возраст", "Возраст");
                    dataGridView1.Columns.Add("Телефон", "Телефон");
                    break;
                case "Пользователи":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Логин", "Логин");
                    dataGridView1.Columns.Add("Пароль", "Пароль");
                    dataGridView1.Columns.Add("Фамилия", "Фамилия");
                    dataGridView1.Columns.Add("Имя", "Имя");
                    dataGridView1.Columns.Add("Роль", "Роль");
                    break;
                case "История входа":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Время", "Время");
                    dataGridView1.Columns.Add("Логин", "Логин");
                    dataGridView1.Columns.Add("Фамилия", "Фамилия");
                    dataGridView1.Columns.Add("Имя", "Имя");
                    dataGridView1.Columns.Add("Роль", "Роль");
                    break;
                case "Маршруты":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Наименование маршрута", "Наименование маршрута");
                    dataGridView1.Columns.Add("ID страны", "ID страны");
                    dataGridView1.Columns.Add("Город отправления", "Город отправления");
                    dataGridView1.Columns.Add("Длительность (дни)", "Длительность (дни)");
                    dataGridView1.Columns.Add("ID отеля", "ID отеля");
                    dataGridView1.Columns.Add("Стоимость (с учетом визы)", "Стоимость (с учетом визы)");
                    break;
                case "Отели":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Название страны", "Название страны");
                    dataGridView1.Columns.Add("Название отеля", "Название отеля");
                    dataGridView1.Columns.Add("Класс", "Класс");
                    dataGridView1.Columns.Add("Стоимость проживания (сутки)", "Стоимость проживания (сутки)");
                    break;
                case "Страны":
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Название страны", "Название страны");
                    dataGridView1.Columns.Add("Стоимость визы", "Стоимость визы");
                    break;
            }
        }
        private void dbSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
            notesLabel.Text = "Записей: " + Convert.ToString(dataGridView1.Rows.Count);
            notesLabel.Visible = true;
        }

        public void FillDataGrid()
        {
            if (dbSwitch.Text == "")
                return;
            AddColumnsInTable();
            dataGridView1.Rows.Clear();
            string sql = $"Select * from [{dbSwitch.Text}]";
            db.OpenCon();
            SqlCommand command = new SqlCommand(sql, db.getCon());
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                switch (dbSwitch.Text)
                {
                    case "Клиенты":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetDateTime(4), dataReader.GetInt32(5), dataReader.GetString(6));
                        break;
                    case "Пользователи":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5));
                        break;
                    case "История входа":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetDateTime(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5));
                        break;
                    case "Маршруты":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(3), dataReader.GetInt32(4), dataReader.GetInt32(5), dataReader.GetString(6));
                        break;
                    case "Отели":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                        break;
                    case "Страны":
                        dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
                        break;
                }
            }
            dataReader.Close();
            db.CloseCon();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool rowVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        rowVisible = true;
                        break;
                    }
                }
                row.Visible = rowVisible;
            }
        }

        // Удаление записи
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value);

            string selectedTable = dbSwitch.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                connection.Open();
                string query = $"DELETE FROM {selectedTable} WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            dataGridView1.Rows.RemoveAt(index);
        }

        // Возврат на форму авторизации
        private void backButton_Click(object sender, EventArgs e)
        {
            Auth authForm = new Auth();
            authForm.Show();
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteRow();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string selectedTable = dbSwitch.SelectedItem.ToString();
            Add addForm = new Add(dbSwitch.SelectedIndex, selectedTable, _userRole, _userName, _userSurname);
            addForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                textBox1.Text = selectedValue;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при изменении значения.");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            db.OpenCon();
            try
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                string newValue = textBox1.Text;
                selectedCell.Value = newValue;

                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;
                string tableName = dbSwitch.SelectedItem.ToString();
                string ID = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString(); 

                string sql = $"UPDATE {tableName} SET [{columnName}] = @Param1 WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, db.getCon());
                cmd.Parameters.AddWithValue("@Param1", newValue);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Значение успешно изменено и сохранено в базе данных.");
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при сохранении изменений.");
            }
        }
    }
}
