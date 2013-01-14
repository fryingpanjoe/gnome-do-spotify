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
		public override string Icon { get { return "spotify"; } }
		
		public override IEnumerable<Type> SupportedItemTypes {
			get { 
				yield return typeof (IRunnableItem);
				yield return typeof (IApplicationItem);
			}
		}

		public override IEnumerable<Item> Items { get { return items; } }

		public override IEnumerable<Item> ChildrenOfItem(Item parent) {
			List<Item> children = new List<Item>();
			/*
			children = new List<Item>();
			if (parent is ArtistMusicItem) {
				foreach (AlbumMusicItem album in AllAlbumsBy (parent as ArtistMusicItem))
					children.Add (album);
				children.Add(new BrowseAllMusicItem (parent as ArtistMusicItem));
			}
			else if (parent is AlbumMusicItem) {
				foreach (SongMusicItem song in xmms2.LoadSongsFor (parent as AlbumMusicItem))
					children.Add (song);
			}
			else if (parent is PlaylistItem) {
				foreach (SongMusicItem song in xmms2.LoadSongsFor (parent as PlaylistItem))
					children.Add (song);
			}
			else if (parent is BrowseAlbumsMusicItem) {
				foreach (AlbumMusicItem album in albums)
					children.Add (album);
			}
			else if (parent is BrowseArtistsMusicItem) {
				foreach (ArtistMusicItem artist in artists)
					children.Add (artist);
			}
			else if (parent is BrowsePlaylistItem){
				foreach(Item playlist in xmms2.playlists){
					children.Add(playlist);
				}
			}
			else if(parent is BrowseAllMusicItem){
				foreach (SongMusicItem song in xmms2.LoadSongsFor ((parent as BrowseAllMusicItem).Artist))
					children.Add (song);
			}
			*/
			return children;
		}

		/*bool IsSpotify(Item item) 
		{
			return item.Equals(Do.Platform.Services.UniverseFactory.MaybeApplicationItemFromCommand("spotify"));
		}*/

		public override void UpdateItems()
		{
			items.Clear();
			items.AddRange(controls);
		}
	}
}
