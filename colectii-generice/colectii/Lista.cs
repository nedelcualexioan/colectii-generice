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
            Node<T> enumerator = head;

            while(enumerator.Next != null)
            {
                enumerator = enumerator.Next;
            }

            Node<T> node = new Node<T>();
            node.Data = elem;
            node.Next = null;

            enumerator.Next = node;
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
    }
}
