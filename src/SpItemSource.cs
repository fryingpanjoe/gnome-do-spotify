using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Addins;

using Do.Universe;

namespace Do.Addins.Spotify
{	
	public class SpItemSource : ItemSource
	{
		List<Item> items;
		List<Item> controls;

		public SpItemSource()
		{
			items = new List<Item>();

			controls = new List<Item>();
			controls.Add(new SpAction_Next());
			controls.Add(new SpAction_PlayPause());
		}

		public override string Name { get { return "Spotify"; } }
		public override string Description { get { return "Control the Spotify client."; } }
		public override string Icon { get { return "spotify-icon"; } }
		
		public override IEnumerable<Type> SupportedItemTypes {
			get { 
				yield return typeof (IRunnableItem);
				yield return typeof (IApplicationItem);
			}
		}

		public override IEnumerable<Item> Items { get { return items; } }

		public override IEnumerable<Item> ChildrenOfItem(Item parent) {
			List<Item> children = new List<Item>();
			return children;
		}

		public override void UpdateItems()
		{
			items.Clear();
			items.AddRange(controls);
		}
	}
}
