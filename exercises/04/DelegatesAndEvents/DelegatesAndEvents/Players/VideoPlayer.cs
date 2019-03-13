using System;

namespace Delegates.Players
{
	public class VideoPlayer
	{
		private int _videoPlayerStatus;

		public int PlayVideoFile()
		{
			Console.WriteLine("Simulating a failed video file here.");
			_videoPlayerStatus = -1;
			return _videoPlayerStatus;
		}
	}
}
