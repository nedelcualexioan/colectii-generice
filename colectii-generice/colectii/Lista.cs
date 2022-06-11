using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice.colectii
{
    class Lista<T> where T:IComparable<T>
    {
        Node<T> head;

        public Node<T> Head
        {
            get => this.head;
            set => this.head = value;
        }

        public T Max
        {
            get => this.max();
        }

        public void addStart(T data)
        {
            if(head == null)
            {
                head = new Node<T>();

                head.Data = data;
                head.Next = null;
            }
            else
            {
                Node<T> node = new Node<T>();
                node.Next = head;
                node.Data = data;
                head = node;
            }
        }

        public void afisare()
        {
            Node<T> enumerator = head;

            while (enumerator!= null)
            {

                Console.WriteLine(enumerator.Data.ToString());

                enumerator = enumerator.Next;
            }

           

        }

        public void add(T elem)
        {
            if (head == null)
            {
                head = new Node<T>();

                head.Data = elem;
                head.Next = null;
            }
            else
            {
                Node<T> enumerator = head;

                while (enumerator.Next != null)
                {
                    enumerator = enumerator.Next;
                }

                Node<T> node = new Node<T>();
                node.Data = elem;
                node.Next = null;

                enumerator.Next = node;
            }
        }

        public void remove(T elem)
        {
            Node<T> enumerator = head;

            while(enumerator != null&&enumerator.Data.Equals(elem)==false)
            {

                enumerator = enumerator.Next;
            }

            if (enumerator != null)
                enumerator.Next = enumerator.Next.Next;
        }

        public bool contains(T elem)
        {
            Node<T> enumerator = head;

            while(enumerator != null)
            {
                if (enumerator.Data.Equals(elem))
                {
                    return true;
                }

                enumerator = enumerator.Next;
            }

            return false;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public int indexOf(T elem)
        {
            int index = 0;

            Node<T> enumerator = head;

            while (enumerator != null)
            {
                if (enumerator.Data.Equals(elem))
                    return index;

                index++;
                enumerator = enumerator.Next;
            }

            return -1;
        }

        public int size()
        {
            int size = 0;

            Node<T> enumerator = head;

            while (enumerator != null)
            {
                size++;

                enumerator = enumerator.Next;
            }

            return size;
        }

        public T get(int index)
        {
            int k = 0;

            Node<T> enumerator = head;

            while (enumerator != null)
            {
                if (k == index)
                    return enumerator.Data;

                k++;
                enumerator = enumerator.Next;
            }

            return default(T);
        }

        public void set(T elem, int index)
        {
            if (index > size() - 1)
                return;

            int k = 0;

            Node<T> enumerator = head;

            while (enumerator != null)
            {
                if(k == index)
                {
                    enumerator.Data = elem;

                    return;
                }

                k++;
                enumerator = enumerator.Next;
            }

            
        }

        public void sortCr()
        {
            int flag;

            do
            {
                flag = 0;

                for (int i = 0; i < size() - 1; i++)
                {
                    if (get(i).CompareTo(get(i + 1)) > 0)
                    {
                        T e1 = get(i);
                        T e2 = get(i + 1);

                        set(e1, i + 1);
                        set(e2, i);

                        flag = 1;
                    }
                }
            } while (flag == 1);
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

                enumerator = enumerator.Next;
            }

            return max;
        }

        public void merge(Lista<T> list)
        {
            Node<T> enumerator = head;

            while (enumerator.Next != null)
            {
                enumerator = enumerator.Next;
            }

            Node<T> iterat = list.Head;

            while (iterat != null)
            {
                enumerator.Next = new Node<T>(iterat.Data, iterat.Next);

                iterat = iterat.Next;
                enumerator = enumerator.Next;
            }
        }

        public void reverse()
        {
            for (int i = 0; i < size() / 2; i++)
            {
                T e1 = get(i);
                T e2 = get(size() - 1 - i);

                set(e1, size() - 1 - i);
                set(e2, i);
            }
        }

        public void swap(ref Lista<T> other)
        {
            (other.Head, this.Head) = (this.Head, other.Head);
        }
    }
}
