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
    public partial class UsersLocalTable_Filter_Frame : Form
    {
        private MainFrame OriginFrame;
        public UsersLocalTable_Filter_Frame(MainFrame OriginFrame)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
        }

        public void DisableFilter()
        {
            var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
            while (LocalTable.Rows.Count != 0)
            {
                LocalTable.Rows.Remove(LocalTable.Rows[0]);
            }

            var HashTable = OriginFrame.PlayersInformationHash;
            for (int i = 0; i < HashTable.Size; i++)
            {
                if (HashTable[i] != null)
                {
                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["PlayersTableLogin"].Value = HashTable[i].Login;
                    LocalTable.Rows[rowNumber].Cells["PlayersTableAge"].Value = HashTable[i].Age;
                }
            }
        }

        private void FilterDataTypeButton_Click(object sender, EventArgs e)
        {
            switch(FilterComboBox.Text)
            {
                case "Поиск по логину":
                    Login_Filter_Frame LoginFilterPlayerDialog = new Login_Filter_Frame(OriginFrame, InterfaceCodes.FilterLocalTable);
                    LoginFilterPlayerDialog.ShowDialog(OriginFrame);
                    LoginFilterPlayerDialog.Dispose();
                    break;
                case "Поиск по возрасту":
                    Age_Filter_Frame AgeFilterPlayerDialog = new Age_Filter_Frame(OriginFrame, InterfaceCodes.FilterLocalTable);
                    AgeFilterPlayerDialog.ShowDialog(OriginFrame);
                    AgeFilterPlayerDialog.Dispose();

                    Close();
                    break;
                case "Сбросить фильтр":
                    DisableFilter();

                    Close();
                    break;
            }
        }

    }
}
