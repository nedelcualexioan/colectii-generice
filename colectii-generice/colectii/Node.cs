using System;

namespace colectii_generice.colectii
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public Node()
        {
        }

        public T Data
        {
            get => data;
            set => data = value;
        }

        public Node<T> Next
        {
            get => next;
            set => next = value;
        }
        
    }
}