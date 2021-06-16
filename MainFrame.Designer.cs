
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.PlayersTableLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayersTableAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.MainTable_DeleteInformation = new System.Windows.Forms.Button();
            this.PlayersTable_RemoveInformation = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.MainTable.BackgroundColor = System.Drawing.Color.White;
            this.MainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTable.GridColor = System.Drawing.Color.White;
            this.MainTable.Location = new System.Drawing.Point(3, 3);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.MainDatabase.Controls.Add(this.MainTable_DeleteInformation);
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
            this.UsersDatabase.Controls.Add(this.PlayersTable_RemoveInformation);
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
            this.UsersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.UsersTable.BackgroundColor = System.Drawing.Color.White;
            this.UsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayersTableLogin,
            this.PlayersTableAge});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTable.DefaultCellStyle = dataGridViewCellStyle15;
            this.UsersTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersTable.GridColor = System.Drawing.Color.White;
            this.UsersTable.Location = new System.Drawing.Point(3, 3);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 24;
            this.UsersTable.Size = new System.Drawing.Size(1264, 370);
            this.UsersTable.TabIndex = 1;
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
            // MainTable_DeleteInformation
            // 
            this.MainTable_DeleteInformation.BackColor = System.Drawing.Color.White;
            this.MainTable_DeleteInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTable_DeleteInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTable_DeleteInformation.Location = new System.Drawing.Point(153, 379);
            this.MainTable_DeleteInformation.Name = "MainTable_DeleteInformation";
            this.MainTable_DeleteInformation.Size = new System.Drawing.Size(141, 46);
            this.MainTable_DeleteInformation.TabIndex = 2;
            this.MainTable_DeleteInformation.Text = "Удалить";
            this.MainTable_DeleteInformation.UseVisualStyleBackColor = false;
            this.MainTable_DeleteInformation.Click += new System.EventHandler(this.MainTable_DeleteInformation_Click);
            // 
            // PlayersTable_RemoveInformation
            // 
            this.PlayersTable_RemoveInformation.BackColor = System.Drawing.Color.White;
            this.PlayersTable_RemoveInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersTable_RemoveInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersTable_RemoveInformation.Location = new System.Drawing.Point(153, 379);
            this.PlayersTable_RemoveInformation.Name = "PlayersTable_RemoveInformation";
            this.PlayersTable_RemoveInformation.Size = new System.Drawing.Size(141, 46);
            this.PlayersTable_RemoveInformation.TabIndex = 3;
            this.PlayersTable_RemoveInformation.Text = "Удалить";
            this.PlayersTable_RemoveInformation.UseVisualStyleBackColor = false;
            this.PlayersTable_RemoveInformation.Click += new System.EventHandler(this.PlayersTable_RemoveInformation_Click);
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
        private System.Windows.Forms.Button MainTable_DeleteInformation;
        private System.Windows.Forms.Button PlayersTable_RemoveInformation;
    }
}

