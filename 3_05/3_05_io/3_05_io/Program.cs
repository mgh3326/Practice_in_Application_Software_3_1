using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_05_io
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;
            Console.WriteLine("당신의 이름은 ? ");
            strName = Console.ReadLine();

            Console.WriteLine("Hello, {0} !", strName);
        }
    }
}
