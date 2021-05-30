using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiska_Listor
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<string> list = new MyList<string>();
            list.AddFirst("först");


            //list.RemoveAt(5);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString() + " " + i);
            }
            Console.ReadLine();
        }
    }
}
