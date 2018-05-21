using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> testDictionary = new Dictionary<string, double>();
            testDictionary.Add("pi", 3.141592);
            testDictionary.Add("e", 2.71828);
            testDictionary.Add("kong", 2);

            foreach (KeyValuePair<string, double> kvp in testDictionary)
            {
                Console.WriteLine("Key : " + kvp.Key + ", Value : " + kvp.Value);
            }
            Console.WriteLine("Kong : " + testDictionary["kong"]);
        }
    }
}
