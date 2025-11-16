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
    public partial class TaskForm : Form
    {
        bool create;
        ViewForm main;
        public TaskForm(bool create, string id, string name, string desc, ViewForm main)
        {
            InitializeComponent();
            if (create)
            {
                label_title.Text = "Создать";
                tb_id.Text = id;
            }
            else
            {
                label_title.Text = "Изменить заметку " + name;
                tb_id.Text = id;
                tb_name.Text = name;
                tb_desc.Text = desc;
            }
            this.create = create;
            this.main = main;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "")
            {
                if (this.create) this.main.AddDB(tb_id.Text, tb_name.Text, tb_desc.Text);
                else this.main.SetDB(tb_id.Text, tb_name.Text, tb_desc.Text);
                Close();
            }
        }
    }
}
