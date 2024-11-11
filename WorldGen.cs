using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysFirstTextAdventure
{
    class World
    {
        private List<WorldBlock> blocks;
        public World()
        {  //lot of things can be done with this doesn't matter right now, like a bunch of json or something, for now just a cs file to build the base world for some basic testing

            blocks = new List<WorldBlock>();

        }
        public void AddBlock(
        Coordinate coordinate,
        List<String> descriptions,
        List<GameObject> gameObjects,
        List<GamePoi> gamePois,
        List<GameBuilding> gameBuildings,
        List<GameNpc> gameNpcs)
        {
            this.blocks.Add(new WorldBlock(coordinate, descriptions, gameObjects, gamePois, gameBuildings, gameNpcs));
        }
        public WorldBlock? GetBlock(Coordinate coordinate)
        {

            return blocks.Where(x => x.coordinate == coordinate).FirstOrDefault();



        }
        internal class WorldBlock
        {
            public Coordinate coordinate;
            public List<String> descriptions;
            public List<GameObject> gameObjects;
            public List<GamePoi> gamePois;
            public List<GameBuilding> gameBuildings;
            public List<GameNpc> gameNpcs;

            public WorldBlock(Coordinate coordinate, List<string> descriptions, List<GameObject> gameObjects, List<GamePoi> gamePois, List<GameBuilding> gameBuildings, List<GameNpc> gameNpcs)
            {
                this.coordinate = coordinate;
                this.descriptions = descriptions;
                this.gameObjects = gameObjects;
                this.gamePois = gamePois;
                this.gameBuildings = gameBuildings;
                this.gameNpcs = gameNpcs;
            }
        }
        internal class GameNpc
        {
            private string name;
            private string description;
            private string homeCountry;
            private string language;
            private string promptMemory; //tells the llm how they are supposed to behave.
            private List<object> inventory; //tells us everything they have and own, buildings and game objects

            public GameNpc(string name, string description, string homeCountry, string language, string promptMemory, List<object> inventory)
            {
                this.name = name;
                this.description = description;
                this.homeCountry = homeCountry;
                this.language = language;
                this.promptMemory = promptMemory;
                this.inventory = inventory;
            }
        }

        //inventory item? Something of value? Lots can be added here later.
        internal class GameObject //--> bottle of beer from the shop
        {
            //weight; value; description;
            private string description;
            private string name;
            private string value;
            private Coordinate coordinate;
            private string owner;
            private string userNote; //as user grabs an object, examines it, tries to learn about it, they can leave some note about it maybe? 
            private bool inInventory;

            //anything you can keep in inventory
            public GameObject(string description, string name, string value, Coordinate coordinate, string owner, string userNote, bool inInventory)
            {
                this.description = description;
                this.name = name;
                this.value = value;
                this.coordinate = coordinate;
                this.owner = owner;
                this.userNote = userNote;
                this.inInventory = inInventory;

            }

        }
        //building or unique interactable? --> when a user heads to a coordinate, they ask for a description, it provides a description of all pois, all buildings.
        internal class GamePoi
        {
            private string name;
            private string description;
            //Interactions --> poi is a box, open box, then what? 
            public GamePoi(string name, string description)
            {

                this.name = name;
                this.description = description;

            }
        }
        internal class GameBuilding
        {
            private Coordinate coordinate;
            private string owner;
            private string name;
            private string description;

            public GameBuilding(Coordinate coordinate, string owner, string name, string description)
            {
                this.coordinate = coordinate;
                this.owner = owner;
                this.name = name;
                this.description = description;
            }
        }
        internal class Coordinate
        {
            private int y;
            private int x;

            //so, will have worldgen done at start I guess and not accessible outside the world namespace
            public Coordinate(int y, int x)
            {
                this.y = y;
                this.x = x;
            }
        }
    }
}
