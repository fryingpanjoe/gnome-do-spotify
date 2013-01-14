using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_PlayPause : Item, IRunnableItem
	{
		public override string Name { get { return "PlayPause"; } }
		public override string Description { get { return "Play or Pause track."; } }
		public override string Icon { get { return "gtk-media-play"; } }

		public void Run()
		{
			SpDBus sp = new SpDBus();
			sp.PlayPause();
		}
	}
}
