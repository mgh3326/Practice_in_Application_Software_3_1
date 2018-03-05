using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_05_data_type_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char cValue1 = 'A';
            char cValue2 = '\x0041';
            char cValue3 = (char)65;
            char cValue4 = '\u0041';
            Console.WriteLine("문자 표현     :   {0}", cValue1);
            Console.WriteLine("16진수 표현   :   {0}", cValue2);
            Console.WriteLine("ASCII 표현    :   {0}", cValue3);
            Console.WriteLine("Unicode 표현  :   {0}", cValue4);
        }
    }
}
