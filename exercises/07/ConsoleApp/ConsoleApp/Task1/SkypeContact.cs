using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class SkypeContact : IContact, IComparable
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }


		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	}
}