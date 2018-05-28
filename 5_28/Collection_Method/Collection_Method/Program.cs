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
            int[] digits = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> enumerable = digits.Where(num => num % 2 == 0);
            enumerable.ToList().ForEach(i => Console.WriteLine(i));

            int n = Array.Find<int>(digits, num => num % 2 == 0);
            Console.WriteLine(n);

            Console.WriteLine(digits.Sum<int>(num=> { return (num % 2 == 0) ? 0 : num * num; }));
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
