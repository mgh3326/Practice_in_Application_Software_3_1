using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> act = delegate (int i)
            {
                Console.WriteLine("Work 1 ... using {0}", i);
            };
                act+=(int i) =>
                {
                Console.WriteLine("Work 2 ... using {0}",i);
            };
            act += i => Console.WriteLine("End Log using {0}", i);
            act(11);
        }
    }
}
