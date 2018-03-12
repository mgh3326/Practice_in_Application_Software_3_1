using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_1 = new int[5] { 3, 5, 7, 4, 1 };
            int[] arr_2 = new int[5] { 9, 3, 6, 5, 2 };
            int[] arr_3 = new int[10];
            arr_1.CopyTo(arr_3, 0);
            arr_2.CopyTo(arr_3, 5);
            foreach(int item in arr_3)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
