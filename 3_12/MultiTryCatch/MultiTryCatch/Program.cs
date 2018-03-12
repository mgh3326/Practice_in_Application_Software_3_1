using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 11, 22, 33 };
            int[] arr2 = { 0, 1, 2 };
            for (int i = 0; i < arr1.Length; ++i)
            {
                try
                {
                    Console.WriteLine(arr1[i] + "/" + arr2[i] + "=" + arr1[i] / arr2[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Cant't divide");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
