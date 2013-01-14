using System;
using System.Collections;

#if USE_DBUS_SHARP
using DBus;
#else
using NDesk.DBus;
#endif

using org.freedesktop.DBus;

namespace Do.Addins.Spotify
{
	[Interface ("org.mpris.MediaPlayer2.Player")]
	public interface ISpotify
	{
		void Next();
		void Previous();
		void Pause();
		void PlayPause();
		void Stop();
		void Play();
		void Seek(int offset);
		//void SetPosition(string trackId, int position);
		void OpenUri(string uri);
	}

	class SpDBus
	{
#region Constants

		private const string OBJECT_PATH = "/org/mpris/MediaPlayer2";
		private const string BUS_NAME = "org.mpris.MediaPlayer2.spotify";

#endregion

#region Static Constructor, Methods, and Fields

		private static ISpotify spotify = null;

		static SpDBus()
		{
			org.freedesktop.DBus.IBus sessionBus = Bus.Session.GetObject<org.freedesktop.DBus.IBus>(
				"org.freedesktop.DBus", new ObjectPath("/org/freedesktop/DBus"));
			sessionBus.NameOwnerChanged += OnDBusNameOwnerChanged;
		}

		public bool Connected {
			get { return spotify != null; }
		}

		private static void OnDBusNameOwnerChanged(string serviceName, string oldOwner, string newOwner)
		{
			if (serviceName == BUS_NAME) {
				if (oldOwner == null && newOwner.Length > 0) {
					SetInstance();
				} else {
					spotify = null;
				}
			}
		}

		private static void SetInstance()
		{
			spotify = Bus.Session.GetObject<ISpotify>(BUS_NAME, new ObjectPath(OBJECT_PATH));
		}

#endregion

#region Instance Constructor, Methods, and Properties

		public SpDBus() {
			try {
				BusG.Init();
				if (spotify == null) {
					FindInstance();
				}
			} catch (Exception) {
				Console.Error.WriteLine("Could not locate Spotify on D-Bus. Perhaps it's not running?");
			}
		}

		private void FindInstance()
		{
			if (Bus.Session.NameHasOwner(BUS_NAME)) {
				SetInstance();
			}
		}

		private void EnsureSpotifyInstance()
		{
			if (!Connected) {
				Bus.Session.StartServiceByName(BUS_NAME);
				SetInstance();
			}
		}

		public void Next()
		{
			EnsureSpotifyInstance();
			spotify.Next();
		}
		
		public void Previous()
		{
			EnsureSpotifyInstance();
			spotify.Previous();
		}
		
		public void Pause()
		{
			EnsureSpotifyInstance();
			spotify.Pause();
		}
		
		public void PlayPause()
		{
			EnsureSpotifyInstance();
			spotify.PlayPause();
		}
		
		public void Stop()
		{
			EnsureSpotifyInstance();
			spotify.Stop();
		}

		public void Play()
		{
			EnsureSpotifyInstance();
			spotify.Play();
		}
		
		public void Seek(int offset)
		{
			EnsureSpotifyInstance();
			spotify.Seek(offset);
		}
		
		/*public void SetPosition(string trackId, int position)
		{
			EnsureSpotifyInstance();
			spotify.SetPosition(trackId, position);
		}*/
		
		public void OpenUri(string uri)
		{
			EnsureSpotifyInstance();
			spotify.OpenUri(uri);
		}

#endregion
	}
}
