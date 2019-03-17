using System;
using System.Diagnostics;

namespace Task3.Benchmarkers
{
	public static class ActionBenchmarker
	{
		public static double Benchmark(int repeatCount, Action task)
		{
			var watch = new Stopwatch();
			var totalTime = 0.0;

			for (int i = 0; i < repeatCount; i++)
			{
				watch.Start();
				task();
				watch.Stop();

				totalTime += watch.ElapsedMilliseconds;
				watch.Reset();
			}
			return totalTime / repeatCount;
		}
		public static double Benchmark(int repeatCount, Action<int> task)
		{
			var watch = new Stopwatch();
			var totalTime = 0.0;

			for (int i = 0; i < repeatCount; i++)
			{
				watch.Start();
				task(20);
				watch.Stop();

				totalTime += watch.ElapsedMilliseconds;
				watch.Reset();
			}
			return totalTime / repeatCount;
		}
	}
}