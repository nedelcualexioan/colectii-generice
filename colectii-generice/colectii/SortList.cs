using System;

namespace colectii_generice.colectii
{
    public class SortList<T> where T : IComparable<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get => head;
            set => head = value;
        }

        public void afisare()
        {
            Node<T> enumerator = head;

            while (enumerator != null)
            {

                Console.WriteLine(enumerator.Data.ToString());

                enumerator = enumerator.Next;
            }

        }

        private int getPozAdd(T data)
        {

            int i = 0;

            Node<T> enumerator = head;

            while (enumerator != null && data.CompareTo(enumerator.Data) > 0)
            {
                enumerator = enumerator.Next;
                i++;
            }

            return i;
        }

        private void addPoz(int poz, T data)
        {
            if (poz == 0)
            {
                head = new Node<T>(data, head);
            }

            Node<T> enumerator = head;
            int i = 0;

            while (enumerator != null)
            {
                if (i + 1 == poz)
                {
                    enumerator.Next = new Node<T>(data, enumerator.Next);


                    return;
                }

                enumerator = enumerator.Next;
                i++;
            }
        }

        public void add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data, null);
                return;
            }

            addPoz(getPozAdd(data), data);
        }
    }
}