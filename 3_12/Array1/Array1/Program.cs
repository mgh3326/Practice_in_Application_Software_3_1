using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_1 = new int[5] { 3, 5, 7, 4, 1 };
            int[] arr_2 = (int[])arr_1.Clone();
            foreach (int item in arr_2)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
