using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Task1

			var book = new ContactBook<IContact>(5);
			book.AddContact(new SkypeContact
			{
				FirstName = "Harry",
				LastName = "Potter"
			});
			book.AddContact(new SkypeContact
			{
				FirstName = "Ron",
				LastName = "Weasley"
			});

			// Enumerable
			foreach (var contact in book)
			{
				Console.WriteLine(contact);
			}

			// Enumerator
			var en = book.GetEnumerator();
			while (en.MoveNext())
			{
				Console.WriteLine(en.Current);
			}

			en.Dispose(); // TODO Try delete this line

			using (var enumerator = book.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Console.WriteLine(enumerator.Current);
				}
			}

			#endregion

			#region Task2

			var a = new[] {4, 2, 3, 8, 6, 7, 5, 9, 1};
			PrintArray(a);

			Console.WriteLine();
			Array.Sort(a, new ParityAndSizeComparer());
			PrintArray(a);

			Console.WriteLine();


			a = new[] {3, 1, 4, 11, 21, 54, 14};
			PrintArray(a);

			Console.WriteLine();
			Array.Sort(a, new DecadicComparer());
			PrintArray(a);

			Console.WriteLine();

			#endregion

			#region Task3

			var translator = new Translator(Vocabulary.EnglishDictionary);
			Console.WriteLine(translator.Translate("kočka"));
			Console.WriteLine(translator.Translate("zelená"));

			#endregion
		}

		private static void PrintArray(int[] array)
		{
			foreach (int i in array)
			{
				Console.Write($"{i}, ");
			}
		}
	}
}