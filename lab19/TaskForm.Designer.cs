namespace lab19
{
    partial class TaskForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button_save = new Button();
            button_cancel = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_id = new TextBox();
            tb_name = new TextBox();
            tb_desc = new TextBox();
            label_title = new Label();
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
            tableLayoutPanel1.Controls.Add(label_title, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.97826F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.0217361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Size = new Size(776, 433);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.90909F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.09091F));
            tableLayoutPanel3.Controls.Add(button_save, 0, 0);
            tableLayoutPanel3.Controls.Add(button_cancel, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 371);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(770, 59);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.BackColor = Color.LemonChiffon;
            button_save.Font = new Font("Cascadia Mono", 20F);
            button_save.Location = new Point(3, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(227, 53);
            button_save.TabIndex = 2;
            button_save.Text = "сохранить";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.LemonChiffon;
            button_cancel.Font = new Font("Cascadia Mono", 20F);
            button_cancel.Location = new Point(241, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(242, 53);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "отменить";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9610386F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.03896F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(tb_id, 1, 0);
            tableLayoutPanel2.Controls.Add(tb_name, 1, 1);
            tableLayoutPanel2.Controls.Add(tb_desc, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 117);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel2.Size = new Size(770, 201);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 20F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 45);
            label2.TabIndex = 0;
            label2.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 20F);
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(180, 45);
            label3.TabIndex = 1;
            label3.Text = "название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 20F);
            label4.Location = new Point(3, 130);
            label4.Name = "label4";
            label4.Size = new Size(180, 45);
            label4.TabIndex = 2;
            label4.Text = "описание";
            // 
            // tb_id
            // 
            tb_id.BackColor = Color.MediumTurquoise;
            tb_id.Font = new Font("Cascadia Mono", 20F);
            tb_id.Location = new Point(226, 3);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(533, 46);
            tb_id.TabIndex = 3;
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.PaleTurquoise;
            tb_name.Font = new Font("Cascadia Mono", 20F);
            tb_name.ForeColor = Color.Black;
            tb_name.Location = new Point(226, 68);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(533, 46);
            tb_name.TabIndex = 4;
            // 
            // tb_desc
            // 
            tb_desc.BackColor = Color.PaleTurquoise;
            tb_desc.Font = new Font("Cascadia Mono", 20F);
            tb_desc.ForeColor = Color.Black;
            tb_desc.Location = new Point(226, 133);
            tb_desc.Name = "tb_desc";
            tb_desc.Size = new Size(533, 46);
            tb_desc.TabIndex = 5;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Cascadia Mono", 30F);
            label_title.Location = new Point(3, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(202, 66);
            label_title.TabIndex = 1;
            label_title.Text = "label1";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "TaskForm";
            Text = "TaskForm";
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
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_id;
        private TextBox tb_name;
        private TextBox tb_desc;
        private Label label_title;
        private Button button_save;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button_cancel;
    }
}