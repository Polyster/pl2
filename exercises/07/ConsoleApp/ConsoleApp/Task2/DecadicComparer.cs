using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class DecadicComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			if (x % 10 < y % 10)
			{
				return 1;
			}

			if (x % 10 > y % 10)
			{
				return -1;
			}

			return 0;
		}
	}
}