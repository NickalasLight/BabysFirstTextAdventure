namespace BabysFirstTextAdventure
{
public class User
     {
            public string name;
            public string description;
            public string homeCountry;
            public string language;
            public string promptMemory; //tells the llm how they are supposed to behave.
            public List<object> inventory; //tells us everything they have and own, buildings and game objects
            public Coordinate location;

            public User(string name, string description, string homeCountry, string language, string promptMemory, List<object> inventory, Coordinate location)
            {
                this.location = location;
                this.name = name;
                this.description = description;
                this.homeCountry = homeCountry;
                this.language = language;
                this.promptMemory = promptMemory;
                this.inventory = inventory;
            }
        












    }



}