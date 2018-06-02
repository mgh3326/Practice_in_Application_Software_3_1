using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act = () => Console.WriteLine("Lamda one line"); //MethodInvoker와 비슷
            Action<int> act1 = (int a) => Console.WriteLine(a.ToString());
            Action<uint> act2 = (a) => Console.WriteLine(a.ToString());
            Action<ulong> act3 = a => Console.WriteLine(a.ToString());

            act();
            act1((int)Math.Pow(2, 19) - 1); // Mersenne prime
            act2((uint)Math.Pow(2, 31) - 1);
            act3((ulong)Math.Pow(2, 61) - 1);
        }
    }
}
// Lambda expression은 anonymous function
// 이름이 없는 함수
// C# 3.0에 추가 된 Anonymous(무명) 함수를 표현할 때 사용되는 식
// C# 2.0 보다 더 간결하게 표현
// Haskell, Lisp와 같은 함수형 프로그래밍 언어들은 Lambda 연산을 발전 시킨 것으로 볼 수 있다.
// C++은 C++11 부터, Java는 1.8 부터 지원
// Open Source Code에서 자주 사용된다
// Delegate 복습
// Delegate는 메소드를 변수처럼 사용할 수 있다.
// 변수와 같이 함수의 인자로 Delegate를 사용할 수 있다.

//람다식의 인자가 1개인 경우 괄호()가 없어도 됨(act3)
