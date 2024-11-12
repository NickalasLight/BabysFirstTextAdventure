
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
