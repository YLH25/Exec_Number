using System;
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
			for (int cock = 0; cock <= 100; cock++)
			{
				for (int hen = 0; hen <=100; hen++)
				{
					int chicken = 100-cock - hen;
					int price=15*cock+9*hen+chicken;
					if (price == 300)
					{
						Console.WriteLine($"公雞{cock}母雞{hen}小雞{chicken}");
					}
				}
			}
		}
	}
}
