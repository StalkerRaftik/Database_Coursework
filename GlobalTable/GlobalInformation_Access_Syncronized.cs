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
    public class GlobalInformation_Access_Syncronized
    {
        MainFrame OriginFrame;
        public GlobalInformation_Access_Syncronized(MainFrame OriginFrame)
        {
            this.OriginFrame = OriginFrame;
        }

        public bool AddData(GlobalInformation info)
        {
            if (OriginFrame.GlobalInformation.Add(info))
            {
                var UsersTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                int rowNumber = UsersTable.Rows.Add();
                UsersTable.Rows[rowNumber].Cells["Login"].Value = info.Login;
                UsersTable.Rows[rowNumber].Cells["Age"].Value = info.Age;
                UsersTable.Rows[rowNumber].Cells["PassedLevels"].Value = info.PassedLevels;
                UsersTable.Rows[rowNumber].Cells["GameName"].Value = info.GameName;
                UsersTable.Rows[rowNumber].Cells["Developer"].Value = info.Developer;
                UsersTable.Rows[rowNumber].Cells["Contacts"].Value = info.Contacts;
                UsersTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value = info.FirstTimePlayed;
                UsersTable.Rows[rowNumber].Cells["LastTimePlayed"].Value = info.LastTimePlayed;

                return true;
            }
            return false;
        }

        public bool RemoveData(GlobalInformation info)
        {
            DataGridView UsersTable;
            if (OriginFrame.GlobalInformation.Remove(info))
            {
                UsersTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                for (int rowNumber = 0; rowNumber < UsersTable.Rows.Count; rowNumber++)
                {
                    if ((string)UsersTable.Rows[rowNumber].Cells["Login"].Value == info.Login
                    && (int)UsersTable.Rows[rowNumber].Cells["Age"].Value == info.Age
                    && (int)UsersTable.Rows[rowNumber].Cells["PassedLevels"].Value == info.PassedLevels
                    && (string)UsersTable.Rows[rowNumber].Cells["GameName"].Value == info.GameName
                    && (string)UsersTable.Rows[rowNumber].Cells["Developer"].Value == info.Developer
                    && (string)UsersTable.Rows[rowNumber].Cells["Contacts"].Value == info.Contacts
                    && (string)UsersTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value == info.FirstTimePlayed
                    && (string)UsersTable.Rows[rowNumber].Cells["LastTimePlayed"].Value == info.LastTimePlayed)
                    {
                        UsersTable.Rows.Remove(UsersTable.Rows[rowNumber]);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
