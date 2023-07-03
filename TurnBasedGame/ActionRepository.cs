using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public static class ActionRepository
	{
		public static void DisplayMessage(string message)
		{
			Console.Clear();
			Console.WriteLine(message);
			Console.ReadKey();
		}

		public static void Fireball(Character actor, Character target)
		{
			DisplayMessage($"{actor.Name} used Fireball!");
			int attackRoll = actor.Rolld100();
			if (attackRoll >= 40)
			{
				int attackDamage = 3;
				target.Health -= attackDamage;
				DisplayMessage($"It hit {target.Name} for {attackDamage} damage");
			}
			else 
			{ 
				DisplayMessage("Fireball missed");
			}
		}


		public static void LightningBolt(Character actor, Character target)
		{
			DisplayMessage($"{actor.Name} used Lightning Bolt!");
			if (actor.Rolld100() >= 10)
			{
				int attackDamage = 1;
				target.Health -= attackDamage;
				 DisplayMessage($"It hit {target.Name} for {attackDamage} damage");
			}
			else 
			{ 
				DisplayMessage("Lightning Bolt missed!");
			}
		}

		public static void Swipe(Character actor, Character target) 
		{
			DisplayMessage($"{actor.Name} used Swipe!");
			if (actor.Rolld100() >= 50)
			{
				int attackDamage = 1;
				target.Health -= attackDamage;
				DisplayMessage($"Swipe hit {target.Name} for {attackDamage} damage");
			}
			else 
			{ 
				DisplayMessage($"Swipe missed!");
			}
		}
	}
}
