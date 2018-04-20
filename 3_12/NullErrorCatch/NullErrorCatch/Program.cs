using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullErrorCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = null;
            try
            {
                Console.WriteLine(str.ToString());
                Console.WriteLine("Program Termiated");

            }
            catch (NullReferenceException e) // 에러처리
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
