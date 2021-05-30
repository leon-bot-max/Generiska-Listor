using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiska_Listor
{
    class MyList<T>
    {
        T[] list = new T[0];

        public int Count   
        {
            get { return list.Length; }   
        }

        public void AddFirst(T data)
        {
            InsertAt(0, data);
        }

        public void RemoveFirst()
        {
            RemoveAt(0);
        }
        public void AddLast(T data)
        {
            InsertAt(Count, data);
        }

        public void RemoveLast()
        {
            RemoveAt(Count - 1);
        }

        public void InsertAt(int index, T data)
        {

            if (index > list.Length || index < 0)
                throw new IndexOutOfRangeException();

            T[] newList = new T[Count + 1];

            for (int i = 0; i < newList.Length; i++)
            {
                if (i == index)
                {
                    newList[i] = data;
                }
                else if (i < index)
                {
                    newList[i] = list[i];
                }
                else
                {
                    newList[i] = list[i-1];
                }
            }

            list = newList;

        }
        public void RemoveAt(int index)
        {
            if (index >= list.Length || index < 0)
                throw new IndexOutOfRangeException();

            T[] newList = new T[Count - 1];

            for (int i = 0; i < newList.Length; i++)
            {
                if (i != index)
                {
                    if (i < index)
                    {
                        newList[i] = list[i];
                    }
                    else
                    {
                        newList[i] = list[i + 1];
                    }
                }
            }

            list = newList;
        }
        public T this[int index]
        {
            get
            {
                if (index >= list.Length || index < 0)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
        }
    }
}
