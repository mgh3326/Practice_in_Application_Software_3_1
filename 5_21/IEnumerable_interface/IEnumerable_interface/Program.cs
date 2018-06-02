using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_interface
{
    public class Person
    {
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public string firstName;
        public string lastName;
    }
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;

        int position = -1;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John","Smith"),
                new Person("Jim","Johnson"),
                new Person("Sue","Rabon"),
            };

            People peoplelist = new People(peopleArray);
            foreach (Person p in peoplelist)
                Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}
//  사용자 정의 Collection 에서 열거 기능을 지원하게 함
//  GetEnumerator() 메서드를 구현하면 된다.

//  Enumerator 는 IEnumerator 를 구현하여 만들 수 있다.
//  내부의 데이터를 순방향으로 접근할 수 있는 기능을 가짐

//  사용자 정의 Collection 클래스에 IEnumerable을 구현하게 되면 클래스의 내부 데이터를 foreach문으로 조회할 수 있다


//  사용 예시
//  구현해야 할 항목
//  열거할 데이터 class (primitive type 이거나 이미 정의 된 경우에는 필요 없음)
//  IEnumerable 을 구현한 데이터를 모아놓는 class
//  Enumerator 를 반환하는 GetEnumerator() 구현
//  IEnumerator 를 구현한 Enumerator 를 리턴하는 class
//  index 역할을 하는 정수형 position 변수를 두어 index 를 관리
//  position을 1 높이고, 다음자료의 position으로 이동하는데 성공했는지 bool 로 알려주는 MoveNext () 메서드를 구현
//  index 를 초기화 하는 Reset() 메서드 구현
//  현재 position 을 index 로 하는 데이터를 반환하는 Current Property 구현

