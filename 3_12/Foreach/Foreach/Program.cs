using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Foreach
{
	class Program
	{
		static void Main(string[] args)
		{

			for_practice();//for
			foreach_practice();//foreach



			//Iteration Statements-실습
			ArrayList myAl = new ArrayList();
			myAl.Add("Hello");
			myAl.Add("World");
			myAl.Add("!");
			Console.Write("Values:");
			PrintValues(myAl);
		}

		public static void for_practice()
		{
			int[,] values = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };//for
			for (int i = 0; i < 2; ++i)
				for (int j = 0; j < 4; ++j)
					Console.Write("{0} ", values[i, j]);
			Console.WriteLine();
		}
		public static void foreach_practice()
		{
			//foreach
			int[,] values = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
			foreach (int value in values)
				Console.Write("{0} ", value);
			Console.WriteLine();
		}

		public static void PrintValues(ArrayList myList)
		{
			foreach (string text in myList)
			{
				Console.Write("\t{0}", text);
			}
			Console.WriteLine();
		}
	}
}
