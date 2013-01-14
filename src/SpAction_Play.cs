using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_Play : Item, IRunnableItem
	{
		public override string Name { get { return "Play"; } }
		public override string Description { get { return "Play current track in Spotify"; } }
		public override string Icon { get { return "gtk-media-play"; } }

		public void Run()
		{
			new SpDBus().Play();
		}
	}
}
