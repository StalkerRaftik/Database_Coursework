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
    public partial class PlayersTable_Add_Frame : Form
    {
        MainFrame OriginFrame;
        public PlayersTable_Add_Frame(MainFrame OriginFrame)
        {
            InitializeComponent();

            this.OriginFrame = OriginFrame;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PlayerInformation info = new PlayerInformation();
            info.Login = LoginTextBox.Text;
            info.Age = Int32.Parse(AgeTextBox.Text);

            if (OriginFrame.PlayersInformationHash.Add(info))
            {
                var UsersTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                int rowNumber = UsersTable.Rows.Add();
                UsersTable.Rows[rowNumber].Cells["PlayersTableLogin"].Value = info.Login;
                UsersTable.Rows[rowNumber].Cells["PlayersTableAge"].Value = info.Age;
            }
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
