using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            // 4개의 요소를 컬렉션에 추가
            ar.Add("Hello");
            ar.Add(6);
            ar.Add("World");
            ar.Add(true);

            // 숫자 6을 포함하고 있는지 판단
            Console.WriteLine("Contains(6): " + ar.Contains(6));

            // "World" 문자열을 컬렉션에서 삭제
            ar.Remove("World");

            // 2번째 요소의 값을 false로 변경
            ar[2] = false;
            Console.WriteLine();

            // 컬렉션의 요소를 모두 출력
            foreach (object obj in ar)
            {
                Console.WriteLine(obj);
            }

        }
        //모두 같은 형이여야한다는 특징이 있다.
        //static void Main(string[] args)
        //{
        //    ArrayList ar = new ArrayList();

        //    ar.Add("Hello");
        //    ar.Add("World");
        //    ar.Add("My");
        //    ar.Add("Sample");
        //    ar.Sort();

        //    foreach (string txt in ar)
        //    {
        //        Console.WriteLine(txt);
        //    }
        //}
    }

}
