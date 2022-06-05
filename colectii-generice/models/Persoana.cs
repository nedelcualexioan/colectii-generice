﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice
{
    public class Persoana : IComparable<Persoana>
    {

        private String nume;
        private String prenume;
        private int varsta;
        private String adresa;

        public Persoana(String nume, String prenume, int varsta, String adresa)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.adresa = adresa;
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

        public override string ToString()
        {
            String text = "";

            text += "Nume: " + nume + "\n";
            text += "Prenume: " + prenume + "\n";
            text += "Varsta: " + varsta + "\n";
            text += "Adresa: " + adresa + "\n";

            return text;
        }
    }
}
