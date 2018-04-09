# CS 4331-002 - Virtual Reality Project 2
# Topic: Water Elevation
## Due: April 10, 2018

## Video demonstration
   - On my YouTube channel: https://www.youtube.com/watch?v=IPB3wdwSTVM
## Try it out
   - The web application can be found at http://swoldemi.me/VR-Project-1
   
## Project Report

### We learned...
- The basics of Unity and C#
- How to download and import different assets from Unity asset store
- How to write C# code to activate and stop the particle system
- How to write C# code to activate and stop the audio
- How to write C# code to read data from excel documents
- How to establish the connections between buttons and gameobjects
- How to buttons to control the scripts
- How to add trees and grass to the terrain
- How to create the first person controller
- How to create user interfaces
- How to scripts to the interfaces
- How to instantiate different prefabs
### Biggest Issues
- mapping the terrain from the available data
- accurate depth representation of each well
- merging contributions from each teammate

## Contributors
- Lino Abiel Virgin, Wenhao Ge, Kevon Manahan

## Dynamic features/interactables
There's a start menu when you begin the game that allows the player to select which city will be used, as of now the only city is Lubbock. Whenever you click a well from within the game, it will display the information about each well. Also there is a User Interface which allows the player to cycle between cameras(Main, Elevation, and Aerial) by clicking each button respectively.

### Work Distribution
- Wenhao Ge's part:
   - Chose the terrain and exported the terrain from the high map 
   - Created the rain effect and cloud effect by using particle systems
   - Created a water fountain by using particle system
   - Created two buttons called "pause" and "play" to activate the rain and stop the rain
   - Wrote scripts to let buttons control the rain audio
   - Found out the monthly precipitation data in Lubbock and recorded the data in an excel document
   - Read data from the excel document and calculate the average precipitation data for each season.
   - Created the water layer and set the water thickness by using the average precipitation data for each season
 - Kevon Manahan's Part
   - Created models to represent elevation of each well
   - Read data from Excel so the elevation is scaled properly for each well
   - Added 2 cameras so the user could swith between different perspectives(Aerial, Elevation, First Person)
   - Created a start menu for the game
   - Added 3 buttons on the Game Interface to switch between cameras
   - Wrote the script to switch between cameras
   - Added an audio to the start menu of the game
   - Created a skybox for both the start menu and play mode
