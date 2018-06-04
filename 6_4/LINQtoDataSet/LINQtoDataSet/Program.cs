using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet1 dataset = new DataSet1();
            dataset.Tables["Person"].Rows.Add(new object[] { 1, "Kim", 30 });
            dataset.Tables["Person"].Rows.Add(new object[] { 2, "Kong", 35 });
            dataset.Tables["Person"].Rows.Add(new object[] { 3, "Park", 20 });
            dataset.Tables["Person"].Rows.Add(new object[] { 4, "Lee", 22 });

            DataTable persons = dataset.Tables["Person"];

            //IEnumerable<DataRow> query =
            //from person in persons.AsEnumerable() select person;

            //foreach (DataRow dr in query)
            //{
            //    Console.WriteLine("Number : {0}, Name : {1}, Age : {2}",
            //    dr["number"], dr["name"], dr["age"]);

            //}
            var query =
                from person in persons.AsEnumerable()
                where ((int)person["Age"]) >= 21//지정된 캐스트 
                orderby ((int)person["Age"]) descending
                select person;
            foreach (var dr in query)
            {
                Console.WriteLine("Number : {0}, Name : {1}, Age : {2}",
                dr["number"], dr["name"], dr["age"]);
            }


        }
    }
}
//1문제는 녹음 듣자
//1문제 그래픽스
//실기 두 문제
