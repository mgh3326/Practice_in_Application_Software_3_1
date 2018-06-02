using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> act = delegate (int i)
            {
                Console.WriteLine("Work 1 ... using {0}", i);
            };
            act += (int i) =>
              {
                  Console.WriteLine("Work 2 ... using {0}", i);
              };
            act += i => Console.WriteLine("End Log using {0}", i);
            act(11);
        }
    }
}
// .Net에서 제공하는 Generic 형식의 delegate

// Action, Action<T>, Action<T1, T2>, ..., Action<T1, ..., T16>
// Action은 입력인자와 반환값이 없는 method에 사용되는 delegate
// T 형태의 parameter를 받고, 반환값이 없는 method에 사용되는 delegate

// Func<TResult>, Func<T, TResult>, ..., Func<T1, ..., T16, TResult>
// T형태의 parameter를 받고, 반환 타입이 TResult에 사용되는 delegate

// Predicate<T>
// T 형태의 parameter를 받고, 반환 타입이 bool에 사용되는 delegate

// Delegate method를 추가하여 연쇄적으로 명시한 method를 실행할 수 있게 함

// Event Handler의 기본 원리
// EventHandler는 sender와 event를 인자로 하는 delegate

// Event Handler의 기본 원리
// Form1.Designer.cs에 들어가면 Click이라는 EventHandler에 button1_Click라는 method를 추가하는 것을 볼 수 있다.

// btnStart.Click에 사용자 정의 함수를 추가하고 싶을 때
// Click이라는 EventHandler에 사용자가 정의한 함수를 delegate chain을 이용하여 연결
