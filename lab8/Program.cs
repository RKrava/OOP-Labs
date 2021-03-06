﻿using System;

namespace lab8_lib
{
    public class Stack<T>
    {
        public delegate void ClearHandler(string message);
        public event ClearHandler Notify;
        public bool IsEmpty { get { return first == null; } }
        private Node<T> first;

        public void Push(T obj)
        {
            if (first == null)
                first = new Node<T>(obj);
            else
            {
                first = new Node<T>(obj, first);
            }
        }

        public void Clear()
        {
            while (!IsEmpty)
            {
                this.Pop();
            }
            Notify?.Invoke("Стек очищен!");
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");
            else
            {
                T ell = first.Element;
                first = first.Next;
                return ell;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");
            else
                return first.Element;
        }

        private class Node<E>
        {
            public E Element { get; private set; }
            public Node<E> Next { get; set; }

            public Node(E element)
            {
                Element = element;
            }

            public Node(E element, Node<E> next)
                : this(element)
            {
                Next = next;
            }
        }
    }
}
