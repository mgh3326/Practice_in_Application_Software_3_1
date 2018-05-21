using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("Count:   {0}", myAL.Count);
            Console.WriteLine("Capacity:   {0}", myAL.Capacity);
            Console.WriteLine("Values:");
            PrintValues(myAL);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("    {0}", obj);
            Console.WriteLine();
        }
    }
}
