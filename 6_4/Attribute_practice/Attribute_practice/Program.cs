using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_practice
{
    public static class Trace
    {
        public static void WriteLine(string msg,
        [CallerFilePath] string file = "",
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string member = ""
        )
        {
            Console.WriteLine("{0} (Line : {1} {2} {3}", file, line, member, msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("호출!");
        }
    }
}
