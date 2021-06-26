
namespace _30_05_2021_Database_Coursework
{
    partial class Age_Filter_Frame
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
            this.FilterFromAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.FilterFromAgeLabel = new System.Windows.Forms.Label();
            this.FilterToAgeLabel = new System.Windows.Forms.Label();
            this.FilterToAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilterFromAgeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterToAgeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(63, 48);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(178, 24);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Поиск по возрасту";
            // 
            // FilterFromAgeUpDown
            // 
            this.FilterFromAgeUpDown.Location = new System.Drawing.Point(12, 147);
            this.FilterFromAgeUpDown.Name = "FilterFromAgeUpDown";
            this.FilterFromAgeUpDown.Size = new System.Drawing.Size(102, 22);
            this.FilterFromAgeUpDown.TabIndex = 1;
            // 
            // FilterFromAgeLabel
            // 
            this.FilterFromAgeLabel.AutoSize = true;
            this.FilterFromAgeLabel.Location = new System.Drawing.Point(13, 127);
            this.FilterFromAgeLabel.Name = "FilterFromAgeLabel";
            this.FilterFromAgeLabel.Size = new System.Drawing.Size(30, 17);
            this.FilterFromAgeLabel.TabIndex = 2;
            this.FilterFromAgeLabel.Text = "От:";
            // 
            // FilterToAgeLabel
            // 
            this.FilterToAgeLabel.AutoSize = true;
            this.FilterToAgeLabel.Location = new System.Drawing.Point(195, 127);
            this.FilterToAgeLabel.Name = "FilterToAgeLabel";
            this.FilterToAgeLabel.Size = new System.Drawing.Size(31, 17);
            this.FilterToAgeLabel.TabIndex = 3;
            this.FilterToAgeLabel.Text = "До:";
            // 
            // FilterToAgeUpDown
            // 
            this.FilterToAgeUpDown.Location = new System.Drawing.Point(195, 147);
            this.FilterToAgeUpDown.Name = "FilterToAgeUpDown";
            this.FilterToAgeUpDown.Size = new System.Drawing.Size(106, 22);
            this.FilterToAgeUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // AgeFilterButton
            // 
            this.AgeFilterButton.Location = new System.Drawing.Point(87, 242);
            this.AgeFilterButton.Name = "AgeFilterButton";
            this.AgeFilterButton.Size = new System.Drawing.Size(133, 47);
            this.AgeFilterButton.TabIndex = 6;
            this.AgeFilterButton.Text = "Поиск";
            this.AgeFilterButton.UseVisualStyleBackColor = true;
            this.AgeFilterButton.Click += new System.EventHandler(this.AgeFilterButton_Click);
            // 
            // PlayersTable_Filter_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 329);
            this.Controls.Add(this.AgeFilterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterToAgeUpDown);
            this.Controls.Add(this.FilterToAgeLabel);
            this.Controls.Add(this.FilterFromAgeLabel);
            this.Controls.Add(this.FilterFromAgeUpDown);
            this.Controls.Add(this.FilterLabel);
            this.Name = "PlayersTable_Filter_Frame";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.FilterFromAgeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterToAgeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.NumericUpDown FilterFromAgeUpDown;
        private System.Windows.Forms.Label FilterFromAgeLabel;
        private System.Windows.Forms.Label FilterToAgeLabel;
        private System.Windows.Forms.NumericUpDown FilterToAgeUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgeFilterButton;
    }
}