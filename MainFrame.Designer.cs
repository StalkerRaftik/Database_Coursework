
namespace _30_05_2021_Database_Coursework
{
    partial class MainFrame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedLevels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstTimePlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastTimePlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable_AddInformation = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.TablesControl = new System.Windows.Forms.TabControl();
            this.MainDatabase = new System.Windows.Forms.TabPage();
            this.UsersDatabase = new System.Windows.Forms.TabPage();
            this.PlayersTable_AddInformation = new System.Windows.Forms.Button();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.PlayersTableLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayersTableAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.TablesControl.SuspendLayout();
            this.MainDatabase.SuspendLayout();
            this.UsersDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainTable.BackgroundColor = System.Drawing.Color.White;
            this.MainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTable.GridColor = System.Drawing.Color.White;
            this.MainTable.Location = new System.Drawing.Point(3, 3);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MainTable.RowHeadersVisible = false;
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 24;
            this.MainTable.Size = new System.Drawing.Size(1264, 370);
            this.MainTable.TabIndex = 0;
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
            // MainTable_AddInformation
            // 
            this.MainTable_AddInformation.BackColor = System.Drawing.Color.White;
            this.MainTable_AddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTable_AddInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTable_AddInformation.Location = new System.Drawing.Point(6, 379);
            this.MainTable_AddInformation.Name = "MainTable_AddInformation";
            this.MainTable_AddInformation.Size = new System.Drawing.Size(141, 46);
            this.MainTable_AddInformation.TabIndex = 1;
            this.MainTable_AddInformation.Text = "Добавить";
            this.MainTable_AddInformation.UseVisualStyleBackColor = false;
            this.MainTable_AddInformation.Click += new System.EventHandler(this.AddInformation_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(1245, 480);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(48, 17);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "Дебаг";
            // 
            // TablesControl
            // 
            this.TablesControl.Controls.Add(this.MainDatabase);
            this.TablesControl.Controls.Add(this.UsersDatabase);
            this.TablesControl.Controls.Add(this.tabPage3);
            this.TablesControl.Controls.Add(this.tabPage4);
            this.TablesControl.Controls.Add(this.tabPage5);
            this.TablesControl.Location = new System.Drawing.Point(12, 12);
            this.TablesControl.Name = "TablesControl";
            this.TablesControl.SelectedIndex = 0;
            this.TablesControl.Size = new System.Drawing.Size(1278, 465);
            this.TablesControl.TabIndex = 3;
            // 
            // MainDatabase
            // 
            this.MainDatabase.Controls.Add(this.MainTable);
            this.MainDatabase.Controls.Add(this.MainTable_AddInformation);
            this.MainDatabase.Location = new System.Drawing.Point(4, 25);
            this.MainDatabase.Name = "MainDatabase";
            this.MainDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.MainDatabase.Size = new System.Drawing.Size(1270, 436);
            this.MainDatabase.TabIndex = 0;
            this.MainDatabase.Text = "Общая";
            this.MainDatabase.UseVisualStyleBackColor = true;
            // 
            // UsersDatabase
            // 
            this.UsersDatabase.Controls.Add(this.PlayersTable_AddInformation);
            this.UsersDatabase.Controls.Add(this.UsersTable);
            this.UsersDatabase.Location = new System.Drawing.Point(4, 25);
            this.UsersDatabase.Name = "UsersDatabase";
            this.UsersDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.UsersDatabase.Size = new System.Drawing.Size(1270, 436);
            this.UsersDatabase.TabIndex = 1;
            this.UsersDatabase.Text = "Пользователи";
            this.UsersDatabase.UseVisualStyleBackColor = true;
            // 
            // PlayersTable_AddInformation
            // 
            this.PlayersTable_AddInformation.BackColor = System.Drawing.Color.White;
            this.PlayersTable_AddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersTable_AddInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersTable_AddInformation.Location = new System.Drawing.Point(6, 379);
            this.PlayersTable_AddInformation.Name = "PlayersTable_AddInformation";
            this.PlayersTable_AddInformation.Size = new System.Drawing.Size(141, 46);
            this.PlayersTable_AddInformation.TabIndex = 2;
            this.PlayersTable_AddInformation.Text = "Добавить";
            this.PlayersTable_AddInformation.UseVisualStyleBackColor = false;
            this.PlayersTable_AddInformation.Click += new System.EventHandler(this.PlayersTable_AddInformation_Click);
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            this.UsersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersTable.BackgroundColor = System.Drawing.Color.White;
            this.UsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayersTableLogin,
            this.PlayersTableAge});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.UsersTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersTable.GridColor = System.Drawing.Color.White;
            this.UsersTable.Location = new System.Drawing.Point(3, 3);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 24;
            this.UsersTable.Size = new System.Drawing.Size(1264, 370);
            this.UsersTable.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1270, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1270, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1270, 436);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // PlayersTableLogin
            // 
            this.PlayersTableLogin.HeaderText = "Логин";
            this.PlayersTableLogin.MinimumWidth = 6;
            this.PlayersTableLogin.Name = "PlayersTableLogin";
            this.PlayersTableLogin.ReadOnly = true;
            this.PlayersTableLogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayersTableLogin.Width = 250;
            // 
            // PlayersTableAge
            // 
            this.PlayersTableAge.HeaderText = "Возраст";
            this.PlayersTableAge.MinimumWidth = 6;
            this.PlayersTableAge.Name = "PlayersTableAge";
            this.PlayersTableAge.ReadOnly = true;
            this.PlayersTableAge.Width = 70;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 494);
            this.Controls.Add(this.TablesControl);
            this.Controls.Add(this.txtResult);
            this.Name = "MainFrame";
            this.Text = "База данных Dupa Games Studio";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.TablesControl.ResumeLayout(false);
            this.MainDatabase.ResumeLayout(false);
            this.UsersDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Button MainTable_AddInformation;
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
        private System.Windows.Forms.TabControl TablesControl;
        private System.Windows.Forms.TabPage MainDatabase;
        private System.Windows.Forms.TabPage UsersDatabase;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.Button PlayersTable_AddInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayersTableLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayersTableAge;
    }
}

