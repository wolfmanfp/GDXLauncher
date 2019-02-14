# GDXLauncher

This program is a Windows launcher for libGDX-based source ports for Blood and Redneck Rampage called BloodGDX and RedneckGDX by [Alexander 'M210' Makarov](http://m210.duke4.net). It can start the game with a portable Java runtime, so you don't have to install Java if you don't want to.

Duke4.net forum member NightFright has already released a launcher for BloodGDX bundled with jPortable. I developed this idea further by supporting the more recent OpenJDK Runtime for starting the game, and added RedneckGDX support.

You can download jPortable or OpenJDK from the links the Links section of this readme. Make sure you unpack the runtime in the game's folder:
* OpenJDK: `C:\Path\To\Your\Game\jre`
* jPortable: `C:\Path\To\Your\Game\JavaPortableLauncher`

If you don't have any of these in your game folder but have Java installed, it just uses your installed runtime anyway.

The launcher was written in C#, and so it needs .NET 3.5 to run (it's included with Windows 7+ and available for XP, so that won't be an issue).

## Build

You need Visual Studio 2017 to compile this program. You can build `BloodGDX.exe` and `RedneckGDX.exe` by selecting the configurations named *Blood - Release* and *Redneck - Release* respectively.

## Links
* [jPortable](https://portableapps.com/apps/utilities/java_portable)
* [OpenJDK 11](http://jdk.java.net/11/)

### More useful links
* [BloodGDX](http://m210.duke4.net/index.php/downloads/download/8-java/50-bloodgdx)
* [RedneckGDX](http://m210.duke4.net/index.php/downloads/download/8-java/52-redneckgdx) ([source](https://gitlab.com/m210/RedneckGDX), [BuildGDX source](https://gitlab.com/m210/BuildEngine))
* [BuildGDX forums](https://forums.duke4.net/forum/42-buildgdx/)
* Buy Blood: [Steam](https://store.steampowered.com/app/299030/Blood_One_Unit_Whole_Blood/), [GOG](https://www.gog.com/game/one_unit_whole_blood)
* Buy Redneck Rampage: [Steam](https://store.steampowered.com/app/565550/Redneck_Rampage/), [RRRA Steam](https://store.steampowered.com/app/580940/Redneck_Rampage_Rides_Again/), [GOG](https://www.gog.com/game/redneck_rampage_collection)
* [NRedneck (formerly Rednukem) and NBlood](http://nukeykt.retrohost.net/): Reverse engineered Redneck Rampage and Blood ports based on EDuke32