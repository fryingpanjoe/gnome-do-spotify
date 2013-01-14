using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{
	public class SpAction_Previous : Item, IRunnableItem
	{
		public override string Name { get { return "Previous"; } }
		public override string Description { get { return "Play previous track in Spotify"; } }
		public override string Icon { get { return "gtk-media-previous"; } }

		public void Run()
		{
			new SpDBus().Previous();
		}
	}
}
