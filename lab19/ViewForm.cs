using Microsoft.Data.Sqlite;
using System.Data;

namespace lab19
{
    public partial class ViewForm : Form
    {
        SqliteConnection sqlConnection;
        Form1 main;
        int length = 0;
        public ViewForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();

            sqlConnection = new SqliteConnection(@"Data Source = C:\Users\natag\OneDrive\Рабочий стол\koraga\4k\kri\tasks.db;");
            sqlConnection.Open();
            UpdateDB();
        }
        void UpdateDB()
        {
            var command_unchecked = new SqliteCommand(
                "select id_task as 'общий идентификатор', name as 'название', description as 'описание', creation_time as 'поставлена' " +
                "from task where to_show = 1 and checked = 0" +
                $" and user_id = {main.user_id}", sqlConnection);

            command_unchecked.ExecuteNonQuery();
            var dt_unchecked = new DataTable("Задачм");
            dt_unchecked.Load(command_unchecked.ExecuteReader());
            task_view.DataSource = dt_unchecked;
            foreach (DataGridViewColumn c in task_view.Columns)
            {
                c.Width = 208;
            }

            var command_checked = new SqliteCommand(
                "select id_task as 'общий идентификатор', name as 'название', description as 'описание', creation_time as 'поставлена', check_time as 'выполнена' " +
                "from task where to_show = 1 and checked = 1" +
                $" and user_id = {main.user_id}", sqlConnection);
            command_checked.ExecuteNonQuery();
            var dt_checked = new DataTable("Выполненные задачи");
            dt_checked.Load(command_checked.ExecuteReader());
            task_view_checked.DataSource = dt_checked;
            for (int i = 0; i < task_view_checked.ColumnCount; i++)
            {
                if (i <= 2) task_view_checked.Columns[i].Width = 139;
                else task_view_checked.Columns[i].Width = 208;
            }


            var command_count = new SqliteCommand(
            $"SELECT COUNT(id_task) FROM task", sqlConnection);
            object res = command_count.ExecuteScalar();
            this.length = Convert.ToInt32(res);
        }
        public void AddDB(string id, string name, string desc)
        {
            var command_add = new SqliteCommand(
                "INSERT INTO task VALUES " +
                $"({id}, {main.user_id}, '{name}', '{desc}', DATETIME('now', 'localtime'), " +
                "DATETIME('now', 'localtime'), 1, 0)", sqlConnection);
            command_add.ExecuteNonQuery();
            UpdateDB();
        }
        public void SetDB(string id, string name, string desc)
        {
            var command_set = new SqliteCommand(
                $"UPDATE task SET name = '{name}', description= '{desc}'" +
                $"WHERE id_task = {id};", sqlConnection);
            command_set.ExecuteNonQuery();
            UpdateDB();
        }
        public void CheckDB(string id)
        {
            var command_check = new SqliteCommand(
                $"UPDATE task SET checked = 1, check_time = DATETIME('now', 'localtime') " +
                $"WHERE id_task = {id};", sqlConnection);
            command_check.ExecuteNonQuery();
            UpdateDB();
        }
        public void UncheckDB(string id)
        {
            var command_uncheck = new SqliteCommand(
                $"UPDATE task SET checked = 0 " +
                $"WHERE id_task = {id};", sqlConnection);
            command_uncheck.ExecuteNonQuery();
            UpdateDB();
        }
        public void DeleteDB(string id)
        {
            var command_delete = new SqliteCommand(
                $"UPDATE task SET to_show = 0 " +
                $"WHERE id_task = {id};", sqlConnection);
            command_delete.ExecuteNonQuery();
            UpdateDB();
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            TaskForm f;
            if (task_view.SelectedCells.Count > 0)
            {
                DataGridViewRow row = task_view.Rows[task_view.SelectedCells[0].RowIndex];
                f = new TaskForm(false, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), this);
                f.Show();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            TaskForm f = new TaskForm(true, (this.length + 1).ToString(), "", "", this);
            f.Show();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (task_view.SelectedCells.Count > 0)
                CheckDB(task_view.Rows[task_view.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (task_view.SelectedCells.Count > 0)
                DeleteDB(task_view.Rows[task_view.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }

        private void button_delete_checked_Click(object sender, EventArgs e)
        {
            if (task_view_checked.SelectedCells.Count > 0)
                DeleteDB(task_view.Rows[task_view_checked.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }

        private void button_uncheck_Click(object sender, EventArgs e)
        {
            if (task_view.SelectedCells.Count > 0)
                UncheckDB(task_view_checked.Rows[task_view_checked.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }
        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Close();
        }
    }
}
