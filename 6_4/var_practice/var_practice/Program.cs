using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Amount = 108, Message = "Hello" };
            var type = obj.GetType();

            Console.WriteLine("obj : {0}", type);
            foreach (var p in type.GetProperties())
            {
                Console.WriteLine("obj's member : {0}", p);
            }
        }
    }
}
