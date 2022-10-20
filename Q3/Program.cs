using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			for (int i = 1; i <10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					string string1 = $"{i}{i}{j}{j}";
					int num= Convert.ToInt32(string1);
					double value = Math.Sqrt(num);
					bool canBeInt = int.TryParse(value.ToString(), out int N);
					if (canBeInt)
					{
						Console.WriteLine(num);
					}
				}
			}

			
		}
	}
}
