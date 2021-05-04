using System;
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
            {
                newNode.Next = First;
                First.Previous = newNode;
            }
            if (Last == null)
            {
                Last = newNode;
            }
            First = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (First != null && First.Next != null)
            {
                First.Next.Previous = null;
                First = First.Next;            
                Count--;
            }
            else //No next => First = Last
            {
                Last = null;
                First = null;
                Count = 0;
            }
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
            Count++;
        }

        public void RemoveLast()
        {
            if (Last != null && Last.Previous != null)
            {
                Last.Previous.Next = null;
                Last = Last.Previous;
                Count--;
            }
            else //No previous => First = Last
            {
                Last = null;
                First = null;
                Count = 0;
            }
            
        }

        public void InsertAt(int index, T data)
        {
            if (index > Count || index < 0)
                throw new IndexOutOfRangeException();
            if (Count == 0)
            {
                AddFirst(data);
                return;
            }
            
            
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            if (index < Count)
            {
                newNode.Next = this[index];
                this[index].Previous = newNode;
            }
            if (index - 1 >= 0)
            {
                newNode.Previous = this[index - 1];
                this[index - 1].Next = newNode;
            }

            Count++;
        }

        public void RemoveAt(int index)
        {
            Console.WriteLine("Removing: " + this[index].ToString());

            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException();
            if (index == 0)
            {
                RemoveFirst();
                return;
            }
            if (index == Count - 1)
            {
                RemoveLast();
                return;
            }
            if (this[index].Next != null)
            {
                this[index].Next.Previous = this[index].Previous;
            }
            if (this[index].Previous != null)
            {
                this[index].Previous.Next = this[index].Next;
            }
            Count--;
        }
        public Node<T> this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException();

                Node<T> nod = First;
                int i = 0;
                while (i < index)
                {
                    nod = nod.Next;
                    i++;
                }
                return nod;
            }
        }
    }
}
