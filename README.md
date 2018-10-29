# Fishrodah
###### Yet another fishbot for World of Warcraft

![Screenshot of Fishrodah](fishrodah.png "Screenshot of Fishrodah")

Fishrodah is another fishing bot for World of Warcraft. It uses unique methods to catch fish. It neither injects dll nor changes anything on memory. Fishrodah uses image processing to find the fishing bobber. It simply searches bobber image (bobber.png) on screen. It also uses sound processing to determine correct timing to click the bobber. It just listens your sound card output (does not records anything) and fires an event when fishing sound found. To make Fishrodah work, WoW window must be visible and there must not any sound or music playing in background. The only sound source must be WoW. 

## Support
- World of Warcraft Legion (7.1.5)
- and probably any other expansions too... I didn't tested others yet.

## Usage
- Mute music and environment sound in-game
- Put fishing spell on action bar
- Find a silent fishing spot (really, any kind of noise affects the performance of bot)
- Select WoW process from list
- Set fishing button key
- Select active speaker from sound source list
- Click "Start Bot"

**Note that**, depending on your fishing location, you may need to replace bobber.png with your own screenshot.

## Building
- Clone project somewhere.
- Install python library dependencies in Fishrodah/Listener folder via: 
```
pip install -r requirements.txt
```
- Run ``build.bat`` in Fishrodah/Listener folder in order to compile python sources. You can add this batch file to pre-build events in Visual Studio project properties.


## Download
**v0.9.1** - Click [here][download] to download latest release

 [download]: https://github.com/BekirUzun/Fishrodah/releases/download/v0.9.1/Fishrodah-v0.9.1.zip "Fishrodah-v0.9.1"
