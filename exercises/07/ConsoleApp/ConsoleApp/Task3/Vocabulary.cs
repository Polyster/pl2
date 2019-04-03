using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	static class Vocabulary
	{
		public static IEnumerable<KeyValuePair<string, string>> EnglishDictionary
		{
			get
			{
				yield return new KeyValuePair<string, string>("kočka", "cat");
				yield return new KeyValuePair<string, string>("pes", "dog");
				yield return new KeyValuePair<string, string>("červená", "red");
				yield return new KeyValuePair<string, string>("zelená", "green");
				yield return new KeyValuePair<string, string>("modrá", "blue");
				yield return new KeyValuePair<string, string>("černá", "black");
			}
		}
	}
}