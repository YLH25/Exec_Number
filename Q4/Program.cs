﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 100; i++)
			{
				for (int k = 0; k <= 100; k++) 
				{
					for (int m = 0; m <= 100; m++) 
					{
						int sum = 5 * i + 3 * k + m;
						int sum1 = i + k + 3*m;
						if (sum==100) 
						{
							if (sum1 == 100)
							{
								Console.WriteLine($"公雞{i}母雞{k}小雞{m}");
							}
						}

					}
				}
			}
		}
	}
}
