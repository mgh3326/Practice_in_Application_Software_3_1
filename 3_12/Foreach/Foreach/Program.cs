using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("!");
            Console.Write("Values:");
            PrintValues(myAl);
        }

        public static void PrintValues(ArrayList myList)
        {
            foreach (string text in myList)
            {
                Console.Write("\t{0}", text);
            }
            Console.WriteLine();
        }
    }
}
