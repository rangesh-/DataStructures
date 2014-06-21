using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace DataStructures
{
    class LinkedList<T>
    {
        public T value { get; set; }
        public LinkedList<T> NextList { get; set; }

        public static void Print(LinkedList<T> list)
        {
            while (list != null)
            {
                Console.WriteLine("Node Value"+list.value);
                list = list.NextList;
            }
        }
    }


}
