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


## Activity
### Inheritance 
Q:  what is inheritance - Parent script is inherited by the children script - A: Children scripts can call methods and variable from the parent script.
Q: How might it be useful when building minecraft - A: Mobs can inherit Shared variables and shared methods that are generic to all mobs - a template wiht unique implimentation.

Q: How do you think inheritance helps avoid code duplication - A: Inheritance means that if there is any behaviour that is shared, that behaviour can be placed in the parent class so the child can call it without re writing that script again.

Q: Why does avoiding code duplication matter - A: Code duplication can be a burdern on optimization and code readability

### Enum - states

Using bools to handle states is messy due to the possibility of overlaping states which can cause issues - can also be a drag to use a lot of if statements to do those bools. 

Q: What is a finite state machine - A: A finite state machine is a machine or design patter that keeps track of mutually exclusive states and switches them. 
Q: Where can you imagine finite state machines being useful in game development? - A: NPC aggression levels in game, for example Fallout 4, does the NPC like you or dislike you, and what are they currently doing - Sleeping - Wandering - Walking to a specific place - Anggro or attacking - Searching looking for enemy or player - ETC~



