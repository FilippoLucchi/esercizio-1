using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Giocatore.domain;
using System.Xml.Linq;

namespace BlaisePascal.EnemyOrPlayer.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Mario", 1, 0, 100, 100, true, 0);
            Console.WriteLine($"Il giocatore è vivo? {player.IsAlive}");

            player.TakeDamage(30);

            Console.WriteLine($"Il giocatore è vivo? {player.IsAlive}");

            player.AddExperience(150);

            Console.WriteLine($"Esperienza dopo l'aggiunta: {player.Experience}");

            player.AddGold(50);
            Console.WriteLine($"Oro del giocatore: {player.Gold}");

            player.TakeDamage(30);

            player.AddHealth(20);

            player.TakeDamage(100);

            Console.WriteLine($"Il giocatore è vivo? {player.IsAlive}");

            player.ResetHealth();

            player.ResetExperience();
        }


    }
    
}
