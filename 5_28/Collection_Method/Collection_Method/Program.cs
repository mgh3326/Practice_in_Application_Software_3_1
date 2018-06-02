using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> enumerable = digits.Where(num => num % 2 == 0);
            enumerable.ToList().ForEach(i => Console.WriteLine(i));

            int n = Array.Find<int>(digits, num => num % 2 == 0);
            Console.WriteLine(n);

            Console.WriteLine(digits.Sum<int>(num => { return (num % 2 == 0) ? 0 : num * num; }));
            List<int> list = digits.ToList();
            list.Sort((x, y) => x < y ? 1 : -1);
            list.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("Other sort");
            list.Sort((x, y) =>
            {
                double temp_x = Math.Pow(-1, x) * 1.0 / x;
                double temp_y = Math.Pow(-1, y) * 1.0 / y;
                return temp_x < temp_y ? -1 : 1;

            });
            list.ForEach(i => Console.WriteLine(i));
        }
    }
}
// Collection class는 다수의 interface를 구현하여 편리한 기능들이 많다.

// 어떤 데이터가 들어갈지 모름
// Sort, Select 등의 함수를 사용자가 정의 해야함

// Ienumerable<T>.Where
// 조건을 만족하는 data를 찾아서 Ienumerable<T> 형태의 collection 개체에 모아 반환

// Array.Find
// 조건을 만족하는 data를 찾아 반환
// Predicate delegate 필요(T형 인자를 넣고 bool형 리턴)

// Sum
// 반환하는 data를 모두 더하여 반환아래 코드는 홀수만 제곱하여 합산 ∑_(𝑖=0)^9▒((1+(−1)^(𝑖+1))/2)  𝑖^2

// Sort
// return이 0보다 작은 경우: x < y
// return이 0인 경우: x == y
// return이 0보다 큰 경우 : x > y
