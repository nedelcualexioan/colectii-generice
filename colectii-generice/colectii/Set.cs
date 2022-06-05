using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colectii_generice.colectii;

namespace colectii_generice.colectii
{
    class Set<T> where T :IComparable<T>
    {
        private Node<T> head;

        public bool add(T data)
        {
            if (head == null)
            {
                head = new Node<T>
                {
                    Data = data,
                    Next = null
                };

                return true;
            }

            Node<T> enumerator = head;

            while (data.CompareTo(enumerator.Data) > 0)
            {
                enumerator = enumerator.Next;
            }

            if (data.CompareTo(enumerator.Data) == 0)
                return false;

            Node<T> node = new Node<T>(data, enumerator.Next);

            enumerator.Next = node;

            return true;
        }
    }
}
