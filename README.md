https://platform.openai.com/docs/api-reference/making-requests --> we will start with the python,
and run everything locally for now. 

An api, that talks to an api, might seem kinda dumb, but provides the ability to switch out llms or services with a personally hosted llm, multiagent llm, or something from hugging face. 

The primary concern is that I want to be able to have separate llms, or at least separate contexts for the same llm. To create more realism, we really don't want the german npc in the bike shop understanding everything i asked the translator inside the broken time machine. 

For now we can run everything locally, with the game itself communicating with our llm api that is hosted local. Will test various options there. But, I need to understand the basics of what I can both do, and what I will need for the game from the perspective of llm useage




llm 1 --> batch of text commands instead of like classic text games, the goal being to fine tune a model to convert the text to the proper command set. 
Best infrastructure for using an llm that is meant to more easily translate human text to be useable by the switch statement in the interpreter class. I go into the neartest toolstore, I ask the shopkeeper "Wie Viel Kostet" and I buy a wrench with my money --> instead of, Enter ToolShop, Grab Wrench, Talk to ShopOwner, Speak "Wie Viel Kostet?", Pay 10 euro,

llm2 --> The "TimeMachine" is providing translations for phrases
llm3 --> is the ai for the npc's

all of these can be the same or different llms, but are the 3 specific use cases for llms that I can currently see as being potentially useful. 

----> seems like a pretty reasonable usecase for an llm, presumably training it to create a series of commands from an input that can be executed in order. 


--------

So....


1. Will start with basic world gen, maybe 4 blocks.
2. Terminal at starting location is primary interaction with the "time machine"
3. Is a connection to the best llm, maybe we have to use chatgpt4, and from here we can have the nexus for learning vocab, sentences, and maybe some "print" function
4. Basic game goal is to fix the machine, but there are multiple endings
5. We want to motivate the user to learn, we want to reward them for learning, and we want it to be such that they don't just open their own chatgpt in a second window
6. I think a way to track progress, will be a big piece
7. I think some sort of language grading/testing to give some unoffficial language level. Can also be useful
8. Will want the interaction with the terminal/time machine to be interesting. 
9. Everything needs a lot of cleanup, of course. 


-----

Create user class --> check
Create basic class that just builds simple world --> transition to json config or other config language based world construction. 
create terminal in main poi. 
Integration of an llm is probably easiest with chatgpt4 per now, and we can dedicate maybe 50 euro for this purpose for now. 
Basic movement
Also, basic means of displaying world state to user.

--------

So far chatgpt is the most accessible, and the most popular, but for learning about llm use, finetuning, etc.
using some opensource stuff is going to be a lot more useful I think. I think for now, sticking with the most basic of instruction sets, and just setting up and testing the main "terminal" is going to be the next step. 

I think we will essentially start with this --> I don't like the .net to chatgpt library, and should just learn the best way for us to use it ourselves with python. In some extreme case we will create our own api that is using python to talk the the gpt api and connecting to our c# terminal that is hosted as some webapp. Tonight I will test that some basic functionality works, and then from there focus on chatgpt as a expensive prototype stand in. But, I don't feel like spending $5 a user per hour they play or something, but we will log input/output tokens and costs per hour for our own testing. 