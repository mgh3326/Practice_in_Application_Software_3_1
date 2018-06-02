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
//  Generic
//  C# 2.0에서 추가 된 타입 인수를 사용하여 일반화된 클래스나 메서드를 정의하는 기법
//  코드의 재사용성을 높이고 타입에 대한 안정성을 높일 수 있는 장점이 있지만 코드의 크기가 커지고 가독성이 떨어질 수 있다
//  Generic 이 아닌 ArrayList 를 예로 들면 object 형으로 값이 들어가기 때문에 boxing/unboxing 에 성능을 많이 할애하게 됨

//  Boxing
//  값 형식을 object 형식 또는 이 값 형식에서 구현된 임의의 인터페이스 형식으로 변환하는 프로세스

//  Unboxing
//  개체에서 값 형식이 추출된다. 이 때에는 어떤 타입인지 명시적으로 지정해 주어야 한다.

//  Generic에서의 Boxing
//  Class 객체를 만들 때 명시한 자료형을 넣을 수 있다.
//  System.Collections.Generic.List<T> 같은 제네릭 컬렉션을 사용하면 값 형식의 boxing을 방지할 수 있다.
//  다형성을 적용하여 명시한 자료형의 하위 클래스도 업캐스팅 하여 넣을 수 있지만 값 -> 참조형으로 바꿀 때에는 boxing 이 일어나게 된다
// 참조형: 메모리 크기가 가변 형식 (example: object)

//  Boxing/Unboxing
//  값 형식을 object로 변환할 때에는 heap에 메모리를 할당하는 작업을 동반한다. 
//  정도는 약간 덜하지만 unboxing에 필요한 캐스트에도 상당한 계산 과정이 필요하다.
//  System.Collections.ArrayList 같은 제네릭이 아닌 컬렉션 클래스의 예와 같이  많은 수의 boxing이 필요한 경우에는 값 형식을 사용하지 않는 것이 좋다.
//  값 형식을 boxing할 때는 완전히 새로운 개체가 만들어져야 하며, 이러한 작업은 간단한 참조 할당보다 최대 20배의 시간이 걸린다.

//  간단한 Generic Class 생성 예시

//  Generic의 가장 일반적인 용도는 Collection 클래스를 만드는 것이다 (MSDN  권고)
//  C++ 의 Templates 과는 차이점이 있다 (MSDN Link)

//  List<T> 
//  index 로 접근할 수 있는 강력한 형식의 개체 목록
//  검색, 정렬 및 조작에 사용할 수 있는 메서드를 제공한다
//  데이터를 중복하여 포함할 수 있다

//  Dictionary<Tkey, Tvalue> 
//  2장 마지막에 잠깐 나온 Hashtable 의 Generic Version
//  Hashtable 은 object 형식의 key 와 value 를 받아들여 boxing/unboxing 관련 성능 저하 문제를 일으킬 수 있다
//  Tkey 에 대응되는 Tvalue 를 KeyValuePair<Tkey, Tvalue> 형태로 저장한다
