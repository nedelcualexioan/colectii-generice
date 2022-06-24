using colectii_generice.colectii;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace colectii_generice.hashTable
{
    public class HashTable<K, V> where V : IComparable<V>
    {
        private Lista<HashEntry<K, V>>[] hashTable;

        public HashTable()
        {


            hashTable = new Lista<HashEntry<K, V>>[10];

            for (int i = 0; i < hashTable.Length; i++)
            {
                    
                hashTable[i] = new Lista<HashEntry<K, V>>();
            }

        }

        private int hashKey(K key)
        {
            return key.ToString().Length * 5 % hashTable.Length;
        }

        public void put(K key, V value)
        {
            int pozitie = hashKey(key);

            HashEntry<K, V> entry = new HashEntry<K, V>();
            entry.Key = key;
            entry.Value = value;

            hashTable[pozitie].add(entry);
        }


        public V get(K key)
        {
            int poz = hashKey(key);

            for (int i = 0; i < hashTable[poz].size(); i++)
            {
                if (hashTable[poz].get(i).Key.Equals(key))
                    return hashTable[poz].get(i).Value;
            }

            return default(V);
        }

        public void remove(K key)
        {
            int poz = hashKey(key);

            for (int i = 0; i < hashTable[poz].size(); i++)
            {
                if (hashTable[poz].get(i).Key.Equals(key))
                {
                    hashTable[poz].remove(hashTable[poz].get(i));

                    return;
                }
            }
        }

        public void afisare()
        {
            for (int i = 0; i < hashTable.Length; i++)
            {
                hashTable[i].afisare();
            }
        }
    }
}