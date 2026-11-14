# WG2 Devlog
## Sean Elston

Notes from activity one 


Static methods can be called independantly by themselves without being attatched to a game object
( probably gonna re write these later )

# WG2 Activities
Breakdown Image for Penguin Game

<img width="1536" height="864" alt="Untitled" src="https://github.com/user-attachments/assets/4b9583be-0130-452b-b30d-f24cff5de7c2" />


# WG3 Devlog
## Quiz answers and notes

Enum states are mutually Exclusive and cannot ovveride each other or have multiple at once
Classes that inherit from a parent class, will inherit monobehaviour or inherit grandparents
Static means u can use it directly from the class name instead of making a vector 3 before 


## Lecture notes
### Inheritance 
Q:  what is inheritance - Parent script is inherited by the children script - A: Children scripts can call methods and variable from the parent script.
Q: How might it be useful when building minecraft - A: Mobs can inherit Shared variables and shared methods that are generic to all mobs - a template wiht unique implimentation.

Q: How do you think inheritance helps avoid code duplication - A: Inheritance means that if there is any behaviour that is shared, that behaviour can be placed in the parent class so the child can call it without re writing that script again.

Q: Why does avoiding code duplication matter - A: Code duplication can be a burdern on optimization and code readability

### Enum - states

Using bools to handle states is messy due to the possibility of overlaping states which can cause issues - can also be a drag to use a lot of if statements to do those bools. 

Q: What is a finite state machine - A: A finite state machine is a machine or design patter that keeps track of mutually exclusive states and switches them. 
Q: Where can you imagine finite state machines being useful in game development? - A: NPC aggression levels in game, for example Fallout 4, does the NPC like you or dislike you, and what are they currently doing - Sleeping - Wandering - Walking to a specific place - Anggro or attacking - Searching looking for enemy or player - ETC~

Q: How could you imagine a Finite State Machine be useful to build a system for the minecraft cows various actions? - A: State for Wander - Follow Player - Eat food - Run away from threat - Maate. Actions might change the animation or action of the NPC

Q: Now that we know that  mobs various actions are organized into states, how might we build a system that uses state machines while the classes are inheriting from a parent mob class, Does that affect our architecture? - A: Could let the parent define the state machine and then have the children conform to that state machine, if the diffrent NPCS have wildly diffrent states then they might need to ovveride

## MG3 Diagram

Diagram for MG3 project 

<img width="7200" height="5400" alt="SeanElston_MG3_Diagram" src="https://github.com/user-attachments/assets/3dc67bfe-27bb-4c9f-9770-96c3c5985a63" />


# WG4 Devlog



## Quiz answer notes
1. reusing classes and using child classes is important and helpful for reducing rewritten code and sharing behaviour between classes.

2. Polymorphism is having the same method names but diffrent behaviour for subclasses. (note for self polymorphism is in relation to methods)

3. Enums can be used in order to create finite state machines so that no one state is active at the same time. 

## Lecture notes

Vectors and Transform Components

Vectors:

A scalar is a single value : speed
A vector is a list of values: in 3D simulations, 3 scalars representing somthing going on in all 3 axes - Velocity => speed - Displacement => distance on xyz axes

Most common usage: Displacement in 3D space
- you can visualize vectors as an arrow pointing from on location to another
- the (xyz) components of a vector tell you about how far you traveled on each axis to get from the first point to the second.

Transforms: 
- Transofmr components store the information about our object in the 3D cartesian coordinates
- Position, rotation, and scale are all 3d Vectors

3d Vectors for rotation
- makes the object spin on a poly laying straight on that axis
- objects will always rotate around pivot of object in scene

Transform.rotate() method to rotate an object - called on an existing transform not by itself

Coordinate spaces 
- A coordinate space is a relative space that vectors can live in
- Coordinate space are defined by a an orgin (center 0,0,0 position)
- Two most important coordinate spaces are object and world space, 
- In unity : Able to switch between viewing local and global control points 
- each object in the unity scene will have its own object space that is seperate from the global worldspace 

Vector3 moveAmount = new Vector3(0,0,1);

1. transform.Translate(moveAmount);

2. transform.positon += transform.forward * moveAmount;

3. transform.position += moveAmount;

Lines 1 and two will succesfully move the gameobject in its worldspace, Transform.Translate defaults to the object space when not otherwise specified in the code and transform.position when combined with transform.forward will ensure the object moves forward realtive to object space.

Animation

Animation clips and controllers are assets not components - created in the asset browser which then are used by the animation controller within the scene. 
parameters ar set in the animation editor which we can call in scripting

_animator.SetBool("flying", true) syntax for setting bool


