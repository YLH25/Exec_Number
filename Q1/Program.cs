using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個數");
			string input=Console.ReadLine();
			int num = Convert.ToInt32(input);
			bool isPrimeNum=true;
			for (int i = 2; i < num; i++)
			{
				if (num % i == 0)
				{
					isPrimeNum = false;
					break;
				}
			}
			if (isPrimeNum)
			{
				Console.WriteLine("質數");
			}
			else 
			{
				Console.WriteLine("非質數");
			}
		}
	}
}
