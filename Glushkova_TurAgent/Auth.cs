using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Glushkova_TurAgent
{
    public partial class Auth : Form
    {
        DataBase db = new DataBase();
        private readonly Captcha _captcha = new Captcha();
        private int _countInputs = 0;

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True");

        public Auth()
        {
            InitializeComponent();
            passTextBox.UseSystemPasswordChar = true;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            HideCaptcha();
        }

        private void Clear()
        {
            loginTextBox.Text = "";
            passTextBox.Text = "";
        }

        // Метод для входа в систему
        private void SignBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string pass = passTextBox.Text;

            // Создание подключения к базе данных
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                // Создание команды для выполнения запроса
                string query = "SELECT * FROM Пользователи WHERE Логин = @login AND Пароль = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавление параметров к запросу
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", pass);

                    // Открытие подключения и выполнение запроса
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            string role = GetUserRole(login);
                            string name = GetUserName(login);
                            string surname = GetUserSurname(login);

                            DateTime currentTime = DateTime.Now;
                            string sql = "INSERT INTO [История входа] (Время, Фамилия, Имя, Логин, Роль) VALUES (@currentTime, @surname, @name, @login, @role)";
                            SqlCommand cmd = new SqlCommand(sql, connection);
                            cmd.Parameters.AddWithValue("@currentTime", currentTime);
                            cmd.Parameters.AddWithValue("@surname", surname);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.Parameters.AddWithValue("@role", role);
                            cmd.ExecuteNonQuery();

                            if (role == "Администратор")
                            {
                                
                                MessageBox.Show("Вы авторизовались как администратор.");
                            }
                            else if (role == "Турагент")
                            {
                                MessageBox.Show("Вы авторизовались как турагент.");
                            }
                            else if (role == "Клиент") 
                            {
                                MessageBox.Show("Вы авторизовались как клиент.");
                            }

                            Form1 formView = new Form1(role, name, surname);
                            formView.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        // Ошибка авторизации
                        reader.Close();
                        _countInputs++;
                        if (_countInputs >= 2) // После первой неудачной попытки
                        {
                            MessageBox.Show("Ошибка авторизации. Введите captcha");
                            GeneratedCaptcha(); // Генерация captcha
                            PictureBoxCaptcha.Visible = true;
                            TextBoxCaptcha.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка авторизации");
                        }
                    }
                }
            }
        }

        private string GetUserRole(string login)
        {
            string role = string.Empty;
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                string query = "SELECT Роль FROM Пользователи WHERE Логин = @login AND Пароль = @pass";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", login);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
            }
            return role;
        }

        private string GetUserName(string login)
        {
            string name = string.Empty;
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                string query = "SELECT Имя FROM Пользователи WHERE Логин = @login AND Пароль = @pass";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", login);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        name = result.ToString();
                    }
                }
            }
            return name;
        }

        private string GetUserSurname(string login)
        {
            string surname = string.Empty;
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T57TTS1\ARINA;Initial Catalog=UP_02_Glushkova;Integrated Security=True"))
            {
                string query = "SELECT Фамилия FROM Пользователи WHERE Логин = @login AND Пароль = @pass";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", login);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        surname = result.ToString();
                    }
                }
            }
            return surname;
        }

        private void ButtonChangeCaptcha_Click(object sender, EventArgs e)
        {
            GeneratedCaptcha();
        }

        private void GeneratedCaptcha()
        {
            PictureBoxCaptcha.Image = _captcha.CreateCaptcha(PictureBoxCaptcha.Width, PictureBoxCaptcha.Height);
        }

        private void ShowCaptcha()
        {
            LabelCaptcha.Visible = true;
            TextBoxCaptcha.Visible = true;
            PictureBoxCaptcha.Visible = true;
            ButtonChangeCaptcha.Visible = true;
        }

        private void HideCaptcha()
        {
            LabelCaptcha.Visible = false;
            TextBoxCaptcha.Visible = false;
            PictureBoxCaptcha.Visible = false;
            ButtonChangeCaptcha.Visible = false;
        }

        private void buttonShowOrHidePass_Click(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = (
                passTextBox.UseSystemPasswordChar == true ? false : true);

            buttonShowOrHidePass.Image = (
                passTextBox.UseSystemPasswordChar == true ?
                    Properties.Resources.Show as Bitmap : Properties.Resources.Hide as Bitmap);
        }
    }
}