using System;

namespace Delegates
{
	public class MediaStorage
	{
		public delegate int PlayMedia();

		public void ReportResult(PlayMedia playerDelegate)
		{
			Console.WriteLine(playerDelegate() == 0 ? "Media played successfully." : "Media did not play successfully.");
		}
	}
}