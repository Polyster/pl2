using System;

namespace HelloWorld
{
	public class Program
	{
		private const string Exit = nameof(Exit);

		public static void Main(string[] args)
		{
			var name = "";
			while (name != Exit && name != Exit.ToLower())
			{
				Console.Write("Enter your name: ");
				name = Console.ReadLine();
				string greeting = HelloWorldLibrary.Greeter.Greet(name);
				Console.WriteLine(greeting);
			}

			Console.WriteLine("Bye bitch");
			Console.ReadKey();
		}
	}
}