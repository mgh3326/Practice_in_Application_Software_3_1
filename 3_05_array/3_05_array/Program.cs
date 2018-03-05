using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _3_05_array
{
    public class Student
    {
        public int m_nNumber;
        public int m_nScore;

        public Student(int nNumber, int nScore)
        {
            m_nNumber = nNumber;
            m_nScore = nScore;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int nTotal = 0;
            double dMean = 0;
            Array arrRecord = Array.CreateInstance(typeof(Student), 5);

            Console.WriteLine("5명의 학생의 성적을 입력합니다.");
            for (int i = 0; i < 5; ++i)
            {
                string strScore = Console.ReadLine();
                arrRecord.SetValue(new Student(i + 1, Convert.ToInt32(strScore)), i);
                nTotal += ((Student)arrRecord.GetValue(i)).m_nScore;
            }
            for (int i = 0; i < arrRecord.Length; ++i)
            {
                int nScore = ((Student)arrRecord.GetValue(i)).m_nScore;
                string strGrade = "F";

                if (nScore >= 90)
                    strGrade = "A";
                else if (nScore >= 80)
                    strGrade = "B";
                else if (nScore >= 70)
                    strGrade = "C";
                else if (nScore >= 60)
                    strGrade = "D";
                Console.WriteLine("{0} 번 학생 성적 : {1}, 등급 : {2}", i + 1, nScore, strGrade);
            }
            dMean = (double)nTotal / arrRecord.Length;
            Console.WriteLine("총점 : {0}, 평균 : {1}", nTotal, dMean);
        }
    }
}
