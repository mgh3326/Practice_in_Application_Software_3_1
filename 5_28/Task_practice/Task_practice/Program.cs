using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = () =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("print Async");
            };
            Task t1 = new Task(action);

            t1.Start();//비동기 호출
            Console.WriteLine("print Sync");
            t1.Wait();

            Console.WriteLine("Main end");
        }
    }
}
