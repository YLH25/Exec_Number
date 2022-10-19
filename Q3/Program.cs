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
			//num="xxyy"    value=num.math.sqrt()   bool canbeint=int.tryparse(value,out int N)
			string string1;


			for (int i = 1; i <10; i++)
			{
				for (int j = 1; j < 10; j++)
				{
					string1 = $"{i}{i}{j}{j}";
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
