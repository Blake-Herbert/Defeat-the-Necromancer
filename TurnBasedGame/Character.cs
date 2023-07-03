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
            Action = new Dictionary<string, action>();
        }


        public string Name { get; set; }
        public int Health { get; set; }

        public delegate void action(Character actor, Character target);
        public Dictionary<string, action> Action { get; set; }

        public void AddAction(string actionName, action action)
        {
            Action[actionName] = action;
        }
            
        public int Rolld100()
        { 
            Random roll = new Random();
            return  roll.Next(1, 100);
        }
        
    }
}


