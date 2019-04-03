using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class Translator
	{
		private readonly Dictionary<string, string> _data;


		public Translator(IEnumerable<KeyValuePair<string, string>> vocabulary)
		{
			
		}

		public string Translate(string word)
		{
			throw new NotImplementedException();
		}
	}
}