## Activity Devlog Question Answer
q: in Step 2 of your Muskrat code, why does your new line of code move the Muskrat forward correctly? Use the vocab term "coordinate space".
a: In step 2 I replaced the line transform.position with transform.translate. I did this because transform.position uses the world coordinate space, while transform.translate uses the local coordinate space (by default if not otherwise stated in the code) which means that instead of moving the player relative to the worldspace the script is now moving the player relative to the local coordinate space.


# WG5 Devlog
## Lecture notes

Final Project Options

- Point and click adventure with branching dialogue
- or unique idea that satisfys complexity requirments

### Tightly coupled vs loosley coupled code

Tightly coupled code is when a class has refrences to all of the diffrenct objects and gameobjects in a scene and refrences them all in the same script in order to trigger an action - which is inneficent and can cause a lot of extra code to be written

Loosley coupled code is when the class uses Events in order to brodcast a message to all the other components in a scene to tell them what to do rather than manually writng that logic in one class.

This way the other objects in a scene (ui, enemys, npcs, vfx, etc) only have to subscribe to the event that the main class is calling in order to trigger those events. Thus for Decoupling the code

### Model-View-Controller Pattern

Most games are architected with the model view controller design, a pattern in which each of these systems are decoupled from each other.

The model represents game data

The view represents visuals and results, like sound, ui, and animations

The controller represents Game Logic, like battles, points, or branching dialogue systems.




# WG6 Devlog
## Quiz Notes

- q4 - method is not abstract or virtual so we cannot ovveride it in the script calling the method
- abstract metods need to be implimented in the child class that is inheriting the abstract class.
- intefaces are essentially abstract classes with some diffrences.

## Model View Controller Pattern
- model is the data View is the player facing stuff, controller is the game code/logic.
- When building objets in a game, its good to seperate the data from the logic so when other designers need to work on characters or art they dont need to recompile code to change things

## Scriptable objects
- Scriptable objects should be used to store things that are purley data (not game logic), rather than hard coding that data into the game object. 


## Activity 4 - Desgin pattern Discussion

1 Hatsune Miku Rythm game
- Scriptable objects for defining timing, key press type, Sprite, 
- Singleton - When pressing a button it needs to affect multiple diffrent things at once, So a singleton locator in order to handle sending events to all the corresponding sound, vfx, and visual systems in order to make the game smoothly while compartmentalizing code.
- Polymorphism in order to handle the diffrent types of rythm movers(?) in order to reduce repetative code as well. Since most of the rythm beats share the same logic but have slightly diffrent actions. 

2 Valorant 
- Inheritence/Polymorphism - handles the Health, Movement, and attacks for each player, since while there are diffrent characters, their base level health attacks and movement are all identical in order to keep a fair playing field.
- State Machine - Handles things like animation, Unique attacks that cannot be cancelled, and other states that need to be exclusive.
- Scriptable Objects - Can handle weapons damage or ability damage to allow designers to make balance tweaks without going to recompile the code of the game. 
- Singletons - handling player input and matching to all of the other systems in the game, additionally syncing damage and stats acrost all the diffrent players in the game. 

## Final project requirments 
- Every week mandatory group meeting in class
- Proposals - Propsal first draft is due before next class, will get feedback during next class. - Will edit Final Draft based on feedback.
- Project Submissions - Milestone 1, 2, and 3 - 11/06 Milestone 1 - Milestone - Milestone 3 12/11


Project Ideas - Physics based quests - simiar to Peak - Grabbing and throwing or placing objects on places.

# WG7 - Lecture notes
## Optimization Notes
- Players expect games to run at 60fps 
- others can run at 30fps
- 60 fps = only have 16.6 ms to create a frame
- 30 fps = only have 33.3 ms to create a frame
- all work is splt into two major proccessors - cpu and gpu

### Memory 

What is memory? 
- Memory is space on the computer for data
- data = assets, variable, scens and the stuff inside.

In C# memory thats no longer in use is automatically garbaged collected (cleaned up) which can take signifigant ammount of times
 
A few common issues with memory for performance
- Art assets - textures models - etc - or scenes hat are unnecesarily large.
- Code that operates on unnerssarily large data structures lke lists and arrays too often.
- Code that causes frequent garbage collections of large amounts of data.

GC comes peridoically and sweeps up any memory that cant be accessed by the progaam at that point in time 
- variables will take up space in memory

Assuming the GC runs right after the for loop executses, will the momory for the message be farbage collected?

A: - Yes the message was declated inside the loop so it will contintually be reassigned.

## Profiler

Profiler can help you find issues in your scene and where exactly specific issues are from.

