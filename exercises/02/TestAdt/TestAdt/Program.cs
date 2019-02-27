using System;
using AdtLib.Adts;
using AdtLib.Interfaces;

namespace TestAdt
{
	class Program
	{
		private const int Min = 1;
		private const int Max = 10;

		static void Main(string[] args)
		{
			var stack = new Stack(Max);

			Console.WriteLine($"Pushing into stack from {Min} to {Max}");
			for (int i = Min; i <= Max; i++)
			{
				stack.Push(i);
			}

			Console.WriteLine("Popping from stack");
			for (int i = Min; i <= Max; i++)
			{
				Console.WriteLine($"Stack popped {stack.Pop()}");
			}


			var queue = new Queue(Max);
			Console.WriteLine($"Pushing into queue from {Min} to {Max}");
			for (int i = Min; i <= Max; i++)
			{
				queue.Add(i);
			}

			Console.WriteLine("Popping from queue");
			for (int i = Min; i <= Max; i++)
			{
				Console.WriteLine($"Queue got {queue.Get()}");
			}
		}
	}
}