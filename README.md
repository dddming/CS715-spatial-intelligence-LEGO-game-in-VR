# CS715-spatial-intelligence-LEGO-game-in-VR
This program is a new VR game-based spatial training system using Unity 3D, with two different input types. Goodtogo branch contains mouse and keyboard input version. The game is rendered on the PC screen, and the user achieves the goal by mouse drag. VR-demo branch includes VR input version which rendered on Oculus Rift headset screen and controlled by Oculus controller. Unity3D version 2020.3.8f1 and Unity3D 2020.3.8f1 is required to run this program.

The published version for the window system is shared with google drive: https://drive.google.com/file/d/1xH0gNK0XXFBbDhp6ODMesLHl0Ll0UpHM/view

## Functionality

The mouse-based block game contains four levels, which provide spatial training tasks for users with visualization, mental rotation, spatial perception and spatial working memory. In the first task, participants are given three-view graphs and instructed to grab the cubes and arrange them in the appropriate spot in the ghost frame. The second assignment requires participants to practise mental rotation by mentally rotating the figure 90 degrees counterclockwise and dragging the cubes presented to fill in the 1x1x5 ghost frame. Participants may proceed to the next assignment if they fill the ghost frame with cubes. When participants arrive at the third task, they will see an unfurled huge figure with four cubes and must mentally fold the presented figure. The last exercise is designed to strengthen participants’ spatial working memory by presenting them with a model of six coloured cubes for 10 seconds and asking them to reconstruct the model. The final task’s clue is distinct from the others. When participants activated the ”hint” button, they could continue to look at the graph for an additional three seconds.

Here is a snapshot of the game:


![image](https://user-images.githubusercontent.com/49866359/138580134-54d91ecf-43b5-4dab-9bd5-645790630114.png)

* "Help" button - provided the proportion of accurate positions in the overall number of correct positions. For instance, if the user has five cubes in the right location in the ghost frame and the total number of cubes placed in the ghost frame is six, the Help button will display "5/6".
* "Hint" button - the cube’s corresponding location in the ghost frame flashes when the users select the cubes. 
* Timer - the timer with 10 seconds is only used for spatial working memory tasks.
* Next button - the Next button only presents when the users finish the task. 
* Animation - "congratulation" shows up when the task is successfully completed. "try again" shows up when the task is failed but completed. 


