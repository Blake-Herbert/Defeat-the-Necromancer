using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public class Character
    {
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
            Spells = new Dictionary<string, SpellAction>();
        }


        public string Name { get; set; }
        public int Health { get; set; }
        public delegate void SpellAction(Character caster, Character target);
        public Dictionary<string, SpellAction> Spells { get; set; }

        public void AddAction(string actionName, SpellAction action)
        {
            Spells[actionName] = action;
        }




        
        }
    }


