
namespace _30_05_2021_Database_Coursework
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.AddInformation = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedLevels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstTimePlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastTimePlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.MainTable.BackgroundColor = System.Drawing.Color.White;
            this.MainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Age,
            this.PassedLevels,
            this.GameName,
            this.Developer,
            this.TimeSpent,
            this.Contacts,
            this.FirstTimePlayed,
            this.LastTimePlayed});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainTable.DefaultCellStyle = dataGridViewCellStyle19;
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTable.GridColor = System.Drawing.Color.White;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.MainTable.RowHeadersVisible = false;
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 24;
            this.MainTable.Size = new System.Drawing.Size(1302, 401);
            this.MainTable.TabIndex = 0;
            this.MainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellContentClick);
            // 
            // AddInformation
            // 
            this.AddInformation.BackColor = System.Drawing.Color.White;
            this.AddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddInformation.Location = new System.Drawing.Point(12, 436);
            this.AddInformation.Name = "AddInformation";
            this.AddInformation.Size = new System.Drawing.Size(141, 46);
            this.AddInformation.TabIndex = 1;
            this.AddInformation.Text = "Добавить";
            this.AddInformation.UseVisualStyleBackColor = false;
            this.AddInformation.Click += new System.EventHandler(this.AddInformation_Click);
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Login.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 70;
            // 
            // PassedLevels
            // 
            this.PassedLevels.HeaderText = "Пройденные уровни";
            this.PassedLevels.MinimumWidth = 6;
            this.PassedLevels.Name = "PassedLevels";
            this.PassedLevels.ReadOnly = true;
            this.PassedLevels.Width = 130;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "Название игры";
            this.GameName.MinimumWidth = 6;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Width = 150;
            // 
            // Developer
            // 
            this.Developer.HeaderText = "Разработчик";
            this.Developer.MinimumWidth = 6;
            this.Developer.Name = "Developer";
            this.Developer.ReadOnly = true;
            this.Developer.Width = 120;
            // 
            // TimeSpent
            // 
            this.TimeSpent.HeaderText = "Потраченное время";
            this.TimeSpent.MinimumWidth = 6;
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.ReadOnly = true;
            this.TimeSpent.Width = 130;
            // 
            // Contacts
            // 
            this.Contacts.HeaderText = "Контактная информация";
            this.Contacts.MinimumWidth = 6;
            this.Contacts.Name = "Contacts";
            this.Contacts.ReadOnly = true;
            this.Contacts.Width = 120;
            // 
            // FirstTimePlayed
            // 
            this.FirstTimePlayed.HeaderText = "Дата первого запуска";
            this.FirstTimePlayed.MinimumWidth = 6;
            this.FirstTimePlayed.Name = "FirstTimePlayed";
            this.FirstTimePlayed.ReadOnly = true;
            this.FirstTimePlayed.Width = 150;
            // 
            // LastTimePlayed
            // 
            this.LastTimePlayed.HeaderText = "Последний запуск";
            this.LastTimePlayed.MinimumWidth = 6;
            this.LastTimePlayed.Name = "LastTimePlayed";
            this.LastTimePlayed.ReadOnly = true;
            this.LastTimePlayed.Width = 120;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(1055, 468);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(48, 17);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "Дебаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 494);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.AddInformation);
            this.Controls.Add(this.MainTable);
            this.Name = "Form1";
            this.Text = "База данных Dupa Games Studio";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Button AddInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedLevels;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstTimePlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastTimePlayed;
        private System.Windows.Forms.Label txtResult;
    }
}

