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
			_data = vocabulary.ToDictionary(pair => pair.Key, pair => pair.Value);
		}

		public string Translate(string word)
		{
			return _data[word];
		}
	}
}