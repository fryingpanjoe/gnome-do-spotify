using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_Stop : Item, IRunnableItem
	{
		public override string Name { get { return "Stop"; } }
		public override string Description { get { return "Stop current track in Spotify"; } }
		public override string Icon { get { return "gtk-media-stop"; } }

		public void Run()
		{
			new SpDBus().Stop();
		}
	}
}
