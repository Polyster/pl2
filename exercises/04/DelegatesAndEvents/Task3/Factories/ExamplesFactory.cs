using System;
using System.Collections.Generic;
using System.Threading;

namespace Task3.Factories
{
	public static class ExamplesFactory
	{
		private static readonly Random Random = new Random();

		public static void GetTask()
		{
			Thread.Sleep(Random.Next(10));
		}

		public static void GetTask(int max)
		{
			Thread.Sleep(Random.Next(max));
		}

		public static List<Customer> GetCollection()
		{
			return new List<Customer>
			{
				new Customer
				{
					FirstName = "Joydip",
					LastName = "Kanjilal",
					State = "Telengana",
					City = "Hyderabad",
					Country = "India"
				},
				new Customer
				{
					FirstName = "Steve",
					LastName = "Jones",
					State = "OA",
					City = "New York",
					Country = "US"
				}
			};
		}
	}
}