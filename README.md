# Game Project - Helicopter 
---
## Summary of the Game project
Start Date: 09.09.2019 / End date: 11.09.2019
***
Instruction: 
- Left button to move up 
- Right button to move down
- avoid obstacle 
- score is calculate by surviving/avoding the obstacle 
- if player collide with obstacle, game will provide a message box with message, result and close the game.

***
Day 1) Create two window: MainWindow for Gameplay and MessageScreen for Message.
> MainWindow: Design the interface and the code the mouseclick and keyboard event to recognise the image through the button.

> MessageScreen: Design the interface and when the player press "Space" it will close the MessageScreen window and open the MainWindow. 

> Problems: no problem with design interface however i only have to change on the design, it was to change "Helicopter image" to button and place the image within the button. 

***
Day 2) Work on the Helicopter and obstalce animation

> I was working on the helicopter animation which can be control by key up or key down or mouse click. added a timer to calcuate the     distance. this is helpful because i can stop the timer, when the player collide with the obstacle and it will end the game and show the final distance result on the message box 

> Problems: I was trying to follow window forms techniques however in WPF, some of the techniques does not work and most of the time was wasted due to that. E.g. Bounds for colllision however bounds function does not exist in the WPF. 

*** 
Day 3) Finish the project and Github

> Game Project: I was working on collision between button(image/Helicopter) and obstacle (recetangle) however when I did more research on collision and there is no option to do collision between button and recentangle therefore I have to change the design interface to replace the button(image/Helicopter) with rectangle(image/Helicopter) then I can do the collision between Helicopter(rectangle) and obstacle(rectangle). Also I was working on the obstacle, if they go out of the window bounds then obstacle returns to original location. 

> Github: create documentation file on the Github to explain the project and experince with the project and push the Game Project to github. 

> Problems: when i was trying to collide obstacle (rectangle object) with button but in WPF you cannot collide rectangle with button, therefore i have to change the design from button to rectangle. 

***
ScreenShot: 


***
Overall Experience/ Future: 
it was fun and challenging working on this project because I had small experience with Csharp and WPF and this project has taught me new techinques can be used in Csharp, E.g. How to use Dispatch timer to control the survive score and obstacle. 

This project can help me in the future as reference for "Do" and "Do not" on working with Csharp and WPF to reduce time waste. 
