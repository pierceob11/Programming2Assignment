using System;

namespace ProgrammingAssignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string command;
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

			if (command == "Create player" || command == "Create Player" || command == "create player") 
			{
				playerFunction (); //Call player creation
			}

			if (command == "Create NPC" || command == "Create npc" || command == "create npc") 
			{
				createNPC ();
			}



		}

		public void playerFunction()
		{
			Player player1 = new Player ();
			Console.WriteLine ("What is your name?");
			player1.playerName = Console.ReadLine ();
			player1.playerX =  rnd.Next (1, 100);
			player1.playerY = rnd.Next (1, 100);
			Console.WriteLine ("Your current position is x = {0} , y = {1}", player1.playerX , player1.playerY);
			Console.WriteLine ("Type 'Create NPC'");
			command = Console.ReadLine ();
		}

	}
	//Player Class creation
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
		Random rnd1 = new Random();
	}
}
