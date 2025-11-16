using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab19
{
    public partial class CreateUserForm : Form
    {
        Form1 main;
        SqliteConnection sqlConnection;
        public CreateUserForm(Form1 main)
        {
            InitializeComponent();
            sqlConnection = new SqliteConnection(@"Data Source = C:\Users\natag\OneDrive\Рабочий стол\koraga\4k\kri\tasks.db;");
            sqlConnection.Open();
            this.main = main;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            var command_count = new SqliteCommand("SELECT COUNT(id_user) FROM user", sqlConnection);
            object res = command_count.ExecuteScalar();
            main.user_id = Convert.ToInt32(res) + 1;

            bool flag = true;
            var command_auth = new SqliteCommand(
                $"select login from user", sqlConnection);
            command_auth.ExecuteNonQuery();
            SqliteDataReader r = command_auth.ExecuteReader();
            if (r.Read())
            {
                if (r.GetString(r.GetOrdinal("login")) == tb_login.Text) flag = false; 
            }

            if (flag)
            {
                var command_add = new SqliteCommand(
                    "INSERT INTO user VALUES " +
                    $"({main.user_id}, '{tb_login.Text}', '{tb_password.Text}');", sqlConnection);
                command_add.ExecuteNonQuery();

                ViewForm f = new ViewForm(main);
                f.Show();
                sqlConnection.Close();
                this.Hide();
            }
            else
            {
                tb_login.Text = "";
                tb_login.PlaceholderText = "логин занят";
                tb_password.Text = "";
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            main.Show();
            sqlConnection.Close();
            this.Close();
        }
    }
}
