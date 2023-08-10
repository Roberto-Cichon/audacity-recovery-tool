# Audacity Recovery Tool

I made this project to recover a recording made with audacity.
When you record something in audacity there is a chance that the program will crash and you will lose the recording, luckily audacity saves the audio in temporary .au files, this simple python script should reorder these files and delete duplicates.


## Warning

- I recommend that you use this script on a copy of the temporary .au files and not on the originals.

- This script has only been tested on one project in **Audacity v2.4.1**, the project was recorded in stereo and the crash was relatively recent, although in this case it worked I can't confirm that it works in all cases.

## How to use

Select the folder with ALL the .au files, these files should have a name like this: **"e0800a2e.au"** 
It's posible that these files are in separete folders, something like 'd00', 'd01', 'd08', etc... Please put all the files in one folder.
Once the process has finished import all the files into audacity, select all the tracks with [CTRL+A] then go to 'Tracks > Align Tracks > Align End To End'. 
**Enjoy!**
