namespace Glushkova_TurAgent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dbSwitch = new System.Windows.Forms.ComboBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameSurLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxSearch.Location = new System.Drawing.Point(719, 18);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(185, 23);
            this.TextBoxSearch.TabIndex = 59;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(647, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Поиск:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(740, 395);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 42);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(27, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 370);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(716, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Активная таблица";
            // 
            // dbSwitch
            // 
            this.dbSwitch.FormattingEnabled = true;
            this.dbSwitch.Items.AddRange(new object[] {
            "Клиенты",
            "Пользователи",
            "История входа",
            "Маршруты",
            "Отели",
            "Страны"});
            this.dbSwitch.Location = new System.Drawing.Point(719, 133);
            this.dbSwitch.Name = "dbSwitch";
            this.dbSwitch.Size = new System.Drawing.Size(185, 21);
            this.dbSwitch.TabIndex = 54;
            this.dbSwitch.SelectedIndexChanged += new System.EventHandler(this.dbSwitch_SelectedIndexChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.BackColor = System.Drawing.Color.Transparent;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesLabel.Location = new System.Drawing.Point(600, 75);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(46, 16);
            this.notesLabel.TabIndex = 51;
            this.notesLabel.Text = "notes";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RoleLabel.Location = new System.Drawing.Point(24, 61);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(46, 20);
            this.RoleLabel.TabIndex = 50;
            this.RoleLabel.Text = "Role";
            // 
            // NameSurLabel
            // 
            this.NameSurLabel.AutoSize = true;
            this.NameSurLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameSurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSurLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameSurLabel.Location = new System.Drawing.Point(24, 29);
            this.NameSurLabel.Name = "NameSurLabel";
            this.NameSurLabel.Size = new System.Drawing.Size(127, 20);
            this.NameSurLabel.TabIndex = 49;
            this.NameSurLabel.Text = "SurnameName";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(28, 500);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(134, 42);
            this.backButton.TabIndex = 60;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(719, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 145);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование записи";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.changeButton.Location = new System.Drawing.Point(21, 83);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(134, 42);
            this.changeButton.TabIndex = 62;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(740, 324);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 42);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::Glushkova_TurAgent.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(922, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dbSwitch);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.NameSurLabel);
            this.Name = "Form1";
            this.Text = "Турагентство";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dbSwitch;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameSurLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

