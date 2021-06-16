
namespace _30_05_2021_Database_Coursework
{
    partial class PlayersTable_Interface_Frame
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
            this.ApplyPlayerDataChangesButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyPlayerDataChangesButton
            // 
            this.ApplyPlayerDataChangesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ApplyPlayerDataChangesButton.Location = new System.Drawing.Point(62, 175);
            this.ApplyPlayerDataChangesButton.Name = "ApplyPlayerDataChangesButton";
            this.ApplyPlayerDataChangesButton.Size = new System.Drawing.Size(170, 36);
            this.ApplyPlayerDataChangesButton.TabIndex = 0;
            this.ApplyPlayerDataChangesButton.Text = "Добавить";
            this.ApplyPlayerDataChangesButton.UseVisualStyleBackColor = true;
            this.ApplyPlayerDataChangesButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTextBox_KeyPress);
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
            // PlayersTable_Interface_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 236);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ApplyPlayerDataChangesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayersTable_Interface_Frame";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyPlayerDataChangesButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
    }
}