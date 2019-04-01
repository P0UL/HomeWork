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

            public int xp_player_one = 100;
            public int xp_player_two = 100;

            public int minus_xp = 0;

            public bool gameover = false;

            public int player_rnd = 1;
        }

        class Player
        {
            public int player;

            public Player(int namber)
            {
                player = namber;
            }
        }

        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            Game game = new Game();
            Player player_one = new Player(1);
            Player player_two = new Player(2);
            int player_rnd = 0;

            Random rnd = new Random();

            while (!game.gameover)
            {
                player_rnd = rnd.Next(0, 3);
                game.minus_xp = rnd.Next(game.from_xp, game.to_xp);

                if (player_rnd == player_one.player)
                {
                    game.xp_player_one = (game.xp_player_one - game.minus_xp) <= 0 ? 0 : game.xp_player_one - game.minus_xp;

                    if (game.xp_player_one == 0)
                    {
                        Console.WriteLine("Выиграл 'player_two'");
                        game.gameover = true;
                        break;
                    }
                }
                else
                {
                    game.xp_player_two = (game.xp_player_one - game.minus_xp) <= 0 ? 0 : game.xp_player_one - game.minus_xp;

                    if (game.xp_player_two == 0)
                    {
                        Console.WriteLine("Выиграл 'player_one'");
                        game.gameover = true;
                        break;
                    }
                }
            }
            Console.Read();
        }

    }
}
