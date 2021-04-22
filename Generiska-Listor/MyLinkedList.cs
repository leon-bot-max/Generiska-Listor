﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiska_Listor
{


    class Node<T>
    {
        public Node<T> Next;
        public Node<T> Previous;
        public T Value;

        public override string ToString()
        {
            if (Value != null)
                return Value.ToString();
            else
                return "NULL!!!!";
        }
    }
    class MyLinkedList<T>
    {
        public int Count { get; set; }
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            if (First != null)
                newNode.Next = First;
            if (Last == null)
            {
                Last = newNode;
            }
            First = newNode;

            Node<T> n = First;
            while (n.Next != null)
            {
                n.Next.Previous = n;
                n = n.Next;
            }
            Last = n;
            Count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = data;
            if (Last != null)
            {
                Last.Next = newNode;
                newNode.Previous = Last;
            }
            Last = newNode;
        }

        public void RemoveLast()
        {
            if (Last.Previous != null)
            {
                Last.Previous.Next = null;
                Last = Last.Previous;
            }
            else
            {
                Last = null;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();

                Node<T> nod = First;
                int i = 0;
                while (i < index)
                {
                    nod = nod.Next;
                    i++;
                }
                return nod.Value;
            }
        }
    }
}
