using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            foreach (string salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

        }
    }
}
