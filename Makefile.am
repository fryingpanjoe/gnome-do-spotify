include $(top_srcdir)/build.rules.mk

ASSEMBLY=Spotify

FILES = \
	src/SpAction_Next.cs \
	src/SpAction_Pause.cs \
	src/SpAction_Play.cs \
	src/SpAction_PlayPause.cs \
	src/SpAction_Previous.cs \
	src/SpAction_Stop.cs \
	src/SpDBus.cs \
	src/SpItemSource.cs

RESOURCES = \
	Resources/Spotify.addin.xml 

BUILD_DEFINES=$(DBUS_BUILD_DEFINES)

REFERENCES = \
	System \
	System.Core \
	$(DBUS_SHARP_LIBS) \
	$(DBUS_SHARP_GLIB_LIBS) \
	$(DO_UNIVERSE_LIBS)
