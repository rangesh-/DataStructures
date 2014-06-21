using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1=new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            LinkedList<int> list3 = new LinkedList<int>();
           
            list1.value = 1;
            list1.NextList = list2;

            list2.value = 2;
            list2.NextList = list3;
             
            list3.value = 3;
           
            LinkedList<int>.Print(list1);
        }
    }
}
