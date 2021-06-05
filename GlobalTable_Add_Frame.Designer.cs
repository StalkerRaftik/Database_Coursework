
namespace _30_05_2021_Database_Coursework
{
    partial class GlobalTable_Add_Frame
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
            this.AddButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GameNameComboBox = new System.Windows.Forms.ComboBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.PassedLevelsLabel = new System.Windows.Forms.Label();
            this.PassedLevelsTextBox = new System.Windows.Forms.TextBox();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.DeveloperComboBox = new System.Windows.Forms.ComboBox();
            this.LastTimePlayedLabel = new System.Windows.Forms.Label();
            this.FirstTimePlayedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FirstTimePlayedLabel = new System.Windows.Forms.Label();
            this.LastTimePlayedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.ContactsComboTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(54, 439);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(170, 36);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(80, 64);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(199, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 67);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(51, 17);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин:";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(36, 18);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(220, 23);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Добавить новую запись";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(82, 110);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(197, 22);
            this.AgeTextBox.TabIndex = 4;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 113);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(66, 17);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Возраст:";
            // 
            // GameNameComboBox
            // 
            this.GameNameComboBox.FormattingEnabled = true;
            this.GameNameComboBox.Location = new System.Drawing.Point(129, 153);
            this.GameNameComboBox.Name = "GameNameComboBox";
            this.GameNameComboBox.Size = new System.Drawing.Size(150, 24);
            this.GameNameComboBox.TabIndex = 6;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(12, 156);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(111, 17);
            this.GameNameLabel.TabIndex = 7;
            this.GameNameLabel.Text = "Название игры:";
            // 
            // PassedLevelsLabel
            // 
            this.PassedLevelsLabel.AutoSize = true;
            this.PassedLevelsLabel.Location = new System.Drawing.Point(12, 282);
            this.PassedLevelsLabel.Name = "PassedLevelsLabel";
            this.PassedLevelsLabel.Size = new System.Drawing.Size(141, 34);
            this.PassedLevelsLabel.TabIndex = 8;
            this.PassedLevelsLabel.Text = "Кол-во пройденных \r\nуровней:\r\n";
            // 
            // PassedLevelsTextBox
            // 
            this.PassedLevelsTextBox.Location = new System.Drawing.Point(159, 294);
            this.PassedLevelsTextBox.Name = "PassedLevelsTextBox";
            this.PassedLevelsTextBox.Size = new System.Drawing.Size(120, 22);
            this.PassedLevelsTextBox.TabIndex = 9;
            this.PassedLevelsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Location = new System.Drawing.Point(12, 199);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(98, 17);
            this.DeveloperLabel.TabIndex = 10;
            this.DeveloperLabel.Text = "Разработчик:";
            // 
            // DeveloperComboBox
            // 
            this.DeveloperComboBox.FormattingEnabled = true;
            this.DeveloperComboBox.Location = new System.Drawing.Point(129, 199);
            this.DeveloperComboBox.Name = "DeveloperComboBox";
            this.DeveloperComboBox.Size = new System.Drawing.Size(150, 24);
            this.DeveloperComboBox.TabIndex = 11;
            // 
            // LastTimePlayedLabel
            // 
            this.LastTimePlayedLabel.AutoSize = true;
            this.LastTimePlayedLabel.Location = new System.Drawing.Point(12, 339);
            this.LastTimePlayedLabel.Name = "LastTimePlayedLabel";
            this.LastTimePlayedLabel.Size = new System.Drawing.Size(92, 51);
            this.LastTimePlayedLabel.TabIndex = 12;
            this.LastTimePlayedLabel.Text = "В последний\r\nраз заходил:\r\n\r\n";
            // 
            // FirstTimePlayedTimePicker
            // 
            this.FirstTimePlayedTimePicker.Location = new System.Drawing.Point(110, 352);
            this.FirstTimePlayedTimePicker.Name = "FirstTimePlayedTimePicker";
            this.FirstTimePlayedTimePicker.Size = new System.Drawing.Size(169, 22);
            this.FirstTimePlayedTimePicker.TabIndex = 13;
            // 
            // FirstTimePlayedLabel
            // 
            this.FirstTimePlayedLabel.AutoSize = true;
            this.FirstTimePlayedLabel.Location = new System.Drawing.Point(12, 390);
            this.FirstTimePlayedLabel.Name = "FirstTimePlayedLabel";
            this.FirstTimePlayedLabel.Size = new System.Drawing.Size(104, 34);
            this.FirstTimePlayedLabel.TabIndex = 14;
            this.FirstTimePlayedLabel.Text = "В первый раз\r\nзапустил игру:";
            // 
            // LastTimePlayedTimePicker
            // 
            this.LastTimePlayedTimePicker.Location = new System.Drawing.Point(122, 402);
            this.LastTimePlayedTimePicker.Name = "LastTimePlayedTimePicker";
            this.LastTimePlayedTimePicker.Size = new System.Drawing.Size(157, 22);
            this.LastTimePlayedTimePicker.TabIndex = 15;
            // 
            // ContactsLabel
            // 
            this.ContactsLabel.AutoSize = true;
            this.ContactsLabel.Location = new System.Drawing.Point(12, 236);
            this.ContactsLabel.Name = "ContactsLabel";
            this.ContactsLabel.Size = new System.Drawing.Size(96, 34);
            this.ContactsLabel.TabIndex = 16;
            this.ContactsLabel.Text = "Контактная\r\nинформация:";
            // 
            // ContactsComboTextBox
            // 
            this.ContactsComboTextBox.FormattingEnabled = true;
            this.ContactsComboTextBox.Location = new System.Drawing.Point(129, 246);
            this.ContactsComboTextBox.Name = "ContactsComboTextBox";
            this.ContactsComboTextBox.Size = new System.Drawing.Size(150, 24);
            this.ContactsComboTextBox.TabIndex = 17;
            // 
            // GlobalTable_Add_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 487);
            this.Controls.Add(this.ContactsComboTextBox);
            this.Controls.Add(this.ContactsLabel);
            this.Controls.Add(this.LastTimePlayedTimePicker);
            this.Controls.Add(this.FirstTimePlayedLabel);
            this.Controls.Add(this.FirstTimePlayedTimePicker);
            this.Controls.Add(this.LastTimePlayedLabel);
            this.Controls.Add(this.DeveloperComboBox);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.PassedLevelsTextBox);
            this.Controls.Add(this.PassedLevelsLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.GameNameComboBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AddButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalTable_Add_Frame";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox GameNameComboBox;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label PassedLevelsLabel;
        private System.Windows.Forms.TextBox PassedLevelsTextBox;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.ComboBox DeveloperComboBox;
        private System.Windows.Forms.Label LastTimePlayedLabel;
        private System.Windows.Forms.DateTimePicker FirstTimePlayedTimePicker;
        private System.Windows.Forms.Label FirstTimePlayedLabel;
        private System.Windows.Forms.DateTimePicker LastTimePlayedTimePicker;
        private System.Windows.Forms.Label ContactsLabel;
        private System.Windows.Forms.ComboBox ContactsComboTextBox;
    }
}