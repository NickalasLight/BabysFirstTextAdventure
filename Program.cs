//For now, we will create simple world that is 10 by 10 grid
/*
 

0,0




 
I
I
I
I_______
 
 
 
 */
//For now we will gen both the world and the user here in main.
//The most obvious improvement is the use of config files, in a readable format for different save files

//Create new world with 4 world blocks
World myWorld = new World();

myWorld.AddBlock
(


new WorldBlock(
    coordinate: new Coordinate(x:0,y:0),
    descriptions:new List<string>{"this is the world at 0,0"},
    gameObjects:new List<GameObject>{},
    gamePois:new List<GamePoi>{},
    gameBuildings:new List<GameBuilding>{},
    gameNpcs:new List<GameNpc>{}
    )

);

myWorld.AddBlock
(


new WorldBlock(
    coordinate: new Coordinate(x:0,y:1),
    descriptions:new List<string>{"this is the world at 0,1"},
    gameObjects:new List<GameObject>{},
    gamePois:new List<GamePoi>{},
    gameBuildings:new List<GameBuilding>{},
    gameNpcs:new List<GameNpc>{}
    )

);

myWorld.AddBlock
(


new WorldBlock(
    coordinate: new Coordinate(x:0,y:1),
    descriptions:new List<string>{"this is the world at 1,0"},
    gameObjects:new List<GameObject>{},
    gamePois:new List<GamePoi>{},
    gameBuildings:new List<GameBuilding>{},
    gameNpcs:new List<GameNpc>{}
    )

);

myWorld.AddBlock
(


new WorldBlock(
    coordinate: new Coordinate(x:0,y:1),
    descriptions:new List<string>{"this is the world at 1,1"},
    gameObjects:new List<GameObject>{},
    gamePois:new List<GamePoi>{},
    gameBuildings:new List<GameBuilding>{},
    gameNpcs:new List<GameNpc>{}
    )

);

User myUser = new User(
name:"nick",
description:"the game developer",
homeCountry:"USA",
language:"English",
promptMemory:"",
inventory: new List<object>{},
location: new Coordinate(0,0)




);





//Create a new user with the location at the southwest (0,0)









 //Takes input from user
 //lets add a simple set off verbs as a switch statement class, I guess? 
string myVerb;
ActionInterpreter interpreter = new ActionInterpreter(myWorld,myUser);
While(!="ExitGame")
{
//The classic enternal while loop for a game
myVerb = Console.ReadLine();
interpreter(myVerb);

}



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Closing Game");
