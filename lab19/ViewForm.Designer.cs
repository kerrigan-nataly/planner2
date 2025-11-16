namespace lab19
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            task_view_checked = new DataGridView();
            tableLayoutPanel6 = new TableLayoutPanel();
            button_delete_checked = new Button();
            button_uncheck = new Button();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            task_view = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_check = new Button();
            button_delete = new Button();
            button_set = new Button();
            button_add = new Button();
            tabControl1 = new TabControl();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabPage2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)task_view_checked).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)task_view).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleTurquoise;
            tabPage2.Controls.Add(tableLayoutPanel5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(904, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Выполненные задачи";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.PaleTurquoise;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(task_view_checked, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0603676F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 82.93964F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel5.Size = new Size(892, 464);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 30F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(550, 65);
            label3.TabIndex = 0;
            label3.Text = "Выполненные задачи";
            // 
            // task_view_checked
            // 
            task_view_checked.AllowUserToAddRows = false;
            task_view_checked.AllowUserToDeleteRows = false;
            task_view_checked.AllowUserToResizeColumns = false;
            task_view_checked.AllowUserToResizeRows = false;
            task_view_checked.BackgroundColor = Color.FromArgb(0, 192, 192);
            task_view_checked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            task_view_checked.Location = new Point(3, 68);
            task_view_checked.MultiSelect = false;
            task_view_checked.Name = "task_view_checked";
            task_view_checked.ReadOnly = true;
            task_view_checked.RowHeadersWidth = 51;
            task_view_checked.Size = new Size(886, 310);
            task_view_checked.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.236084F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.763916F));
            tableLayoutPanel6.Controls.Add(button_delete_checked, 0, 0);
            tableLayoutPanel6.Controls.Add(button_uncheck, 1, 0);
            tableLayoutPanel6.Location = new Point(3, 384);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(521, 77);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // button_delete_checked
            // 
            button_delete_checked.BackColor = Color.LemonChiffon;
            button_delete_checked.Font = new Font("Cascadia Mono", 20F);
            button_delete_checked.ForeColor = Color.Black;
            button_delete_checked.Location = new Point(3, 3);
            button_delete_checked.Name = "button_delete_checked";
            button_delete_checked.Size = new Size(182, 71);
            button_delete_checked.TabIndex = 2;
            button_delete_checked.Text = "удалить";
            button_delete_checked.UseVisualStyleBackColor = false;
            button_delete_checked.Click += button_delete_checked_Click;
            // 
            // button_uncheck
            // 
            button_uncheck.BackColor = Color.LemonChiffon;
            button_uncheck.Font = new Font("Cascadia Mono", 20F);
            button_uncheck.ForeColor = Color.Black;
            button_uncheck.Location = new Point(197, 3);
            button_uncheck.Name = "button_uncheck";
            button_uncheck.Size = new Size(321, 71);
            button_uncheck.TabIndex = 3;
            button_uncheck.Text = "вернуть задачу";
            button_uncheck.UseVisualStyleBackColor = false;
            button_uncheck.Click += button_uncheck_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleTurquoise;
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(904, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задачи";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(task_view, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0603676F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.93964F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(892, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 65);
            label1.TabIndex = 0;
            label1.Text = "Задачи";
            // 
            // task_view
            // 
            task_view.AllowUserToAddRows = false;
            task_view.AllowUserToDeleteRows = false;
            task_view.AllowUserToResizeColumns = false;
            task_view.AllowUserToResizeRows = false;
            task_view.BackgroundColor = Color.FromArgb(0, 192, 192);
            task_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            task_view.Location = new Point(3, 68);
            task_view.MultiSelect = false;
            task_view.Name = "task_view";
            task_view.ReadOnly = true;
            task_view.RowHeadersWidth = 51;
            task_view.Size = new Size(886, 310);
            task_view.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel2.Controls.Add(button_check, 0, 0);
            tableLayoutPanel2.Controls.Add(button_delete, 1, 0);
            tableLayoutPanel2.Controls.Add(button_set, 2, 0);
            tableLayoutPanel2.Controls.Add(button_add, 3, 0);
            tableLayoutPanel2.Location = new Point(3, 384);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(886, 77);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button_check
            // 
            button_check.BackColor = Color.LemonChiffon;
            button_check.Font = new Font("Cascadia Mono", 20F);
            button_check.Location = new Point(3, 3);
            button_check.Name = "button_check";
            button_check.Size = new Size(216, 71);
            button_check.TabIndex = 0;
            button_check.Text = "выполнить";
            button_check.UseVisualStyleBackColor = false;
            button_check.Click += button_check_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.LemonChiffon;
            button_delete.Font = new Font("Cascadia Mono", 20F);
            button_delete.Location = new Point(225, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(216, 71);
            button_delete.TabIndex = 1;
            button_delete.Text = "удалить";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_set
            // 
            button_set.BackColor = Color.LemonChiffon;
            button_set.Font = new Font("Cascadia Mono", 20F);
            button_set.Location = new Point(447, 3);
            button_set.Name = "button_set";
            button_set.Size = new Size(220, 71);
            button_set.TabIndex = 2;
            button_set.Text = "изменить";
            button_set.UseVisualStyleBackColor = false;
            button_set.Click += button_set_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.LemonChiffon;
            button_add.Font = new Font("Cascadia Mono", 20F);
            button_add.Location = new Point(673, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(210, 71);
            button_add.TabIndex = 3;
            button_add.Text = "добавить";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Cascadia Mono", 9F);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(912, 509);
            tabControl1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 67);
            label2.TabIndex = 0;
            label2.Text = "Задачи";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 70);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(194, 321);
            dataGridView2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(1, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(-117, 3);
            button5.Name = "button5";
            button5.Size = new Size(1, 29);
            button5.TabIndex = 1;
            button5.Text = "button2";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(976, 553);
            Controls.Add(tabControl1);
            Name = "ViewForm";
            Text = "ViewForm";
            FormClosed += ViewForm_FormClosed;
            tabPage2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)task_view_checked).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)task_view).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_check;
        private Button button_delete;
        private Button button_set;
        private Button button_add;
        private TabControl tabControl1;
        private Label label2;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private DataGridView dataGridView3;
        private Button button_delete_checked;
        private DataGridView task_view_checked;
        private DataGridView task_view;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button_uncheck;
    }
}