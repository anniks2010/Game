using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Arnold Scwartzenegger");
            Player player2 = new Player("Chuck Norris");

            

            for (int i =0; i < 3; i++)
            {
                player2.TakeDamage(player1.MakeDamage());
                player1.TakeDamage(player2.MakeDamage());   

            }
            if (player1.HealthPoints > player2.HealthPoints)
            {
                Console.WriteLine($"Winner is {player1.Name} final health score is {player1.HealthPoints} ");
            }
            else if (player2.HealthPoints > player1.HealthPoints)
            {
                Console.WriteLine($"Winner is {player2.Name} final health score is {player2.HealthPoints} ");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
               
            Console.ReadLine();
        }
    }
}
