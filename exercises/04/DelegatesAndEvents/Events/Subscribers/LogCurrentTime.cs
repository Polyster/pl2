using System;
using Events.EventArgs;

namespace Events.Subscribers
{
	// a second subscriber whose job is to write to a file
	public class LogCurrentTime
	{
		public void Subscribe(Clock theClock)
		{
			// TODO 1: Change this to assignment and run the code
			theClock.SecondChanged +=
			new Clock.SecondChangeHandler(WriteLogEntry);
		}

		// this method should write to a file
		// we write to the console to see the effect
		// this object keeps no state
		public void WriteLogEntry(object theClock, TimeInfoEventArgs ti)
		{
			Console.WriteLine("Logging to file: {0}:{1}:{2}",
												ti.Hour.ToString(), ti.Minute.ToString(), ti.Second.ToString());
		}
	}
}
