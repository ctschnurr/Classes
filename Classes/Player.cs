using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        // fields

        public int x;
        public int y;
        public int health;
        public int shield;
        public int lives;
        public string name;

        // methods

        public void TakeDamage(int hp)
        {
            health -= hp; // (short form for "health = health - hp")
        }
        public Player() // constructor
        {
            x = 0;
            y = 0;
            health = 50;
            shield = 0;
            lives = 3;
            name = "Newbie";

            Console.WriteLine("Player Created!");
        }
    }
}
