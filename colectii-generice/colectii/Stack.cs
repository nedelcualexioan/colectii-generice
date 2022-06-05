using System;
using System.ComponentModel;

namespace colectii_generice.colectii
{
    public class Stack<T>
    {
        private Node<T> top;

        public bool isEmpty()
        {
            return top == null;
        }

        public T peek()
        {
            if (top != null)
            {
                return top.Data;
            }

            return default(T);
        }

        public void push(T data)
        {
            Node<T> node = new Node<T>();
            node.Data = data;

            node.Next = top;
            top = node;
        }

        public T pop()
        {
            if (top == null)
                return default(T);

            T data = top.Data;
            top = top.Next;

            return data;
        }
    }
}