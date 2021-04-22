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


        public void AddFirst(T data)
        {
            list.Insert(0, data);
        }

        public void AddLast(T data)
        {
            list.Add(data);
        }

        public void RemoveLast()
        {
            list.RemoveAt(list.Count - 1);
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
