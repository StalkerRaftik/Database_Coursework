using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_05_2021_Database_Coursework
{
    // Класс общей таблицы. Для последующих таблиц желательно брать идентичные названия атрибутов.
    public class GlobalInformation : ICloneable, IEquatable<GlobalInformation>
    {
        public string Login;
        public int Age;
        public int PassedLevels;
        public string GameName;
        public string Developer;
        public int TimeSpent;
        public string Contacts;
        public string FirstTimePlayed;
        public string LastTimePlayed;

        public override int GetHashCode()
        {
            return Login.GetHashCode() ^ Age ^ PassedLevels ^ GameName.GetHashCode() ^ Developer.GetHashCode() ^ TimeSpent
                ^ Contacts.GetHashCode() ^ FirstTimePlayed.GetHashCode() ^ LastTimePlayed.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is GlobalInformation))
                return false;

            return Equals((GlobalInformation)obj);
        }

        public bool Equals(GlobalInformation other)
        {
            if (Login != other.Login
                || Age != other.Age
                || PassedLevels != other.PassedLevels
                || GameName != other.GameName
                || Developer != other.Developer
                || TimeSpent != other.TimeSpent
                || Contacts != other.Contacts
                || FirstTimePlayed != other.FirstTimePlayed
                || LastTimePlayed != other.LastTimePlayed
            )
            {
                return false;
            }
                

            return true;
        }

        public static bool operator ==(GlobalInformation Info1, GlobalInformation Info2)
        {
            return Info1.Equals(Info2);
        }

        public static bool operator !=(GlobalInformation Info1, GlobalInformation Info2)
        {
            return !Info1.Equals(Info2);
        }

        public object Clone()
        {
            return new GlobalInformation
            {
                Login = this.Login,
                Age = this.Age,
                PassedLevels = this.PassedLevels,
                GameName = this.GameName,
                Developer = this.Developer,
                TimeSpent = this.TimeSpent,
                Contacts = this.Contacts,
                FirstTimePlayed = this.FirstTimePlayed,
                LastTimePlayed = this.LastTimePlayed
            };
        }
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
