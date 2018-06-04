using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_practice2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class HistoryAttribute : Attribute
    {
        private string programmer;
        public double version;
        public string changes;


        public HistoryAttribute(string programmer)
        {
            this.programmer = programmer;
            this.version = 1.0;
            this.changes = "First Release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Kim", version = 0.1, changes = "2017-04-01 Create Class")]
    [History("Lee", version = 0.2, changes = "2017-04-02 Added Func() Method")]
    class TargetClass
    {
        public void Func()
        {
            Console.WriteLine("Func() Called");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(TargetClass);
            Attribute[] atts = Attribute.GetCustomAttributes(type);
            Console.WriteLine("Target Class Change History");

            foreach (Attribute att in atts)
            {
                HistoryAttribute h = att as HistoryAttribute;
                if (h != null)
                {
                    Console.WriteLine("Ver : {0}, programmer : {1}, Changes : {2}",
h.version, h.GetProgrammer(), h.changes);
                }

            }


        }
    }
}
