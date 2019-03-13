using Delegates.Players;

namespace Delegates
{
	public class Tester
	{
		public void Run()
		{
			var myMediaStorage = new MediaStorage();

			// instantiate the two media players
			var myAudioPlayer = new AudioPlayer();
			var myVideoPlayer = new VideoPlayer();

			// instantiate the delegates
			var audioPlayerDelegate = new
			MediaStorage.PlayMedia(myAudioPlayer.PlayAudioFile);
			var videoPlayerDelegate = new
			MediaStorage.PlayMedia(myVideoPlayer.PlayVideoFile);

			// call the delegates
			myMediaStorage.ReportResult(audioPlayerDelegate);
			myMediaStorage.ReportResult(videoPlayerDelegate);
		}
	}
}
