using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice
{
    public class Persoana : IComparable<Persoana>
    {
        private int id;
        private String nume;
        private String prenume;
        private int varsta;
        private String adresa;



        public Persoana(int id, String nume, String prenume, int varsta, String adresa)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.adresa = adresa;
        }

        public Persoana(String line)
        {
            id = int.Parse(line.Split(',')[0]);
            nume = line.Split(',')[1];
            prenume = line.Split(',')[2];
            varsta = int.Parse(line.Split(',')[3]);
            adresa = line.Split(',')[4];
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public String FullName
        {
            get => this.nume + " " + this.prenume;
        }

        public String Nume
        {
            get => this.nume;
            set => this.nume = value;
        }

        public String Prenume
        {
            get => this.prenume;
            set => this.prenume = value;
        }

        public int Varsta
        {
            get => this.varsta;
            set => this.varsta = value;
        }

        public String Adresa
        {
            get => this.adresa;
            set => this.adresa = value;
        }

        public int CompareTo(Persoana other)
        {
            if (this.FullName.CompareTo(other.FullName) > 0)
                return 1;
            if (this.FullName.CompareTo(other.FullName) < 0)
                return -1;
            return 0;
        }

        public override bool Equals(object obj)
        {
            if(obj is Persoana pers)
            {
                return pers.Nume == nume && pers.Prenume == prenume && pers.Varsta == varsta && pers.Adresa == adresa;
            }

            return false;
        }

        public override String ToString()
        {
            String text = "";

            text += "ID: " + id + "\n";
            text += "Nume: " + nume + "\n";
            text += "Prenume: " + prenume + "\n";
            text += "Varsta: " + varsta + "\n";
            text += "Adresa: " + adresa + "\n";

            return text;
        }
    }
}
