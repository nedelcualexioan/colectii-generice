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

        public int Count
        {
            get => this.count();
        }

        public T Max
        {
            get => this.max();
        }

        public T Min
        {
            get => this.min();
        }
     
        private int count()
        {
            int k = 0;
            Node<T> enumerator = head;

            while (enumerator != null)
            {
                k++;
                enumerator = enumerator.Next;
            }

            return k;
        }

        private T max()
        {
            T max = head.Data;

            Node<T> enumerator = head.Next;

            while (enumerator != null)
            {
                if (enumerator.Data.CompareTo(max) > 0)
                {
                    max = enumerator.Data;
                }
            }

            return max;
        }
        private T min()
        {
            T min = head.Data;

            Node<T> enumerator = head.Next;

            while (enumerator != null)
            {
                if (enumerator.Data.CompareTo(min) < 0)
                {
                    min = enumerator.Data;
                }
            }

            return min;
        }

        public bool isEmpty()
        {
            return head == null;
        }

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

            if (head.Next == null)
            {
                if (data.CompareTo(head.Data) > 0)
                {
                    head.Next = new Node<T>(data, null);
                }
                else
                {
                    head = new Node<T>(data, head);
                }

                return true;
            }

            Node<T> enumerator = head;

            while (enumerator.Next != null && data.CompareTo(enumerator.Next.Data) > 0)
            {
                enumerator = enumerator.Next;
            }

            if (data.CompareTo(enumerator.Data) == 0)
                return false;

            Node<T> node = new Node<T>(data, enumerator.Next);

            enumerator.Next = node;

            return true;
        }

        public T pop()
        {
            T data = head.Data;

            head = head.Next;

            return data;
        }

        public void clear()
        {
            head = null;
        }

        public bool contains(T data)
        {
            Node<T> enumerator = head;

            while (enumerator != null)
            {
                if (data.CompareTo(enumerator.Data) == 0)
                    return true;

                enumerator = enumerator.Next;
            }

            return false;
        }

        public bool remove(T data)
        {
            Node<T> enumerator = head;

            while (enumerator != null)
            {
                if (enumerator.Data.CompareTo(data) == 0)
                {
                    enumerator.Data = enumerator.Next.Data;
                    enumerator.Next = enumerator.Next.Next;

                    return true;
                }

                enumerator = enumerator.Next;
            }

            return false;
        }
    }
}
