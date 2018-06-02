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
            //Create a list of strings.
            List<string> salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            //Iterate through the list.
            foreach (string salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

        }
    }
}
//  하나의 단위로 참조될 수 있는 정렬된 항목 집합
//  배열은 고정된 개수의 강력한 형식 개체를 만들고 작업하는 데 가장 유용
//  Collection은 개체 그룹에 대해 작업하는 보다 유연한 방법을 제공한다.
//  배열과 달리, 응용 프로그램의 요구가 변경됨에 따라 작업하는 개체 그룹이 동적으로 확장되거나 축소될 수 있다. 
//  일부 Collection의 경우 키를 사용하여 개체를 신속하게 검색할 수 있도록 컬렉션에 추가하는 모든 개체에 키를 할당할 수 있다.

//  .NET Framework는 특정 목적에 맞게 설계된 많은 Collection을 제공해준다.
//  System.Collections
//  System.Collections.Generic
//  System.Collections.Concurrent
//  스레드로부터 안전한 Collection
