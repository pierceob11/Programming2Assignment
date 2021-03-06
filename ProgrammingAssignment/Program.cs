using System;

namespace ProgrammingAssignment
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			//MAIN BODY
			string command;
			object[] npcArray = new object[5];
			Player player1 = new Player ();
			NPC npc1 = new NPC ();
			NPC npc2 = new NPC ();
			NPC npc3 = new NPC ();
			NPC npc4 = new NPC ();
			NPC npc5 = new NPC ();
			//Player player1 = new Player ();
			//int npcCounter = 0;
			//Intro
			Console.WriteLine ("Welcome player...");
			Console.WriteLine ("");
			Console.WriteLine ("Your commands are as follows...");
			Console.WriteLine ("1. Create player");
			Console.WriteLine ("2. Create NPC");
			Console.WriteLine ("3. Shoot");
			Console.WriteLine ("4. Move");
			Console.WriteLine ("5. Query NPC");
			Console.WriteLine ("6. Request Alliance");
			Console.WriteLine ("7. Print player status");
			Console.WriteLine ("8. Print NPC status");
			Console.WriteLine ("");

				Console.WriteLine ("Begin by typing 'Create player'"); //Begin

				command = Console.ReadLine ();

			//Create player
			if (command == "Create player" || command == "Create Player" || command == "create player") 
			{
				Console.WriteLine ("What is your name?");
				player1.playerName = Console.ReadLine ();
				Console.WriteLine ("Okay, {0}. Your current position is x = {1} , y = {2}", player1.playerName , player1.playerX , player1.playerY);
				Console.WriteLine ("Type 'Create NPC'");
			} 
			else //Not valid input
			{
				Console.WriteLine ("Try again...");
			}

			command = Console.ReadLine ();

			//Create NPC's
			if (command == "Create NPC" || command == "Create npc" || command == "create npc") 
			{
				Console.WriteLine ("What do you want to name this NPC?");
				npc1.npcName = Console.ReadLine ();
				Console.WriteLine ("This NPC's name is {0}, and they are at x = {1} , y = {2}", npc1.npcName, npc1.npcX, npc1.npcY);
				//Type
				//Backstory
				Console.WriteLine("Would you like to create another NPC?");
				Console.WriteLine ("Yes / No");
			}
			else //Not valid input
			{
				Console.WriteLine ("Try again...");
				command = Console.ReadLine ();
			}

			command = Console.ReadLine ();

			//CREATE NPC 2
			if (command == "Yes" || command == "yes") 
			{
				Console.WriteLine ("What do you want to name this NPC?");
				npc2.npcName = Console.ReadLine ();
				Console.WriteLine ("This NPC's name is {0}, and they are at x = {1} , y = {2}", npc2.npcName, npc2.npcX, npc2.npcY);
				//Type
				//Backstory
				Console.WriteLine("Would you like to create another NPC?");
				Console.WriteLine ("Yes / No");
			} 
			else 
			{
				Console.WriteLine ("What do you want to do next");
				command = Console.ReadLine ();
			}

			command = Console.ReadLine ();

			//CREATE NPC 3
			if (command == "Yes" || command == "yes") 
			{
				Console.WriteLine ("What do you want to name this NPC?");
				npc3.npcName = Console.ReadLine ();
				Console.WriteLine ("This NPC's name is {0}, and they are at x = {1} , y = {2}", npc3.npcName, npc3.npcX, npc3.npcY);
				//Type
				//Backstory
				Console.WriteLine("Would you like to create another NPC?");
				Console.WriteLine ("Yes / No");
			} 
			else 
			{
				Console.WriteLine ("What do you want to do next");
				command = Console.ReadLine ();
			}

			command = Console.ReadLine ();

			//CREATE NPC 4
			if (command == "Yes" || command == "yes") 
			{
				Console.WriteLine ("What do you want to name this NPC?");
				npc4.npcName = Console.ReadLine ();
				Console.WriteLine ("This NPC's name is {0}, and they are at x = {1} , y = {2}", npc4.npcName, npc4.npcX, npc4.npcY);
				//Type
				//Backstory
				Console.WriteLine("Would you like to create another NPC?");
				Console.WriteLine ("Yes / No");
			} 
			else 
			{
				Console.WriteLine ("What do you want to do next");
				command = Console.ReadLine ();
			}

			command = Console.ReadLine ();

			//CREATE NPC 5
			if (command == "Yes" || command == "yes") 
			{
				Console.WriteLine ("What do you want to name this NPC?");
				npc5.npcName = Console.ReadLine ();
				Console.WriteLine ("This NPC's name is {0}, and they are at x = {1} , y = {2}", npc5.npcName, npc5.npcX, npc5.npcY);
				//Type
				//Backstory
				Console.WriteLine("You now have the maximum number of NPC's");
				Console.WriteLine ("What would you like to do next?");
			} 
			else 
			{
				Console.WriteLine ("What do you want to do next");
				command = Console.ReadLine ();
			}

			command = Console.ReadLine ();
				
			//Shoot
			if (command == "Shoot" || command == "shoot") 
			{
				//Shoot function
			}

			command = Console.ReadLine ();

			//Move
			if (command == "move" || command == "Move") 
			{
				//Move function
				Console.WriteLine("What is your new position?");
				Console.WriteLine ("Enter your X position and ENTER, followed by your Y position and ENTER");
				//player1.playerX = Console.ReadLine ();
				//player1.playerY = Console.ReadLine ();
				player1.playerHP--; //Lose one HP
				Console.WriteLine ("Ouch, you lose 1 HP");
			}

			//Query NPC
			if (command == "Query npc" || command == "query npc" || command == "Query NPC") 
			{
				string queryNPC;
				Console.WriteLine ("What NPC do you want to query? Type their name");
				//Ask for name
				queryNPC = Console.ReadLine();
				//USE SWITCH STATMENT TO CHECK FOR NAME
				//Print RANDOMLY assigned backstory
			}

			command = Console.ReadLine ();

			//Request Alliance
			if (command == "Request Alliance" || command == "request alliance" || command == "Request alliance") 
			{
				Console.WriteLine ("Who do you want to attempt to ally with?");
				//If NPC is enemy, minus 2 HP, set status to enemy
				/*
				if (status = enemy) 
				{
					player1.playerHP -= 2;
					Console.WriteLine ("NPC is an enemy");
				}
				//If NPC is friendly, set status to friendly
				if (status = friendly) 
				{
					Console.WriteLine ("NPC is friendly, and now an ally!");
				}
				*/
			}

			command = Console.ReadLine ();

			//Print Player Status
			if(command == "Print Player Status" || command == "print player status" || command == "Print player status")
			{
				Console.WriteLine("Your current HP is: {0}", player1.playerHP);
				Console.WriteLine("You currently have {0} ammo", player1.ammo);
				Console.WriteLine("Your current position is x = {0} , y = {1}", player1.playerX, player1.playerY);
			}

			command = Console.ReadLine();

			//Print NPC status
			if (command == "Print NPC status" || command == "print npc status" || command == "Print NPC Status") 
			{
				//Need to do five more times
				Console.WriteLine ("{0}, has {1} HP , is a friend, and is xxx metres away", npc1.npcName, npc1.npcHP);
			}


		} //End of Main fuction

		//FUNCTIONS

	}//End of Main class
	//CLASSES

	public class Player
	{
		//Field
		public int playerHP;
		public string playerName;
		public int ammo;
		public int playerX, playerY;
		Random rnd = new Random ();

		//Constructor

		public Player()
		{
			playerHP = 10;
			ammo = 50;
			playerX = rnd.Next (1, 100);
			playerY = rnd.Next (1, 100);
		}
	}
	//NPC class creation
	public class NPC
	{
		//Field
		public bool status;
		public int npcX, npcY;
		public int npcHP;
		public string npcName;
		public string[] backstory;
		Random rnd1 = new Random();

		//Constructor
		public NPC()
		{
			npcX = rnd1.Next (1, 100);
			npcY = rnd1.Next (1, 100);
			//status = null;
			npcHP = 10;
			/*
			backstory [0] = "They’re a mute so they won’t be much help to you. Not of any danger to you and are a friendly";
			backstory [1] = "A big brute of a being. They were put in here because they’re a danger to society, but their hands are cuffed behind their back so they’re not much danger to you";
			backstory [2] = "This one’s scared out of their mind. They hunched down on the ground the minute they saw your gun";
			backstory [3] = "A short, skinny, blond teenager. Looks quite confused and is looking around at the others. Has had their back to you since the experiment began";
			backstory [4] = "A corporate looking businessman dressed in a suit, slicked back hair, expensive suit. Has been yelling angry complaints since he was dropped in claiming to sue";
			backstory [5] = "Short kid. Could be anywhere between the age of twelve to sixteen. Difficult to tell in the dim light. Looks surprisingly unconcerned about their confusing and unknown situation.";
			*/
		}
	}
}
		
