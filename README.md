gnome-do-spotify
================

A Gnome-Do Spotify plugin.

Build and install instructions
------------------------------
1. Install monodevelop.

2. Clone the Gnome-Do and Gnome-Do Plugin repos:

```
bzr branch lp:do
bzr branch lp:do-plugins
```

3. Install build depdencies for both repos.

```
apt-get build-dep gnome-do gnome-do-plugins
```

3. Build the Gnome-Do solution.

4. Put the gnome-do-spotify repo contents in a "Spotify" directory under
   do-plugins.

5. Open the Gnome-Do Plugins solution.

6. Build the Spotify plugin.

7. Drag the Spotify.dll to the Gnome-Do plugin list dialog (Preferences -> Plugins).
