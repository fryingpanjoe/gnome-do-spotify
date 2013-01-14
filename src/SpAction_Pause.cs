using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_Pause : Item, IRunnableItem
	{
		public override string Name { get { return "Pause"; } }
		public override string Description { get { return "Pause current track in Spotify"; } }
		public override string Icon { get { return "gtk-media-pause"; } }

		public void Run()
		{
			new SpDBus().Pause();
		}
	}
}
