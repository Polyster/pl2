using System;
using System.Threading;
using Task3.Benchmarkers;
using Task3.Factories;
using Task3.Operations;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			double avg = 0;
			// TODO: Observe the possibilities of calls
			// Using lambda
			avg = DelegateBenchmarker.Benchmark(5, () => Thread.Sleep(20));
			Console.WriteLine($"Average time was: {avg}");

			// Using method call
			avg = DelegateBenchmarker.Benchmark(5, () => ExamplesFactory.GetTask());
			Console.WriteLine($"Average time was: {avg}");

			// Using method group
			avg = DelegateBenchmarker.Benchmark(5, ExamplesFactory.GetTask);
			Console.WriteLine($"Average time was: {avg}");

			#region Actions

			// TODO: Implement Benchmark method
			// Using lambda
			//avg = ActionBenchmarker.Benchmark(5, () => Thread.Sleep(20));
			//Console.WriteLine($"Average time was: {avg}");

			//// Using static method
			//avg = ActionBenchmarker.Benchmark(5, () => ExamplesFactory.GetTask());
			//Console.WriteLine($"Average time was: {avg}");

			//// Using lambda
			//avg = ActionBenchmarker.Benchmark(5, i => Thread.Sleep(i));
			//Console.WriteLine($"Average time was: {avg}");

			//// Using static method
			//avg = ActionBenchmarker.Benchmark(5, i => ExamplesFactory.GetTask(i));
			//Console.WriteLine($"Average time was: {avg}");

			#endregion

			#region Func

			// TODO: Implement Operate method
			var operation = new BinaryOperation<int>(5, 5);
			//operation.Operate((a, b) => a + b);
			//operation.Operate((a, b) => a - b);
			// TODO: Add multiplication and division calls

			#endregion

			#region Predicate

			var customers = ExamplesFactory.GetCollection();
			// TODO: Define a predicate where first name is equal to Joydip
			Predicate<Customer> predicate = null;
			var customer = customers.Find(predicate);
			Console.WriteLine($"Found user: {customer.FirstName} {customer.LastName}");

			#endregion
		}
	}
}