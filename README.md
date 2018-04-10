# CS 4331-002 - Virtual Reality Project 2
# Topic: Water Elevation
## Due: April 10, 2018

## Video demonstration
   - On our current repository: https://github.com/WenhaoGe/VR_Project2/tree/master/Assets/Resources/media/demo.mp4

## Screenshots
   - On our current repository: https://github.com/WenhaoGe/VR_Project2/tree/master/Assets/Resources/media/screenshots.jpg

## Try it out
   - The web application can be found at 
   
## Project Report

### We learned...
- The basic tutorials of Unity and C#
- How to download and import different assets from Unity asset store
- How to write C# code to activate and stop the particle system
- How to write C# code to activate and stop the audio
- How to write C# code to read data from csv documents
- How to establish the connections between buttons and gameobjects
- How to use buttons to control the scripts
- How to use buttons to control the cameras
- How to show the well information without clicking the well objects
- How to control the audio by using a key
- How to add trees and grass to the terrain
- How to change the texture of terrain
- How to create the first person controller
- How to create the third person controller
- How to create user interfaces
- How to scripts to the interfaces
- How to instantiate different prefabs

### Biggest Issues
- mapping the terrain from the available data
- accurate depth representation of each well
- merging contributions from each teammate

## Contributors
- Lino Virgen, Wenhao Ge, Kevon Manahan

## Dynamic features/interactables
There's a start menu when you begin the game that allows the player to select which city will be used, as of now the only city is Lubbock. Whenever you click a well from within the game, it will display the information about each well. Also there is a User Interface which allows the player to cycle between cameras(Main, Elevation, and Aerial) by clicking each button respectively.

### Work Distribution
- Wenhao Ge's part:
   - Chose the terrain and exported the terrain from the high map 
   - Created the rain effect and dynamic cloud effect by using particle systems
   - Created a water fountain by using particle system
   - Created four buttons called 'Spring",'Summer','Fall,'Winter'. When 'Fall' is clicked, the scene starts  raining. When other three buttons are clicked, rain stops 
   - Changed the underground water layer thickness by clicking the previous four buttons
   - Wrote scripts to let buttons control the rain audio
   - Found out the monthly precipitation data in Lubbock and recorded the data in a csv document
   - Read data from the csv document and calculate the average precipitation data for each season.
   - Created the water layer and set the water thickness by using the average precipitation data for each season
   - Decorated the terrain by using trees, grass and houses
 - Kevon Manahan's part:
   - Created models to represent elevation of each well
   - Read data from Excel so the elevation is scaled properly for each well
   - Added 2 cameras so the user could switch between different perspectives(Aerial, Elevation, First Person)
   - Created a start menu for the game
   - Added 3 buttons on the Game Interface to switch between cameras
   - Wrote the script to switch between cameras
   - Added an audio source to the start menu of the game
   - Created a skybox for both the start menu and play mode
