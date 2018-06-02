using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            //Displays the properties and values of the ArrayList.
            Console.WriteLine("Count:   {0}", myAL.Count);
            Console.WriteLine("Capacity:   {0}", myAL.Capacity);
            Console.WriteLine("Values:");
            PrintValues(myAL);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("    {0}", obj);
            Console.WriteLine();
        }
    }
}
//  Polymorphism
//  ArrayList 는 IEnumerable 을 구현하기 때문에 IEnumerable 변수에 넣을 수 있다


//  하지만 IEnumerable 형으로 받은 자료에서는 ArrayList 의 기능을 모두 사용할 수 없고, IEnumerable 에서 사용할 수 있는 기능만 사용할 수 있다

//  Polymorhism
//  명시적으로 형 변환을 할 시에는 다시 기능들을 모두 이용할 수 있다.


