using System.Diagnostics;

namespace Task3.Benchmarkers
{
	public static class DelegateBenchmarker
	{
		public delegate void Task();
		public static double Benchmark(int repeatCount, Task task)
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
	}
}
