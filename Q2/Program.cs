using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("第一個數");
			string input=Console.ReadLine();
			int firstNum=Convert.ToInt32(input);
			Console.Write("第二個數");
			string input2 = Console.ReadLine();
			int secondNum = Convert.ToInt32(input2);

			
			for (int i = firstNum+1; i<secondNum; i++)
			{
				bool isPrimeNum = true;
				for (int k = 2; k < i; k++)
				{
					if (i % k == 0)
					{
						isPrimeNum = false;
						break;
					}
				}
				if (isPrimeNum)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