look in heirarchy tab to see where the most time consuming calls are happening. 

Stats Tab in unity will also show current FPS and other issues

## common student project performance issues
- allocating strings frequently (inside loops, inside update)
- too many debug messages
- putting stuff in update that doesnt need to run every fram
- Using GetComponent can bog down performance compared to using a serialized field.
- Avoid allocating memory in Update - use member variable instead
- Giant Textures / Extremly dense meshes
- Using unnecissarily complex colliders - you almost never need mesh colliders!
- USing Lots of Rigidbodies 
- if all you need to detect collision, put a rigidbody on the player and not the other object - or set the other

## how much is "too much" how often is "too often?"
What constitutes a performance issues is relative to your project
Depends primarily on 1: what platform you want to ship on and then 2: what game experience youre trying to deliver.
Somthing is too much and too often when it is causing and issues
Issues can be identified by 
- Seeing a spike in the profiler 
- Time # of calls, GC alloc being much larger than anything else in CPU usage list
Be Wary of people on the internet telling you "this is bad" confidently without knowing cotext
best way to learn is through experience

Final Notes for myself 
- wary of texture size and poly count
- wary of strings being ran too many times
- Check the profiler to make sure that things arent taking unnesary ammount of time 

# W8 







# W9 Notes
## Activity 1 Notes
### Scaling 
How would you Describe the problem of discerning whether or not your architectural solution will "scale well?
- A architectural solution will scale well if, wehn the program is handling a lot of data.
- - Its performant (Not addressed in this class much)
- - Its easy for users , whether theyre other programs or content makes designers, writers, artists, 

Why should the issue of scaling matter to you as a Game art student? or in our career
- Scaling matters because if somthing doesnt scale well then it makes the project more and more difficult and harder to work on, creating slow downs in the process.
- If you want ot be a programrer in a career then you need to be able to optimize code both for making it more efficent to run, as well as making it easier to read understand and scale well in a large scale project. 

How does the concept of scaling relate to the programing design patterns we've talked about in class.
- all of the design patterns we'ev learned will help your write code that scales well.
- Think about how the following & OOP principles can help your codebase grow without getting unmanagable, as a programer or a designer.
- - State Machines 
- - MVC
- - Abstraction and Polymorphism.


### Demo Branching Dialogue.
Dialoge nodes 
- store refrences to other dialogue nodes.
- Becomes brancing dialogue, each node stores refrence to another node, allowing the player to go down the 

Proffesional dialogue systems
- If you have to make hundres or more lines of dialogue
authoring stuff in the engine is not the most efficent way to do it

- in most proffesional cases use some kind  of external tool to author dialogue
- some sort of tool that visualizes branching dialogue, allowing the developer to plan out their dialogue 

## Activity 2 Notes
- Started with movement Script and building out scenes to 
- For today working on creating the logic for trackig when items are placed in the right place for a Task

## Activity 3 
- New Features added - Finished movement script and switched to using the chracter controller. Added the logic for tracking when objects are placed in a specific zone.

Objects are tagged with the "QuestItem" Tag, the objects that are used for the zones objects need to be placed in have a second collider that is a trigger. 
The "Quest Zone" Objects in the scene use the E_QuestZone Class which uses OnTriggerEnter and OnTriggerExit to track when an object tagged with "QuestItem" enters a scene. It then a fires an method inside of the Locator class, which (eventually) will trigger and event that the UI will subscribe to and then update when the appropriate score is reached.

I collaborated with my partner today in quite a few diffrent instances. We went back and forth asking advice from each other in order to decipher which is the best way to go about scripting things. And since we are already using and testing each others scripts we go back and forth troubleshooting when somthing isnt working correctly. 

Doing this we were able to make sure that the player movement and object pick up mechanic is fully functional and will not hinder our development going forward since its sorted out pretty much as much as we need. Learned that often having multiple sets of eyes on a project can be really helpful in quickly troubleshooting an errror.

# W11 notes
## Activity 2 - Playtest
### Notes from playtesting
- the controller is too fast 
- play tester automatically knew to grab objects and place them in the scene, 
- objects seem to be phasing through the walls when moved too fast - change collision type probably.
- taking awhile to stock items. Ran around a while before starting that task
- player knew/immdeatly tried to grab the rat objects as soon as they saw it. 
- Breaking/messing with stuff was fun to the player.
- the limited ammount of UI was already helpful.
- Need to clarify which sheleves need to be stocked
- Player tried to escape but did not succeed, good
- Rotation of phys objects feels a little weird. 

## Activity 3 - Task Check in
I started working on modiying the first task to create another one that is slightly diffrent, and then starting on creating the quest manager. to track when quests are complete.