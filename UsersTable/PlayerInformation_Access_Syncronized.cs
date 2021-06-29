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
    public class PlayerInformation_Access_Syncronized
    {
        MainFrame OriginFrame;
        public PlayerInformation_Access_Syncronized(MainFrame OriginFrame)
        {
            this.OriginFrame = OriginFrame;
        }

        public bool RemoveData(PlayerInformation info)
        {
            DataGridView UsersTable;
            if (OriginFrame.PlayersInformationHash.Remove(info))
            {
                UsersTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                for (int i = 0; i < UsersTable.Rows.Count; i++)
                {
                    if ((string)UsersTable.Rows[i].Cells["PlayersTableLogin"].Value == info.Login
                        && (int)UsersTable.Rows[i].Cells["PlayersTableAge"].Value == info.Age)
                    {
                        UsersTable.Rows.Remove(UsersTable.Rows[i]);
                    }
                }
                return true;
            }
            return false;
        }

        public bool AddData(PlayerInformation info)
        {
            if (OriginFrame.PlayersInformationHash.Add(info))
            {
                var UsersTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                int rowNumber = UsersTable.Rows.Add();
                UsersTable.Rows[rowNumber].Cells["PlayersTableLogin"].Value = info.Login;
                UsersTable.Rows[rowNumber].Cells["PlayersTableAge"].Value = info.Age;
                return true;
            } 
            else
            {
                OriginFrame.ThrowError("Элемент уже находится в справочнике!");
            }
            return false;
        }

        public void Clear()
        {
            var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
            while (LocalTable.Rows.Count != 0)
            {
                LocalTable.Rows.Remove(LocalTable.Rows[0]);
            }

            OriginFrame.PlayersInformationHash.Clear();
        }
    }
}
