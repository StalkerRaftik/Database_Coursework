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
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();
            ErrorText.Text = error;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
