using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_05_2021_Database_Coursework
{
    // Класс общей таблицы. Для последующих таблиц желательно брать идентичные названия атрибутов.
    public class GlobalInformation
    {
        public string Login;
        public int Age;
        public int PassedLevels;
        public string GameName;
        public string Developer;
        public int TimeSpent;
        public string Contacts;
        public DateTime FirstTimePlayed;
        public DateTime LastTimePlayed;
    }

    public class PlayerInformation : ICloneable
    {
        public string Login { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return new PlayerInformation { Login = this.Login, Age = this.Age };
        }
    }
}
