using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_05_data_type_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText1 = " Hello ";
            string strText2 = " ASP.NET ";
            string strText3 = " World ";

            string strAllText = strText1 + strText2 + strText3;

            Console.WriteLine("총 문자열 길이     :{0}", strAllText.Length);
            Console.WriteLine("전체 문자열        :{0}", strAllText);
            Console.WriteLine("공백 제거          :{0}", strAllText.Trim());
            Console.WriteLine("ASP 글자 삭제      :{0}", strAllText.Remove(8, 3));
            Console.WriteLine(".NET을 한글로 교체  :{0}", strAllText.Replace(".NET", "닷넷"));
            Console.WriteLine(".NET 추출          :{0}", strAllText.Substring(11, 4));
            Console.WriteLine("대문자로 변환       :{0}", strAllText.ToUpper());
            Console.WriteLine("소문자로 변환       :{0}", strAllText.ToLower());
        }
    }
}
