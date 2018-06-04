using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflection_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            //Type type= typeof(int);

            PrintInterfaces(type);
            PrintField(type);
            PrintMethod(type);
            PrintProperties(type);
        }
        public static void PrintInterfaces(Type type)
        {
            Console.WriteLine("------------------------------Interface------------------------------");
            Type[] interfaces = type.GetInterfaces();

            foreach (Type i in interfaces)
            {
                Console.WriteLine("Name : {0}", i.Name);
            }
            Console.WriteLine();
        }
        public static void PrintField(Type type)
        {
            Console.WriteLine("------------------------------Fields------------------------------");
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo fi in fields)
            {
                String accesslevel = "public";
                if (fi.IsPublic) accesslevel = "public";
                else if (fi.IsPrivate) accesslevel = "private";
                Console.WriteLine("Access Level : {0}, Type : {1}, Name : {2}", accesslevel, fi.FieldType.Name, fi.Name);
            }
            Console.WriteLine();
        }
        static void PrintMethod(Type type)
        {
            Console.WriteLine("------------------------------Method------------------------------");
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo mi in methods)
            {
                Console.Write("Return Type : {0}, Name : {1}, Input Parameter", mi.ReturnType.Name, mi.Name);

                ParameterInfo[] args = mi.GetParameters();
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintProperties(Type type)
        {
            Console.WriteLine("------------------------------Property------------------------------");

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                Console.WriteLine("Type : {0}, Name : {1}", pi.PropertyType.Name, pi.Name);
            }
            Console.WriteLine();

        }
    }
}
