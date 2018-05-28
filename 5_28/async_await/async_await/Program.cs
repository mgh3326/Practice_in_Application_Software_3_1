using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
            Console.ReadLine();
        }
        async static private void AsyncMethod(int count)
        {
            Console.WriteLine("1...");
            await Task.Run(async () => {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("{0}/{1}", i, count);
                    await Task.Delay(1000);
                }
            });
            Console.WriteLine("2...");
        }
        static void Caller()
        {
            Console.WriteLine("3...");
            AsyncMethod(3);
            Console.WriteLine("4...");
        }
    }
}
