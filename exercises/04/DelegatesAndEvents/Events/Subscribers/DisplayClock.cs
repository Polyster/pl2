using System;
using Events.EventArgs;

namespace Events.Subscribers
{
	// A subscriber: DisplayClock subscribes to the
	// clock's events. The job of DisplayClock is
	// to display the current time
	public class DisplayClock
	{
		// given a clock, subscribe to
		// its SecondChangeHandler event
		public void Subscribe(Clock theClock)
		{
			theClock.SecondChanged +=
			new Clock.SecondChangeHandler(TimeHasChanged);
		}

		// the method that implements the
		// delegated functionality
		public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
		{
			Console.WriteLine("Current Time: {0}:{1}:{2}",
												ti.Hour.ToString(), ti.Minute.ToString(), ti.Second.ToString());
		}
	}
}
