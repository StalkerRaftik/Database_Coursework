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
    public partial class GlobalTable_ChangeInfo_Frame : Form
    {
        public MainFrame OriginFrame;
        ChangeGlobalTableData action;
        GlobalInformation_Access_Syncronized GI_Access;
        public GlobalTable_ChangeInfo_Frame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
            GI_Access = new GlobalInformation_Access_Syncronized(OriginFrame);
            switch (code)
            {
                case InterfaceCodes.Add:
                    action = new AddInformation(this);
                    break;
                case InterfaceCodes.Remove:
                    action = new RemoveInformation(this);
                    break;
            }
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void PassedLevelsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            action.ChangeDataFromInterface(OriginFrame);
        }

        abstract class ChangeGlobalTableData
        {
            public abstract void ChangeDataFromInterface(MainFrame OriginFrame);
        }

        class AddInformation : ChangeGlobalTableData
        {
            GlobalTable_ChangeInfo_Frame CurFrame;
            public AddInformation(GlobalTable_ChangeInfo_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Добавить новую запись";
            }

            public override void ChangeDataFromInterface(MainFrame OriginFrame)
            {
                if (CurFrame.LoginTextBox.Text == "" 
                    || CurFrame.AgeTextBox.Text == "" 
                    || CurFrame.PassedLevelsTextBox.Text == "") return;

                var info = new GlobalInformation();
                info.Login = CurFrame.LoginTextBox.Text;
                info.Age = Int32.Parse(CurFrame.AgeTextBox.Text);
                info.PassedLevels = Int32.Parse(CurFrame.PassedLevelsTextBox.Text);
                info.GameName = CurFrame.GameNameComboBox.Text;
                info.Developer = CurFrame.DeveloperComboBox.Text;
                info.Contacts = CurFrame.ContactsComboTextBox.Text;
                info.FirstTimePlayed = CurFrame.FirstTimePlayedTimePicker.Value.Date.ToShortDateString();
                info.LastTimePlayed = CurFrame.LastTimePlayedTimePicker.Value.Date.ToShortDateString();


                var Added = CurFrame.GI_Access.AddData(info);

                if (Added)
                {
                    // Проверка для UserTable, есть ли у нас игрок с таким логином и возрастом
                    var PotentialNewPlayerInformation = new PlayerInformation
                    {
                        Login = info.Login,
                        Age = info.Age
                    };

                    var ExistingInfo = OriginFrame.PlayersInformationHash.Find(PotentialNewPlayerInformation);
                    if (ExistingInfo == null)
                    {
                        PlayerInformation_Access_Syncronized PI_Access = new PlayerInformation_Access_Syncronized(OriginFrame);
                        PI_Access.AddData(PotentialNewPlayerInformation);
                    }
                    else
                    {
                        if (PotentialNewPlayerInformation.Age != ExistingInfo.Age)
                        {
                            PlayerInformation_Access_Syncronized PI_Access = new PlayerInformation_Access_Syncronized(OriginFrame);
                            PI_Access.RemoveData(ExistingInfo);
                            PI_Access.AddData(PotentialNewPlayerInformation);
                        }
                    }
                }
            }
        }

        class RemoveInformation : ChangeGlobalTableData
        {
            GlobalTable_ChangeInfo_Frame CurFrame;
            public RemoveInformation(GlobalTable_ChangeInfo_Frame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Удалить запись";
                this.CurFrame.ChangeButton.Text = "Удалить";
            }

            public override void ChangeDataFromInterface(MainFrame OriginFrame)
            {
                var info = new GlobalInformation();
                info.Login = CurFrame.LoginTextBox.Text;
                info.Age = Int32.Parse(CurFrame.AgeTextBox.Text);
                info.PassedLevels = Int32.Parse(CurFrame.PassedLevelsTextBox.Text);
                info.GameName = CurFrame.GameNameComboBox.Text;
                info.Developer = CurFrame.DeveloperComboBox.Text;
                info.Contacts = CurFrame.ContactsComboTextBox.Text;
                info.FirstTimePlayed = CurFrame.FirstTimePlayedTimePicker.Value.Date.ToShortDateString();
                info.LastTimePlayed = CurFrame.LastTimePlayedTimePicker.Value.Date.ToShortDateString();

                CurFrame.GI_Access.RemoveData(info);
            }
        }
    }
}
