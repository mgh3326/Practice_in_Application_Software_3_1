using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class1
{
    class A
    {
        public void PrintA()
        {
            Console.WriteLine("A class function");
        }
    }
    class B : A
    {
        public void printB()
        {
            Console.WriteLine("B class function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.PrintA();
            b.printB();
        }
    }
}
