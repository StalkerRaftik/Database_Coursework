
namespace _30_05_2021_Database_Coursework
{
    partial class DebugFrame
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
            this.DebugTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugTextBox.Location = new System.Drawing.Point(0, 0);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(457, 539);
            this.DebugTextBox.TabIndex = 0;
            this.DebugTextBox.Text = "";
            // 
            // DebugFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 539);
            this.Controls.Add(this.DebugTextBox);
            this.Name = "DebugFrame";
            this.Text = "Отладка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DebugTextBox;
    }
}