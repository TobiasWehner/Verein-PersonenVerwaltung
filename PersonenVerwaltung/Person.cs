using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonenVerwaltung
{
    public class Person
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Vorname { get; set; }
        public String Geburtstag { get; set; }
        public String Geschlecht { get; set; }
        public String Straße { get; set; }
        public int Hausnummer { get; set; }
        public String PLZ { get; set; }
        public String Land { get; set; }
        public String Tel { get; set; }
        public String Mobil { get; set; }
        public String EMail { get; set; }

        public Person(int iD, string name, string vorname, string geburtstag, string geschlecht, string straße, int hausnummer, string pLZ, string land, string tel, string mobil, string eMail)
        {
            ID = iD;
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
            Geschlecht = geschlecht;
            Straße = straße;
            Hausnummer = hausnummer;
            PLZ = pLZ;
            Land = land;
            Tel = tel;
            Mobil = mobil;
            EMail = eMail;
        }
        public override string ToString()
        {
            return this.Name + ", " + this.Vorname + ", " + this.Geburtstag + ", " + this.Geschlecht + ", " + this.Straße + ", " + this.PLZ + ", " + this.Land + ", " + this.Tel + ", " + this.Mobil + ", " + this.EMail;
        }
    }
}