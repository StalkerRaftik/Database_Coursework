using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public PlayerInformationHashTable PlayersInformationHash;


        // Объявление деревьев поиска
        public Smirnov_GlobalInformationBlackRedTree GlobalInformationTree;
        public Smirnov_GlobalInformationBlackRedTree PlayerInformationTree;

        public TabControl FrameTables;
        public MainFrame()
        {
            InitializeComponent();
            FrameTables = TablesControl;
            PlayersInformationHash = new PlayerInformationHashTable(this);
            GlobalInformationTree = new Smirnov_GlobalInformationBlackRedTree(this);
        }


        //===========================================
        //============== Дебаг-меню =================
        //===========================================
        
        string Log = "";
        DebugFrame Debug;
        public void AddLog(string log)
        {
            Log += log + "\n";
            if (Debug != null)
            {
                Debug.AddLog(log);
            }
        }

        private void открытьДебагменюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug = new DebugFrame(Log);
            Debug.Show();
        }

        //===========================================
        //============ Сохранение таблицы ===========
        //===========================================

        public void SaveInformation()
        {
            //работа с файлом
            Stream SaveStream; //класс для передачи данных
            SaveFileDialog SaveMapDialog = new SaveFileDialog(); //окно сохраниния на пк

            SaveMapDialog.Filter = "Table files (*.tbl)|*.tbl"; //формат файла
            SaveMapDialog.FilterIndex = 2;
            SaveMapDialog.RestoreDirectory = true;

            if (SaveMapDialog.ShowDialog() == DialogResult.OK) //если пользователь сохраняет
            {
                if ((SaveStream = SaveMapDialog.OpenFile()) != null)   //открывается файл, куда сохранить
                {
                    string StringData = "";  //одна строка
                    GlobalnformationList.ListElem mover = GlobalInformation.Head;
                    while (mover != null)
                    {
                        GlobalInformation info = mover.Info;

                        StringData += info.Login + " " + info.Age + " " + info.PassedLevels + " " + info.GameName + " "
                            + info.Developer + " " + " " + info.Contacts + " " + info.FirstTimePlayed + " "
                            + info.LastTimePlayed + "\n";

                        mover = mover.Next;
                    }
                    StringData += "\n";


                    for (int i = 0; i < PlayersInformationHash.Size; i++)
                    {
                        PlayerInformationHashTable.TwoLinkedList.ListElem mover2 = PlayersInformationHash.Table[i].Head;
                        while (mover2 != null)
                        {
                            StringData += mover2.Info.Login + " " + mover2.Info.Age + "\n";

                            mover2 = mover2.Next;
                        }
                    }


                    byte[] Data = System.Text.Encoding.Default.GetBytes(StringData);  //закодировать в файл
                    SaveStream.Write(Data, 0, Data.Length);
                    SaveStream.Close();  //закрыть файл
                }
            }
        }


        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveInformation();
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInformation();
        }

        //===========================================
        //============== Загрузка таблицы ===========
        //===========================================

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream LoadStream;  //данные
            OpenFileDialog loadMapDialog = new OpenFileDialog();  //диалог для загрузки файла

            loadMapDialog.Filter = "Table files (*.tbl)|*.tbl"; //формат
            loadMapDialog.FilterIndex = 2;
            loadMapDialog.RestoreDirectory = true;

            if (loadMapDialog.ShowDialog() == DialogResult.OK) //нажали загрузить
            {
                if ((LoadStream = loadMapDialog.OpenFile()) != null)
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[LoadStream.Length];
                    // считываем данные
                    LoadStream.Read(array, 0, array.Length);
                    // декодируем байты в строку
                    string textFromFile = System.Text.Encoding.Default.GetString(array);



                    string[] Rows = textFromFile.Split('\n'); //просматриваем строку и разбивает ее на подстроки
                    int CurTable = 0;
                    for (int ri = 0; ri < Rows.Length - 1; ri++) //разбить на строки
                    {
                        if (Rows[ri] == "")
                            CurTable++;
                        else
                        {
                            string[] Infos = Rows[ri].Split(' ');
                            switch (CurTable)
                            {
                                case 0:
                                    GlobalInformation info = new GlobalInformation();
                                    info.Login = Infos[0];
                                    info.Age = int.Parse(Infos[1]);
                                    info.PassedLevels = int.Parse(Infos[2]);
                                    info.GameName = Infos[3];
                                    info.Developer = Infos[4];
                                    info.Contacts = Infos[5];
                                    info.FirstTimePlayed = Infos[6];
                                    info.LastTimePlayed = Infos[7];

                                    GlobalInformation_Access_Syncronized GI_Access = new GlobalInformation_Access_Syncronized(this);
                                    GI_Access.AddData(info);
                                    break;
                                case 1:
                                    PlayerInformation info2 = new PlayerInformation();
                                    info2.Login = Infos[0];
                                    info2.Age = int.Parse(Infos[1]);

                                    PlayerInformation_Access_Syncronized PI_Access = new PlayerInformation_Access_Syncronized(this);
                                    PI_Access.AddData(info2);
                                    break;
                            }
                        }
                    }
                }
            }
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
