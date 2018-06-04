using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_pracitce
{


    class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;

        }
        public static List<Student> GetStudents()// 왜 프로그램 안에 들어가야되는거지 신기방기
        {
            List<Student> students = new List<Student>
        {
            new Student { First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int> { 97, 72, 81, 60 } },
            new Student { First = "Claire", Last = "O'Donnell", ID = 112, Scores = new List<int> { 75, 84, 91, 39 } },
            new Student { First = "Sven", Last = "Mortensen", ID = 113, Scores = new List<int> { 99, 89, 91, 95 } },
            new Student { First = "Cesar", Last = "Garcia", ID = 114, Scores = new List<int> { 72, 81, 65, 84 } },
        new Student { First = "Debra", Last = "Garcia", ID = 115, Scores = new List<int> { 97, 89, 85, 82 } }
        };

            return students;

        }
        static void Main(string[] args)
        {
            List<Student> students = GetStudents();

            var booleanGroupQuery =
            from student in students group student by student.Scores.Average() >= 80; //pass or fail!

            foreach (var studentGroup in booleanGroupQuery)
            {
                Console.WriteLine(studentGroup.Key == true ? "High averages" : "Low averages"); foreach (var student in studentGroup)
                    Console.WriteLine("{0}, {1}: {2}", student.Last, student.First, student.Scores.Average());
            }



        }
    }
}
