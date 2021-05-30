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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<PlayerInformation> Information = new List<PlayerInformation>();

            var info = new PlayerInformation()
            {
                Age = 10,
                Developer = "Медведи",
                Login = "_MotherDestroyer2011_",
            };
            Information.Add(info);

            for (int i = 0; i < Information.Count; i++)
            {
                int rowNumber = MainTable.Rows.Add();
                MainTable.Rows[rowNumber].Cells["Login"].Value = Information[i].Login;
                MainTable.Rows[rowNumber].Cells["Age"].Value = Information[i].Age;
                MainTable.Rows[rowNumber].Cells["Developer"].Value = Information[i].Developer;
            }
        }

        private void MainTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddInformation_Click(object sender, EventArgs e)
        {
            FilterDialog testDialog = new FilterDialog();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.txtResult.Text = "Есть контакт, все заебок";
            }
            else
            {
                this.txtResult.Text = "Cancelled";
            }
            testDialog.Dispose();
        }
    }

}
