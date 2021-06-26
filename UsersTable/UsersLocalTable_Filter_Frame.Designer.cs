
namespace _30_05_2021_Database_Coursework
{
    partial class UsersLocalTable_Filter_Frame
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
            this.components = new System.ComponentModel.Container();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterDataTypeButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.playerInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Поиск по возрасту",
            "Поиск по логину",
            "Сбросить фильтр"});
            this.FilterComboBox.Location = new System.Drawing.Point(12, 94);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(267, 24);
            this.FilterComboBox.TabIndex = 0;
            // 
            // FilterDataTypeButton
            // 
            this.FilterDataTypeButton.Location = new System.Drawing.Point(74, 154);
            this.FilterDataTypeButton.Name = "FilterDataTypeButton";
            this.FilterDataTypeButton.Size = new System.Drawing.Size(131, 46);
            this.FilterDataTypeButton.TabIndex = 1;
            this.FilterDataTypeButton.Text = "Подтвердить";
            this.FilterDataTypeButton.UseVisualStyleBackColor = true;
            this.FilterDataTypeButton.Click += new System.EventHandler(this.FilterDataTypeButton_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(12, 59);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(246, 18);
            this.FilterLabel.TabIndex = 2;
            this.FilterLabel.Text = "Выберите тип данных для поиска:";
            // 
            // playerInformationBindingSource
            // 
            this.playerInformationBindingSource.DataSource = typeof(_30_05_2021_Database_Coursework.PlayerInformation);
            // 
            // LocalTable_Filter_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 227);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterDataTypeButton);
            this.Controls.Add(this.FilterComboBox);
            this.Name = "LocalTable_Filter_Frame";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Button FilterDataTypeButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.BindingSource playerInformationBindingSource;
    }
}