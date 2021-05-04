using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiska_Listor
{
    class MyList<T>
    {
        List<T> list = new List<T>();

        public int Count   
        {
            get { return list.Count; }   
        }

        public void AddFirst(T data)
        {
            list.Insert(0, data);
        }

        public void RemoveFirst()
        {
            list.RemoveAt(0);
        }
        public void AddLast(T data)
        {
            list.Add(data);
        }

        public void RemoveLast()
        {
            list.RemoveAt(list.Count - 1);
        }

        public void InsertAt(int index, T data)
        {
            list.Insert(index, data);
        }
        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }
        public T this[int index]
        {
            get
            {
                if (index >= list.Count)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
        }
    }
}
