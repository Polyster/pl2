using System;

namespace Delegates.Players
{
	public class AudioPlayer
	{
		private int _audioPlayerStatus;

		public int PlayAudioFile()
		{
			Console.WriteLine("Simulating playing an audio file here.");
			_audioPlayerStatus = 0;
			return _audioPlayerStatus;
		}
	}
}
