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
        // Коды которые необходимо передавать в интерфейс
        const string CODE_ADD = "Add";
        const string CODE_REMOVE = "Remove";

        // Объявление хэшей + список общей таблицы. Свои хэши нужно сюда забрасывать
        public GlobalnformationList GlobalInformation = new GlobalnformationList();
        public PlayerInformationHashTable PlayersInformationHash = new PlayerInformationHashTable();

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
            GlobalTable_Interface_Frame testDialog = new GlobalTable_Interface_Frame(this, CODE_ADD);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void MainTable_DeleteInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_Interface_Frame testDialog = new GlobalTable_Interface_Frame(this, CODE_REMOVE);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        //===========================================
        //========== Таблица игроков ================
        //===============(хэндлеры)==================
        private void PlayersTable_AddInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_Interface_Frame testDialog = new PlayersTable_Interface_Frame(this, CODE_ADD);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void PlayersTable_RemoveInformation_Click(object sender, EventArgs e)
        {
            PlayersTable_Interface_Frame testDialog = new PlayersTable_Interface_Frame(this, CODE_REMOVE);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }


        //===========================================
        //========== Таблица ...... ================
        //===============(хэндлеры)==================
    }

}
