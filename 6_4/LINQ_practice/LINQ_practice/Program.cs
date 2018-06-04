using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    class Employee
    {
        public string name;
        public int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> eList = new List<Employee>();

            eList.Add(new Employee("kim", 25));
            eList.Add(new Employee("lee", 30));
            eList.Add(new Employee("jung", 21));
            eList.Add(new Employee("nam", 24));
            eList.Add(new Employee("park", 27));
            eList.Add(new Employee("Lim", 43));
            eList.Add(new Employee("Woo", 37));
            eList.Add(new Employee("kim", 44));
            eList.Add(new Employee("conan", 31));
            //List<Employee> youngEmplyeeList = new List<Employee>();
            //foreach (Employee e in eList)
            //{
            //    if (e.age <= 30)
            //        youngEmplyeeList.Add(e);
            //}

            var youngEmplyeeList = from e in eList
                                   where e.age <= 30
                                   select e;
            foreach (Employee e in youngEmplyeeList)
            {
                Console.WriteLine("Name : " + e.name + ", Age : " + e.age);

            }
                

        }
    }
}
