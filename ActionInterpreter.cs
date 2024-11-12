namespace BabysFirstTextAdventure
{



public class ActionInterpreter
{
public User myUser

public ActionInterpreter(User user, World world)
{
this.myUser = user;
this.myWorld = world; 



}
public Interpret(List<string> action)
{
switch(action[0].ToLower())
{
case("move"):
if(action[1].ToLower()=="north")
{this.myUser.location.y++;}
elseif(action[1].ToLower()=="south")
{}
elseif(action[1].ToLower()=="west")
{}
elseif(action[1].ToLower()=="east")
{}



case("describe"):

case("grab"):









}




}
















}

}