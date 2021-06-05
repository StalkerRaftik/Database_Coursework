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
    public partial class MainFrame : Form
    {
        public TabControl FrameTables;

        public HashTable PlayersInformationHash = new HashTable();
        public MainFrame()
        {
            InitializeComponent();
            FrameTables = TablesControl;
        }


        private void AddInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_Add_Frame testDialog = new GlobalTable_Add_Frame();

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

        private void PlayersTable_AddInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_Add_Frame testDialog = new PlayersTable_Add_Frame(this);

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
