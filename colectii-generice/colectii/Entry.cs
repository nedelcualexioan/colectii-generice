using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice.colectii
{
    class Entry<K,V>
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

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
