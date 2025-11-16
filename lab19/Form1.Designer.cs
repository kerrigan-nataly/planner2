namespace lab19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button_create = new Button();
            button_enter = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label_login = new Label();
            label_password = new Label();
            tb_login = new TextBox();
            tb_password = new TextBox();
            label_main = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label_main, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.3615627F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.6384354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.Size = new Size(566, 359);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button_create, 1, 0);
            tableLayoutPanel3.Controls.Add(button_enter, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 275);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(560, 81);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // button_create
            // 
            button_create.BackColor = Color.LemonChiffon;
            button_create.Font = new Font("Cascadia Mono", 15F);
            button_create.Location = new Point(283, 3);
            button_create.Name = "button_create";
            button_create.Size = new Size(274, 75);
            button_create.TabIndex = 2;
            button_create.Text = "создать учетную запись";
            button_create.UseVisualStyleBackColor = false;
            button_create.Click += button_create_Click;
            // 
            // button_enter
            // 
            button_enter.BackColor = Color.LemonChiffon;
            button_enter.Font = new Font("Cascadia Mono", 23F);
            button_enter.Location = new Point(3, 3);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(274, 75);
            button_enter.TabIndex = 3;
            button_enter.Text = "войти";
            button_enter.UseVisualStyleBackColor = false;
            button_enter.Click += button_enter_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8928566F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.10714F));
            tableLayoutPanel2.Controls.Add(label_login, 0, 0);
            tableLayoutPanel2.Controls.Add(label_password, 0, 1);
            tableLayoutPanel2.Controls.Add(tb_login, 1, 0);
            tableLayoutPanel2.Controls.Add(tb_password, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 77);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(560, 182);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Cascadia Mono", 23F);
            label_login.Location = new Point(3, 0);
            label_login.Name = "label_login";
            label_login.Size = new Size(137, 51);
            label_login.TabIndex = 0;
            label_login.Text = "логин";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Cascadia Mono", 23F);
            label_password.Location = new Point(3, 91);
            label_password.Name = "label_password";
            label_password.Size = new Size(160, 51);
            label_password.TabIndex = 1;
            label_password.Text = "пароль";
            // 
            // tb_login
            // 
            tb_login.BackColor = Color.PaleTurquoise;
            tb_login.Font = new Font("Cascadia Mono", 23F);
            tb_login.Location = new Point(176, 3);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(381, 52);
            tb_login.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.PaleTurquoise;
            tb_password.Font = new Font("Cascadia Mono", 23F);
            tb_password.Location = new Point(176, 94);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(381, 52);
            tb_password.TabIndex = 3;
            // 
            // label_main
            // 
            label_main.AutoSize = true;
            label_main.Font = new Font("Cascadia Mono", 30F);
            label_main.Location = new Point(3, 0);
            label_main.Name = "label_main";
            label_main.Size = new Size(347, 66);
            label_main.TabIndex = 0;
            label_main.Text = "Авторизация";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(595, 391);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label_login;
        private Label label_password;
        private TextBox tb_login;
        private TextBox tb_password;
        private Label label_main;
        private Button button_create;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button_enter;
    }
}
