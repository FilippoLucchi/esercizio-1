using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyOrPlayer;
using Player;

namespace BlaisePascal.EnemyOrPlayer.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = Console.ReadLine();
        }
    }
}
