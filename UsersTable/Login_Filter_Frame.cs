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
    public partial class Login_Filter_Frame : Form
    {
        private MainFrame OriginFrame;
        private FilterData filterHandler;
        public bool IsFilterOn;
        public Login_Filter_Frame(MainFrame OriginFrame, InterfaceCodes code)
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
            filterHandler.FilterDataFromInterface(OriginFrame, LoginTextBox.Text);
        }

        abstract class FilterData
        {
            public abstract void FilterDataFromInterface(MainFrame OriginFrame, string login);
        }

        class FilterGlobalData : FilterData
        {
            Login_Filter_Frame CurFrame;
            public FilterGlobalData(Login_Filter_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, string login)
            {
                // Очищаем таблицу
                var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                while(GlobalTable.Rows.Count != 0)
                {
                    GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
                }

                var TreeEl = OriginFrame.GlobalInformationTree.FindElemByLogin(OriginFrame.GlobalInformationTree.Head, login);
                
                
                if (TreeEl != null )
                {
                    var Element = TreeEl.info;
                    int rowNumber = GlobalTable.Rows.Add();
                    GlobalTable.Rows[rowNumber].Cells["Login"].Value = Element.Login;
                    GlobalTable.Rows[rowNumber].Cells["Age"].Value = Element.Age;
                    GlobalTable.Rows[rowNumber].Cells["PassedLevels"].Value = Element.PassedLevels;
                    GlobalTable.Rows[rowNumber].Cells["GameName"].Value = Element.GameName;
                    GlobalTable.Rows[rowNumber].Cells["Developer"].Value = Element.Developer;
                    GlobalTable.Rows[rowNumber].Cells["Contacts"].Value = Element.Contacts;
                    GlobalTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value = Element.FirstTimePlayed;
                    GlobalTable.Rows[rowNumber].Cells["LastTimePlayed"].Value = Element.LastTimePlayed;
                }
            }
        }

        class FilterLocalData : FilterData
        {
            Login_Filter_Frame CurFrame;
            public FilterLocalData(Login_Filter_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, string login)
            {
                // Очищаем таблицу
                var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                while (LocalTable.Rows.Count != 0)
                {
                    LocalTable.Rows.Remove(LocalTable.Rows[0]);
                }

                var Element = OriginFrame.PlayersInformationHash.FindByLogin(new PlayerInformation { Login = login });
                if (Element != null)
                {
                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["PlayersTableLogin"].Value = Element.Login;
                    LocalTable.Rows[rowNumber].Cells["PlayersTableAge"].Value = Element.Age;
                }
            }
        }
    }
}
