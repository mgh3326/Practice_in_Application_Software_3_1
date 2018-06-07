using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} in {2}", Name, Age, Address);
        }
    }

    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
                {
                new Person { Name = "Tom", Age = 63, Address = "Korea" },
                new Person { Name = "Winnie", Age = 40, Address = "Tibet" },
                new Person { Name = "Anders", Age = 47, Address = "Sudan" },
                new Person { Name = "Hans", Age = 25, Address = "Tibet" },
                new Person { Name = "Eureka", Age = 32, Address = "Sudan" },
                new Person { Name = "Hawk", Age = 15, Address = "Korea" },
                };

            List<MainLanguage> languages = new List<MainLanguage>
                {
                    new MainLanguage { Name = "Anders", Language = "Delphi" },
                    new MainLanguage { Name = "Anders", Language = "C#" },
                    new MainLanguage { Name = "Tom", Language = "Borland C++" },
                    new MainLanguage { Name = "Hans", Language = "Visual C++" },
                    new MainLanguage { Name = "Winnie", Language = "R" },
                };

            // 방법 1
            {
                var all = from person in people
                          select person;

                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 방법 2
            {
                IEnumerable<Person> all = from person in people
                                          select person;
                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // 방법 3
            {
                IEnumerable<Person> all = people.Select((elem) => elem);
                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
