using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice.colectii
{
    public class SimpleHashTable<K, V>
    {
        private Entry<K, V>[] hashTable;


        public SimpleHashTable()
        {

            hashTable = new Entry<K, V>[10];
        }

        private int hashKey(K key)
        {
            return key.ToString().Length * 5 % hashTable.Length;


        }

        public void put(K key, V value)
        {
            int pozitie = hashKey(key);

            if (hashTable[pozitie] != null)
            {

                int stop = pozitie;

                if (pozitie == hashTable.Length - 1)
                {

                    pozitie = 0;
                }
                else
                {
                    pozitie++;
                }

                while (hashTable[pozitie] != null
                       && pozitie != stop)
                {

                    pozitie = (pozitie + 12) % hashTable.Length;
                }

                if (hashTable[pozitie] == null)
                {
                    hashTable[pozitie] = new Entry<K, V>();

                    hashTable[pozitie].Key = key;
                    hashTable[pozitie].Value = value;
                }
                else
                {

                    Console.WriteLine("asdasdasda");
                }


            }
            else
            {
                hashTable[pozitie] = new Entry<K, V>();

                hashTable[pozitie].Key = key;
                hashTable[pozitie].Value = value;
            }
        }

        //FIND 
        //AFISARE
        //STERGERE

        public int findPosition(K key)
        {

            int pozitie = hashKey(key);


            if (hashTable[pozitie] != null && hashTable[pozitie].Key.Equals(key))
            {

                return pozitie;
            }

            if (hashTable[pozitie] != null)
            {
                int stop = pozitie;

                if (pozitie == hashTable.Length - 1)
                {
                    pozitie = 0;
                }
                else
                {
                    pozitie++;
                }

                while (hashTable[pozitie] != null && pozitie != stop)
                {
                    if (hashTable[pozitie].Key.Equals(key))
                        return pozitie;

                    pozitie = (pozitie + 12) % hashTable.Length;
                }
            }

            return -1;

        }

        public void remove(K key)
        {
            int poz = findPosition(key);


            hashTable[poz] = null;
            Entry<K, V>[] nou = hashTable;

            hashTable = new Entry<K, V>[10];

            for (int i = 0; i < nou.Length; i++)
            {
                if (nou[i] != null)
                {
                    put(nou[i].Key, nou[i].Value);
                }
            }
        }

        public void afisare()
        {

            for (int i = 0; i < hashTable.Length; i++)
            {
                if (hashTable[i] != null)
                {
                    Console.WriteLine("Key: " + hashTable[i].Key.ToString() + "\n" + hashTable[i].Value.ToString());
                }
            }
            
        }

    }
}
