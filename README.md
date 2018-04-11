# CS 4331-002 - Virtual Reality Project 2
# Topic: Water Elevation


## Video Demonstration
   - On our current repository: https://github.com/WenhaoGe/VR_Project2/tree/master/Assets/Resources/media/demo.mp4

## Screenshots
   - On our current repository: https://github.com/WenhaoGe/VR_Project2/tree/master/Assets/Resources/media/screenshots.jpg

## Try it out
   - Download the project with the following link: 
   
## Project Report

### Project Description
This project is intended to represent real underground water and wells data. Underground water raises and lowers depending on the seasons and its consumption. Water wells gather this underground water for plenty of purposes, such as water drinkage and irrigation. Since many people and businesses depend on this resources, scientists require tools to analyze its status. Through our project, we hope to depict a real and accurate representation of the resource and its environment. We believe implementing this project using virtual reality provides an inmersive and rich experience for data analyzers.

### Auto-Generation
As soon as the system starts, it starts reading, computing, and delivering data. Most of the objects in our scene are auto-generated by a couple of c-sharp scripts. These scripts gather data from various csv files. The c-sharp scripts generate the wells, their depth, their saturated thickness, aerial markers, and a water layer that spans the whole terrain. These scripts use multiple math operations to math the real life measurements to the unity measurements. In this manner, we were able to accurately place the wells where they are in real life and replicate the measurements of the underground water layer.

### Main Menu
This is the initial scene. It contains a city option (Currently there is only Lubbock available), instructions to operate the tool, and an exit botton.

### First Person Control
With a first person controller the user is able to navigate through the map; adding a realistic field experience. If the user aims the cursor to the auto-generated wells information is displayed. The user is also able to click on the provided bottons which are described in the next section.

### Functionality
If the user clicks on the Toggle Terrain box the terrain layer will become invisible so that the user can observe the underground layers.

<a href="https://imgflip.com/gif/285h9a"><img src="https://i.imgflip.com/285h9a.gif" title="made at imgflip.com"/></a>

The user also has the option to toggle the whole underground water layer so that only the water sections under the wells are shown.

<a href="https://imgflip.com/gif/285hq4"><img src="https://i.imgflip.com/285hq4.gif" title="made at imgflip.com"/></a>

There are two more view options provided to the user. Aerial view changes the camera angle to a top view. Elevation view changes the camera angle to display the multiple layers. The user can go back to first person control clicking on Main Camera.

<a href="https://imgflip.com/gif/285hy8"><img src="https://i.imgflip.com/285hy8.gif" title="made at imgflip.com"/></a>

If the user places the cursor on a well, information about that particular well will be displayed.

<a href="https://imgflip.com/gif/285ip9"><img src="https://i.imgflip.com/285ip9.gif" title="made at imgflip.com"/></a>

In order to show the different water elevations of the underground layer we added a button per season which modifies the saturated thickness according to the precipitation data.

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
- Add HeightMap to Terrain object
- Read csv files through c#
- Modify GameObjects at runtime
- Create virtual reality tool

### Biggest Issues
- Inconsisent/Unreliable datasets
- Mapping the terrain from the available data
- Accurate data representation of each well
- Merging contributions from each teammate
- Scaling terrain for better visualization

## Contributors
- Lino Virgen, Wenhao Ge, Kevon Manahan

## Dynamic features/interactables
There's a start menu when you begin the game that allows the player to select which city will be used, as of now the only city is Lubbock. Whenever you click a well from within the game, it will display the information about each well. Also there is a User Interface which allows the player to cycle between cameras(Main, Elevation, and Aerial) by clicking each button respectively.

### Work Distribution
- Wenhao Ge's part:
   - Chose the terrain and exported the terrain from the height map 
   - Created the rain effect and dynamic cloud effect by using particle systems
   - Created a water fountain by using particle system
   - Created four buttons called 'Spring",'Summer','Fall,'Winter'. When 'Fall' is clicked, the scene starts raining. When other three buttons are clicked, rain stops 
   - Changed the underground water layer thickness by clicking the previous four buttons
   - Wrote scripts to let buttons control the rain audio
   - Found out the monthly precipitation data in Lubbock and recorded the data in a csv document
   - Read data from the csv document and calculate the average precipitation data for each season.
   - Modified the water layer and set the water thickness by using the average precipitation data for each season
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
- Lino Virgen's part:
   - Researched diverse underground water and well datasets
   - Combined relevant datasets using a python script
   - Calculated ratios between real data and unity measurements
   - Wrote script to place wells accurately into terrain
   - Formated terrain to smaller size and render two faces
   - Wrote script to generate underground water layer using raster-to-point data
   - Wrote script to concentrate environment functionality
   - Added visual cursor to scene
   - Added hover functionality to wells to display data
   - Added markers to denote well position from aerial view
   - Supervised GitHub repository and merges

### References
- Texas Water Development Board (https://www.twdb.texas.gov/groundwater/data/gwdbrpt.asp)
- iDataVisualizationLab at Texas Tech University (https://github.com/iDataVisualizationLab/SaturatedThickness)
- Terrain.party (www.terrain.party)
- Unity Asset Store
