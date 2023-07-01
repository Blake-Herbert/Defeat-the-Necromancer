using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public static class ActionRepository
	{
		public static void Fireball(Character caster, Character target)
		{
			Random random = new Random();
			int attackRoll = random.Next(1, 100);
			Console.WriteLine("You rolled " +  attackRoll);
			Console.ReadKey();
			if (attackRoll >= 40)
			{
				target.Health = target.Health - 3;
				Console.Clear();
				Console.WriteLine("Fireball hit for 3 damage");
				Console.ReadKey();
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Fireball missed");
				Console.ReadKey();
			}
		}


			public static void IceLance(Character caster, Character target)
		{
			
		}
	}
}
