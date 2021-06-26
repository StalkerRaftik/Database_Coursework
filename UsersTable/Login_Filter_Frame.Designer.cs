
namespace _30_05_2021_Database_Coursework
{
    partial class Login_Filter_Frame
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
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterFromAgeLabel = new System.Windows.Forms.Label();
            this.AgeFilterButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(83, 36);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(157, 24);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Поиск по логину";
            // 
            // FilterFromAgeLabel
            // 
            this.FilterFromAgeLabel.AutoSize = true;
            this.FilterFromAgeLabel.Location = new System.Drawing.Point(12, 92);
            this.FilterFromAgeLabel.Name = "FilterFromAgeLabel";
            this.FilterFromAgeLabel.Size = new System.Drawing.Size(51, 17);
            this.FilterFromAgeLabel.TabIndex = 2;
            this.FilterFromAgeLabel.Text = "Логин:";
            // 
            // AgeFilterButton
            // 
            this.AgeFilterButton.Location = new System.Drawing.Point(87, 165);
            this.AgeFilterButton.Name = "AgeFilterButton";
            this.AgeFilterButton.Size = new System.Drawing.Size(129, 35);
            this.AgeFilterButton.TabIndex = 6;
            this.AgeFilterButton.Text = "Поиск";
            this.AgeFilterButton.UseVisualStyleBackColor = true;
            this.AgeFilterButton.Click += new System.EventHandler(this.AgeFilterButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(12, 112);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(289, 22);
            this.LoginTextBox.TabIndex = 7;
            // 
            // Login_Filter_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 218);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AgeFilterButton);
            this.Controls.Add(this.FilterFromAgeLabel);
            this.Controls.Add(this.FilterLabel);
            this.Name = "Login_Filter_Frame";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label FilterFromAgeLabel;
        private System.Windows.Forms.Button AgeFilterButton;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}