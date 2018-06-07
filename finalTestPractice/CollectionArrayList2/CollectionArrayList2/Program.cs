using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionArrayList2
{
    public class Person : IComparable
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int CompareTo(object obj) // 나이순으로 정렬한다.
        {
            Person target = (Person)obj;
            if (this.Age > target.Age) return 1;
            else if (this.Age == target.Age) return 0;
            return -1;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add(new Person(32, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27, "Paul"));

            ar.Sort();

            foreach (Person person in ar)
            {
                Console.WriteLine(person);
            }
        }

        //static void Main(string[] args)
        //{
        //    Hashtable ht = new Hashtable();

        //    // 4개의 요소를 컬렉션에 추가
        //    ht.Add("key1", "add");
        //    ht.Add("key2", "remove");
        //    ht.Add("key3", "update");
        //    ht.Add("key4", "search");

        //    // "key4" 키 값에 해당하는 값을 출력
        //    Console.WriteLine(ht["key4"]);

        //    // "key3" 키 값에 해당하는 요소를 컬렉션에서 삭제
        //    ht.Remove("key3");

        //    // "key2" 키 값에 해당하는 값을 "delete"로 변경
        //    ht["key2"] = "delete";
        //    Console.WriteLine();

        //    // 컬렉션의 모든 키 값을 열람하고, 그 키에 대응되는 값을 출력
        //    foreach (object key in ht.Keys)
        //    {
        //        Console.WriteLine("{0} ==> {1}", key, ht[key]);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    SortedList sl = new SortedList();

        //    sl.Add(32, "Cooper");
        //    sl.Add(56, "Anderson");
        //    sl.Add(17, "Sammy");
        //    sl.Add(27, "Paul");

        //    foreach (int key in sl.GetKeyList())
        //    {
        //        Console.WriteLine(string.Format("{0} {1}", key, sl[key]));
        //    }
        //}
    }


}
