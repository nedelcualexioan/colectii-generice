using System;
using System.ComponentModel.DataAnnotations;

namespace colectii_generice.colectii
{
    public class SortedHashTable<K, V> where V : IComparable<V>
    {
        private SortList<HashEntry<K, V>>[] hashTable;

        public SortedHashTable()
        {
            hashTable = new SortList<HashEntry<K, V>>[10];

            for (int i = 0; i < hashTable.Length; i++)
            {
                hashTable[i] = new SortList<HashEntry<K, V>>();
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
    }
}