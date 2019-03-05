using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {

        /*enum Playrs : int
        {
            player_one = 1,
            player_two = 2,

        }*/


        class Game
        {
            public int from_xp = 0;
            public int to_xp = 100;

            public int player_xp1 = 100;
            public int player_xp2 = 100;

            public int minus_xp = 0;

            public bool gameover = true;

            public int player_rnd = 1;

            

        }

        class Player
        {
            public int player_one = 1;
            public int player_two = 2;
        }

        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            Game game = new Game();
            Player player = new Player();

            Random rnd = new Random();

            while (game.gameover)
            {
                game.player_rnd = rnd.Next(0, 3);
                game.minus_xp = rnd.Next(game.from_xp, game.to_xp);

                if (game.player_rnd == player.player_one)
                {
                    game.player_xp1 = (game.player_xp1 - game.minus_xp) <= 0 ? 0 : game.player_xp1 - game.minus_xp;

                    if (game.player_xp1 == 0)
                    {
                        Console.WriteLine("Выиграл 'player_two'");
                        break;
                    }
                }
                else
                {
                    game.player_xp2 = (game.player_xp1 - game.minus_xp) <= 0 ? 0 : game.player_xp1 - game.minus_xp;

                    if (game.player_xp2 == 0)
                    {
                        Console.WriteLine("Выиграл 'player_one'");
                        break;
                    }
                }
            }
            Console.Read();



        }

    }
}
