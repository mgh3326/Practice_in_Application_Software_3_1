using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
            Console.ReadLine();
        }
        async static private void AsyncMethod(int count)
        {
            Console.WriteLine("1...");
            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("{0}/{1}", i, count);
                    await Task.Delay(1000);
                }
            });
            Console.WriteLine("2...");
        }
        static void Caller()
        {
            Console.WriteLine("3...");
            AsyncMethod(3);
            Console.WriteLine("4...");
        }
    }
}
// 비동기 프로그래밍이 왜 필요한가?
// Web 2.0 시대가 오면서 다른 웹사이트의 자원을 요청하고 가공하여 서비스를 제공
// 외부의 서비스 자원은 느리고 불안정한 자원으로 서비스의 대기 시간이 길어지는 원인이 됨
// 늘어난 서비스 대기 시간은 필연적으로 병목을 발생
// 따라서 서비스 제공이 불가능

// .NET framework 4.5
// 기존 비동기식 프로그래밍은 전문지식과 복잡한 로직을필요로했지만...
// .NET framework 4.5 에서 제공하는async와 await를 통하여 단순한 구조로 작성 가능

// Task와 Generic 형태인 Task<T>
// Thread Pool로 부터 Thread를 가져와 Async 작업을 할 수 있게 해준다
// Task와 관련된 Parallel class들은 Task Parallel Library(TPL)라 부른다
// 기본적으로 멀티 CPU 병렬 처리를 염두에 두고 만들어 짐

// 주의
// Dead-lock (교착 상태) 발생 할 수 있음
// Task에서 Invoke를 사용하고, 해당 Task를 기다리는 경우
// Task가 실행 중에, invoke 실행 시 main thread를 호출하고자 한다.그러나 main thread는 해당 Task가 완료 될때까지 다른 thread를 block함




// task는 main thread의 권한을 얻을 때까지 종료되지 않고,
// main thread는 task에게 권한은 주지않으면서 task가 실행이 완료되는 것을 대기

// C# 5.0에 추가 된 비동기 지원 기능
// async는 컴파일러에게 해당 method가 하나 이상의 await 가지고 있음을 알리는 역할
// async는 반환형식이 Task, Task<T>, void 중 하나여야 함
// await는 Task와 같은 awaitable class 객체의 작업이 완료되는 것을 기다림(다른 작업을 하고 있으면서)

// 결과분석
// 3...
// 1...❷
// 1/3❸
// 2/3❹
// 3/3❺
// 2...❻
// 4...은❷~❻ 모두 실행될 가능성이 있다.
