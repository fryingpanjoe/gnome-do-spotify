include $(top_srcdir)/build.rules.mk

ASSEMBLY=Spotify

FILES = \
	src/SpDBus.cs \
	src/SpItemSource.cs \
	src/SpAction_Next.cs \
	src/SpAction_PlayPause.cs \

RESOURCES = \
	Resources/Spotify.addin.xml 

BUILD_DEFINES=$(DBUS_BUILD_DEFINES)

REFERENCES = \
	System \
	System.Core \
	$(DBUS_SHARP_LIBS) \
	$(DBUS_SHARP_GLIB_LIBS) \
	$(DO_UNIVERSE_LIBS)
