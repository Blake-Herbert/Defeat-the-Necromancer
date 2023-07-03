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

		public static void Fireball(Character caster, Character target)
		{
			int attackRoll = caster.Rolld100();
			if (attackRoll >= 40)
			{
				target.Health -= 3;
				DisplayMessage($"Fireball hit {target} for 3 damage");
			}
			else
			{ DisplayMessage("Fireball missed");}
		}


		public static void LightningBolt(Character caster, Character target)
		{
			int attackRoll = caster.Rolld100();
			if(attackRoll >= 10)
			{
				target.Health -= 1;
				DisplayMessage("Lightning Bolt hit for 1 damage");
			}
			else
			{
				Console.Clear();
				Console.WriteLine($"{attackRoll}.");
			}
		}
	}
}
