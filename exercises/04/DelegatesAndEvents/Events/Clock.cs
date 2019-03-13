using System.Threading;
using Events.EventArgs;

namespace Events
{
	// The publisher: the class that other classes
	// will observe. This class publishes one delegate:
	// SecondChangeHandler.
	public class Clock
	{
		private int _hour;
		private int _minute;
		private int _second;

		// the delegate the subscribers must implement
		public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);

		// an instance of the delegate
		// TODO 3: Add event keyword after public and fix the errors
		public SecondChangeHandler SecondChanged;

		// set the clock running
		// it will raise an event for each new second
		public void Run()
		{
			while (true)
			{
				// sleep 100 milliseconds
				Thread.Sleep(100);
				// get the current time
				var dt = System.DateTime.Now;
				// if the second has changed
				// notify the subscribers
				if (dt.Second != _second)
				{
					// create the TimeInfoEventArgs object
					// to pass to the subscriber
					var timeInformation =
					new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

					// if anyone has subscribed, notify them
					SecondChanged?.Invoke(this, timeInformation);
				}

				// update the state
				this._second = dt.Second;
				this._minute = dt.Minute;
				this._hour = dt.Hour;
			}
		}
	}
}