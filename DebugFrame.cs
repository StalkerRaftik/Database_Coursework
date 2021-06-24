using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_05_2021_Database_Coursework
{
    public partial class DebugFrame : Form
    {
        public DebugFrame(string log)
        {
            InitializeComponent();
            AddLog(log);
        }

        public void AddLog(string Text)
        {
            DebugTextBox.Text = DebugTextBox.Text + Text + "\n";
        }
    }
}
