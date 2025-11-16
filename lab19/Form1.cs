using Microsoft.Data.Sqlite;
using System.Runtime.CompilerServices;

namespace lab19
{

    public partial class Form1 : Form
    {
        SqliteConnection sqlConnection;
        public int user_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqliteConnection(@"Data Source = C:\Users\natag\OneDrive\Рабочий стол\koraga\4k\kri\tasks.db;");
            sqlConnection.Open();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            CreateUserForm f = new CreateUserForm(this);
            f.Show();
            sqlConnection.Close();
            this.Hide();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            var command_auth = new SqliteCommand(
                $"select id_user, password from user where login = '{tb_login.Text}'", sqlConnection);
            command_auth.ExecuteNonQuery();
            SqliteDataReader r = command_auth.ExecuteReader();
            if (r.Read())
            {
                if (r.GetString(r.GetOrdinal("password")) == tb_password.Text)
                {
                    this.user_id = Convert.ToInt32(r.GetString(r.GetOrdinal("id_user")));
                    sqlConnection.Close();

                    ViewForm f = new ViewForm(this);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    tb_password.Text = "";
                    tb_password.PlaceholderText = "неверный пароль";
                }
            }
        }
    }
}
