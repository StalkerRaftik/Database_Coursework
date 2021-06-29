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
                var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                int rowNumber = GlobalTable.Rows.Add();
                GlobalTable.Rows[rowNumber].Cells["Login"].Value = info.Login;
                GlobalTable.Rows[rowNumber].Cells["Age"].Value = info.Age;
                GlobalTable.Rows[rowNumber].Cells["PassedLevels"].Value = info.PassedLevels;
                GlobalTable.Rows[rowNumber].Cells["GameName"].Value = info.GameName;
                GlobalTable.Rows[rowNumber].Cells["Developer"].Value = info.Developer;
                GlobalTable.Rows[rowNumber].Cells["Contacts"].Value = info.Contacts;
                GlobalTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value = info.FirstTimePlayed;
                GlobalTable.Rows[rowNumber].Cells["LastTimePlayed"].Value = info.LastTimePlayed;


                OriginFrame.GlobalInformationTree.NewElem(OriginFrame.GlobalInformation.FindElemInfo(info));

                return true;
            } else
            {
                OriginFrame.ThrowError("Элемент уже находится в справочнике!");
            }
            return false;
        }

        public bool RemoveData(GlobalInformation info)
        {
            DataGridView GlobalTable;
            if (
                OriginFrame.GlobalInformationTree.DeleteElem(info)
                && OriginFrame.GlobalInformation.Remove(info)
                )
            {
                GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                for (int rowNumber = 0; rowNumber < GlobalTable.Rows.Count; rowNumber++)
                {
                    if ((string)GlobalTable.Rows[rowNumber].Cells["Login"].Value == info.Login
                    && (int)GlobalTable.Rows[rowNumber].Cells["Age"].Value == info.Age
                    && (int)GlobalTable.Rows[rowNumber].Cells["PassedLevels"].Value == info.PassedLevels
                    && (string)GlobalTable.Rows[rowNumber].Cells["GameName"].Value == info.GameName
                    && (string)GlobalTable.Rows[rowNumber].Cells["Developer"].Value == info.Developer
                    && (string)GlobalTable.Rows[rowNumber].Cells["Contacts"].Value == info.Contacts
                    && (string)GlobalTable.Rows[rowNumber].Cells["FirstTimePlayed"].Value == info.FirstTimePlayed
                    && (string)GlobalTable.Rows[rowNumber].Cells["LastTimePlayed"].Value == info.LastTimePlayed)
                    {
                        GlobalTable.Rows.Remove(GlobalTable.Rows[rowNumber]);
                    }
                }

                return true;
            }
            return false;
        }

        public void Clear()
        {
            var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
            while (GlobalTable.Rows.Count != 0)
            {
                GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
            }
            OriginFrame.GlobalInformation.Clear();
            OriginFrame.GlobalInformationTree.ClearTree();
        }
    }
}
