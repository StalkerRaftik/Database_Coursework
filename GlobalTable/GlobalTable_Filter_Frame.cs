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
    public partial class GlobalTable_Filter_Frame : Form
    {
        private MainFrame OriginFrame;
        public GlobalTable_Filter_Frame(MainFrame OriginFrame)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
        }

        public void DisableFilter()
        {
            // Очищаем таблицу
            var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
            while(GlobalTable.Rows.Count != 0)
            {
                GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
            }

            var GlobalTableList = OriginFrame.GlobalInformation;
            var mover = GlobalTableList.Head;
            while(mover != null)
            {
                int rowNumber = GlobalTable.Rows.Add();
                GlobalTable.Rows[rowNumber].Cells["Login"].Value = mover.Info.Login;
                GlobalTable.Rows[rowNumber].Cells["Age"].Value = mover.Info.Age;
                GlobalTable.Rows[rowNumber].Cells["PassedLevels"].Value = mover.Info.PassedLevels;
                GlobalTable.Rows[rowNumber].Cells["GameName"].Value = mover.Info.GameName;
                GlobalTable.Rows[rowNumber].Cells["Developer"].Value = mover.Info.Developer;
                GlobalTable.Rows[rowNumber].Cells["Contacts"].Value = mover.Info.Contacts;
                GlobalTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value = mover.Info.FirstTimePlayed;
                GlobalTable.Rows[rowNumber].Cells["LastTimePlayed"].Value = mover.Info.LastTimePlayed;

                mover = mover.Next;
            }
        }

        private void FilterDataTypeButton_Click(object sender, EventArgs e)
        {
            switch(FilterComboBox.Text)
            {
                case "Поиск по логину":
                    Login_Filter_Frame LoginFilterPlayerDialog = new Login_Filter_Frame(OriginFrame, InterfaceCodes.FilterGlobalTable);
                    LoginFilterPlayerDialog.ShowDialog(OriginFrame);
                    LoginFilterPlayerDialog.Dispose();
                    break;
                case "Поиск по возрасту":
                    Age_Filter_Frame AgeFilterPlayerDialog = new Age_Filter_Frame(OriginFrame, InterfaceCodes.FilterGlobalTable);
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
