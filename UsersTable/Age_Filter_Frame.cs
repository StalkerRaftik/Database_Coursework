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
    public partial class Age_Filter_Frame : Form
    {
        private MainFrame OriginFrame;
        private FilterData filterHandler;
        public bool IsFilterOn;
        public Age_Filter_Frame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
            switch(code)
            {
                case InterfaceCodes.FilterGlobalTable:
                    filterHandler = new FilterGlobalData(this);
                    break;
                case InterfaceCodes.FilterLocalTable:
                    filterHandler = new FilterLocalData(this);
                    break;
            }
        }

        private void AgeFilterButton_Click(object sender, EventArgs e)
        {
            filterHandler.FilterDataFromInterface(OriginFrame, int.Parse(FilterFromAgeUpDown.Value.ToString()), int.Parse(FilterToAgeUpDown.Value.ToString()));
        }

        abstract class FilterData
        {
            public abstract void FilterDataFromInterface(MainFrame OriginFrame, int from, int to);
        }

        class FilterGlobalData : FilterData
        {
            Age_Filter_Frame CurFrame;
            public FilterGlobalData(Age_Filter_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, int from, int to)
            {
                // Очищаем таблицу
                var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                while(GlobalTable.Rows.Count != 0)
                {
                    GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
                }

                var FilteredElements = OriginFrame.GlobalInformationTree.FindByInterval(from, to);
                for (int i = 0; i < FilteredElements.Count; i++)
                {
                    int rowNumber = GlobalTable.Rows.Add();
                    GlobalTable.Rows[rowNumber].Cells["Login"].Value = FilteredElements[i].Login;
                    GlobalTable.Rows[rowNumber].Cells["Age"].Value = FilteredElements[i].Age;
                    GlobalTable.Rows[rowNumber].Cells["PassedLevels"].Value = FilteredElements[i].PassedLevels;
                    GlobalTable.Rows[rowNumber].Cells["GameName"].Value = FilteredElements[i].GameName;
                    GlobalTable.Rows[rowNumber].Cells["Developer"].Value = FilteredElements[i].Developer;
                    GlobalTable.Rows[rowNumber].Cells["Contacts"].Value = FilteredElements[i].Contacts;
                    GlobalTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value = FilteredElements[i].FirstTimePlayed;
                    GlobalTable.Rows[rowNumber].Cells["LastTimePlayed"].Value = FilteredElements[i].LastTimePlayed;
                }
            }
        }

        class FilterLocalData : FilterData
        {
            Age_Filter_Frame CurFrame;
            public FilterLocalData(Age_Filter_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, int from, int to)
            {
                // Очищаем таблицу
                var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                while (LocalTable.Rows.Count != 0)
                {
                    LocalTable.Rows.Remove(LocalTable.Rows[0]);
                }

                var FilteredElements = OriginFrame.PlayersInformationHash.FindByAgesInterval(from, to);
                for (int i = 0; i < FilteredElements.Count; i++)
                {
                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["PlayersTableLogin"].Value = FilteredElements[i].Login;
                    LocalTable.Rows[rowNumber].Cells["PlayersTableAge"].Value = FilteredElements[i].Age;
                }
            }
        }

        
    }
}
