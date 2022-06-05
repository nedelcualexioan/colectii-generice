using System;
using System.Linq;
using System.Net.Http;

namespace colectii_generice.colectii
{
    public class Queue<T> where T:IComparable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Queue(Queue<T> queue)
        {
            this.head = queue.head;
            this.tail = queue.tail;
        }

        public Queue()
        {

        }

        public bool isEmpty()
        {
            return head == null;
        }

        public T peek()
        {
            if (head != null)
                return head.Data;
            return default(T);
        }

        public void add(T data)
        {
            Node<T> node = new Node<T>();
            node.Data = data;
            node.Next = null;

            if (tail != null)
            {
                tail.Next = node;
            }

            tail = node;
           

            if (head == null)
            {
                head = node;
            }
        }

        public void remove()
        {
            head = head.Next;

            if (head == null)
            {
                tail = null; 
            }
        }

        

    }
}