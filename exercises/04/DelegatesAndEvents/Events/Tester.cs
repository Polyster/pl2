using Events.Subscribers;

namespace Events
{
	public class Tester
	{
		public void Run()
		{
			// create a new clock
			var theClock = new Clock();

			// create the display and tell it to
			// subscribe to the clock just created
			var dc = new DisplayClock();
			dc.Subscribe(theClock);

			// create a Log object and tell it
			// to subscribe to the clock
			var lct = new LogCurrentTime();
			lct.Subscribe(theClock);


			// TODO 2: Uncomment lines below and run the code
			//Console.WriteLine("Calling the method directly!");
			//var dt = DateTime.Now.AddHours(2);
			//theClock.SecondChanged(theClock, new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second));


			// Get the clock started
			theClock.Run();
		}
	}
}