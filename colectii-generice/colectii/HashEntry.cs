using System;

namespace colectii_generice.colectii
{
    public class HashEntry<K,V> : IComparable<HashEntry<K,V>> where V : IComparable<V>
    {
        private K key;
        private V value;

        public K Key
        {
            get => key;
            set => key = value;
        }

        public V Value
        {
            get => value;
            set => this.value = value;
        }

        public int CompareTo(HashEntry<K, V> other)
        {
            if (value.CompareTo(other.Value) > 0)
                return 1;
            if (value.CompareTo(other.Value) < 0)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}