using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act = () => Console.WriteLine("Lamda one line"); //MethodInvoker와 비슷
            Action<int> act1 = (int a) => Console.WriteLine(a.ToString());
            Action<uint> act2 = (uint a) => Console.WriteLine(a.ToString());
            Action<ulong> act3 = (ulong a) => Console.WriteLine(a.ToString());

            act();
            act1((int)Math.Pow(2, 19) - 1); // Mersenne prime
            act2((uint)Math.Pow(2, 31) - 1);
            act3((ulong)Math.Pow(2, 61) - 1);
        }
    }
}
