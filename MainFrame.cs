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
    public enum InterfaceCodes
    {
        Add = 0,
        Remove = 1,
        FilterGlobalTable = 3,
        FilterLocalTable = 4,
    }

    public partial class MainFrame : Form
    {
        
        // Объявление хэшей + список общей таблицы. Свои хэши нужно сюда забрасывать
        public GlobalnformationList GlobalInformation = new GlobalnformationList();
        public PlayerInformationHashTable PlayersInformationHash = new PlayerInformationHashTable();


        // Объявление деревьев поиска
        public Smirnov_GlobalInformationBlackRedTree GlobalInformationTree = new Smirnov_GlobalInformationBlackRedTree();
        public Smirnov_GlobalInformationBlackRedTree PlayerInformationTree = new Smirnov_GlobalInformationBlackRedTree();

        public TabControl FrameTables;
        public MainFrame()
        {
            InitializeComponent();
            FrameTables = TablesControl;
        }


        //===========================================
        //========== Глобальная таблица =============
        //===============(хэндлеры)==================

        private void AddInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_ChangeInfo_Frame AddInformationDialog = new GlobalTable_ChangeInfo_Frame(this, InterfaceCodes.Add);
            AddInformationDialog.ShowDialog(this);
            AddInformationDialog.Dispose();
        }

        private void MainTable_DeleteInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_ChangeInfo_Frame RemoveInformationDialog = new GlobalTable_ChangeInfo_Frame(this, InterfaceCodes.Remove);
            RemoveInformationDialog.ShowDialog(this);
            RemoveInformationDialog.Dispose();
        }

        private void MainTable_SearchButton_Click(object sender, EventArgs e)
        {
            var FilterInformationDialog = new GlobalTable_Filter_Frame(this);
            FilterInformationDialog.ShowDialog(this);
            FilterInformationDialog.Dispose();
        }

        //===========================================
        //========== Таблица игроков ================
        //===============(хэндлеры)==================
        private void PlayersTable_AddInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_ChangeInfo_Frame testDialog = new PlayersTable_ChangeInfo_Frame(this, InterfaceCodes.Add);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void PlayersTable_RemoveInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_ChangeInfo_Frame testDialog = new PlayersTable_ChangeInfo_Frame(this, InterfaceCodes.Remove);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void PlayersTable_FilterInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_Filter_Frame testDialog = new PlayersTable_Filter_Frame(this, InterfaceCodes.FilterLocalTable);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }


        //===========================================
        //========== Таблица ...... ================
        //===============(хэндлеры)==================
    }

}
