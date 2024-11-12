namespace BabysFirstTextAdventure
{



public class ActionInterpreter
{
public User myUser;
public World myWorld;

public ActionInterpreter(User user, World world)
{
this.myUser = user;
this.myWorld = world; 



}
public Interpret(List<string> action)
{
switch(action[0].ToLower())
{
//error handeling for out of bounds, need to think about how you can get an llm to clarify some text into a likely series of movements, then pass in a batch to the interpreter.
case("move"):
if(action[1].ToLower()=="north")
{this.myUser.location.y++;
Console.WriteLine("You move north");
}
elseif(action[1].ToLower()=="south")
{this.myUser.location.y--;
Console.WriteLine("You move south");
}
elseif(action[1].ToLower()=="west")
{this.myUser.location.x--;
Console.WriteLine("You move west");
}
elseif(action[1].ToLower()=="east")
{this.myUser.location.x++;
Console.WriteLine("You move east");
}
else
{
Console.WriteLine("Invalid command: move + " + action[1]);

}



case("describe"):
{
    Console.WriteLine("For now this is not really implemented, but will describe the world block");
    Console.WriteLine(this.myWorld.GetBlock(this.myUser.location).description)

}

case("grab"):









}




}
















}

}