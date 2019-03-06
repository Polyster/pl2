using System;
using AdtLib.Adts;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//var s1 = new Stack<string>(5);
			//var s2 = new Stack<int>(5);

			bool parsedSize = int.TryParse(args[0], out int size);
			bool parsedSeedMode = Enum.TryParse(args[1], out SeedMode seedMode);

			if (parsedSize && parsedSeedMode)
			{
				var dynamicArray = new DynamicArray(size);
				switch (seedMode)
				{
					case SeedMode.Random:
					{
						var rand = new Random();
						for (var i = 0; i < size; i++)
						{
							dynamicArray[i] = rand.Next(10);
						}

						break;
					}
					case SeedMode.Sequential:
					{
						for (var i = 0; i < size; i++)
						{
							dynamicArray[i] = i;
						}

						break;
					}
					case SeedMode.Zeroes:
					{
						for (var i = 0; i < size; i++)
						{
							dynamicArray[i] = 0;
						}

						break;
					}
					default:
						throw new ArgumentOutOfRangeException();
				}

				Console.WriteLine($"This is how the array looks like: {dynamicArray}");
				dynamicArray.Sum(out int sum);
				Console.WriteLine($"This is the sum of array elements: {sum}");

				for (var i = 0; i < size; i++)
				{
					Console.WriteLine("------------------------------------------------------");
					Console.WriteLine($"Current state of array is {dynamicArray.State}");
					Console.WriteLine($"Current size of array is {dynamicArray.CurrentSize}");
					dynamicArray[i] = null;
				}
				Console.WriteLine("------------------------------------------------------");
				Console.WriteLine($"Current state of array is {dynamicArray.State}");
				Console.WriteLine($"Current size of array is {dynamicArray.CurrentSize}");
			}
		}
	}
}