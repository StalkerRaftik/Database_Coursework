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
    public partial class PlayersTable_Interface_Frame : Form
    {

        public MainFrame OriginFrame;
        ChangePlayersTableData action;
        PlayerInformation_Access_Syncronized TableAccess;
        public PlayersTable_Interface_Frame(MainFrame OriginFrame, string mode)
        {
            InitializeComponent();

            this.OriginFrame = OriginFrame;
            TableAccess = new PlayerInformation_Access_Syncronized(OriginFrame);
            switch(mode)
            {
                case "Add":
                    action = new AddInformation(this);
                    break;
                case "Remove":
                    action = new RemoveInformation(this, OriginFrame);
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            action.ChangeDataFromInterface();
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }



        abstract class ChangePlayersTableData
        {
            public abstract void ChangeDataFromInterface();
        }

        class AddInformation : ChangePlayersTableData
        {
            PlayersTable_Interface_Frame CurFrame;
            public AddInformation(PlayersTable_Interface_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Добавить новую запись";
            }

            public override void ChangeDataFromInterface()
            {
                PlayerInformation info = new PlayerInformation();
                info.Login = CurFrame.LoginTextBox.Text;
                info.Age = Int32.Parse(CurFrame.AgeTextBox.Text);

                CurFrame.TableAccess.AddData(info);
            }
        }

        class RemoveInformation : ChangePlayersTableData
        {
            PlayersTable_Interface_Frame CurFrame;
            MainFrame OriginFrame;
            public RemoveInformation(PlayersTable_Interface_Frame CurFrame, MainFrame OriginFrame)
            {
                this.CurFrame = CurFrame;
                this.OriginFrame = OriginFrame;
                this.CurFrame.MainLabel.Text = "Удалить запись";
                this.CurFrame.ApplyPlayerDataChangesButton.Text = "Удалить";
            }

            

            public override void ChangeDataFromInterface()
            {
                PlayerInformation info = new PlayerInformation();
                info.Login = CurFrame.LoginTextBox.Text;
                info.Age = Int32.Parse(CurFrame.AgeTextBox.Text);

                bool Deleted = this.CurFrame.TableAccess.RemoveData(info);

                if (Deleted)
                {
                    // Изменение глобальной таблицы
                    var UsersTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                    for (int i = 0; i < UsersTable.Rows.Count; i++)
                    {
                        if ((string)UsersTable.Rows[i].Cells["Login"].Value == info.Login
                            && (int)UsersTable.Rows[i].Cells["Age"].Value == info.Age)
                        {
                            UsersTable.Rows.Remove(UsersTable.Rows[i]);
                        }
                    }
                }
            }
        }
    }

    
}
