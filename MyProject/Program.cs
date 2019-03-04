using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {

        class Game
        {
            public int from_xp = 0;
            public int to_xp = 100;

            public int player_xp1 = 100;
            public int player_xp2 = 100;

            public int player_1 = 1;
            public int player_2 = 2;

            public int minus_xp = 0;

            public bool fight = true;

            public int player_rnd = 1;
        }

        static void Main(string[] args)
        {
            Game game = new Game();

            Random rnd = new Random();

            while (game.fight)
            {
                game.player_rnd = rnd.Next(1, 3);
                game.minus_xp = rnd.Next(game.from_xp, game.to_xp);

                if(game.player_rnd == 1)
                {
                    game.player_xp1 = (game.player_xp1 - game.minus_xp)<=0 ? 0 : game.player_xp1 - game.minus_xp;

                    if (game.player_xp1 == 0)
                    {
                        Console.WriteLine("Выиграл 'player_2'");
                        break;
                    }
                }
                else
                {
                    game.player_xp2 =(game.player_xp1 - game.minus_xp)<=0 ? 0 : game.player_xp1 - game.minus_xp;

                    if (game.player_xp2 == 0)
                    {
                        Console.WriteLine("Выиграл 'player_1'");
                        break;
                    }
                }
            }
            Console.Read();
        }
    }
}
