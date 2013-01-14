using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_Next : Item, IRunnableItem
	{
		public override string Name { get { return "Next"; } }
		public override string Description { get { return "Play next track in Spotify"; } }
		public override string Icon { get { return "gtk-media-next"; } }

		public void Run()
		{
			new SpDBus().Next();
		}
	}
}
