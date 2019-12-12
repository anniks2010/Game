using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_player
{
    class Player
    {
        string name;
        int healthPoints;

        public Player(string _name)
        {
            Random rnd = new Random();
            healthPoints = rnd.Next(100, 151);
            name = _name;
            
        }
        public string Name
        {
            get { return name; }
        }
        public int HealthPoints
        {
            get { return healthPoints; }
        }
        public int MakeDamage()
        {
            Random rnd = new Random();
            int damage= rnd.Next(10, 51);
            return damage;
        }
        public void TakeDamage(int damage)
        {
         
                healthPoints -= damage;
            

            
            Console.WriteLine($"{healthPoints}");

        }

    }
}
