using System;
using System.IO;
using colectii_generice.colectii;
using colectii_generice.hashTable;

namespace colectii_generice.controllers
{
    public class Controller
    {
        private Lista<Persoana> persoane;
        private Lista<Masina> masini;

        private HashTable<Persoana, Lista<Masina>> hashTable;

        public Controller()
        {
            persoane = new Lista<Persoana>();
            masini = new Lista<Masina>();

            hashTable = new HashTable<Persoana, Lista<Masina>>();

            loadMasini();
            loadPersoane();
        }

        public void afisarePers()
        {
            persoane.afisare();
        }

        public void afisareMasini()
        {
            masini.afisare();
        }

        public Lista<Masina> getMasiniPers(int persId)
        {
            Lista<Masina> list = new Lista<Masina>();

            for (int i = 0; i < masini.size(); i++)
            {
                if (masini.get(i).PersId.Equals(persId))
                {
                    list.add(masini.get(i));
                }
            }

            return list;
        }

        public Lista<Persoana> getPersoane()
        {
            Lista<Persoana> list = new Lista<Persoana>();

            for (int i = 0; i < persoane.size(); i++)
            {
                list.add(persoane.get(i));
            }

            return list;
        }

        public Lista<Masina> getMasini()
        {
            Lista<Masina> list = new Lista<Masina>();

            for (int i = 0; i < masini.size(); i++)
            {
                list.add(masini.get(i));
            }

            return list;
        }

        private void loadPersoane()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "database\\persoane.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                persoane.add(new Persoana(line));
            }
        }

        private void loadMasini()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "database\\masini.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                masini.add(new Masina(line));
            }
        }

        private void loadHashTable()
        {
            for (int i = 0; i < persoane.size(); i++)
            {
                hashTable.put(persoane.get(i), getMasiniPers(persoane.get(i).Id));
            }
        }

    }
}