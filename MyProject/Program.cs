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
            public int minus_xp;

            public bool gameover;

            public Game()
            {

            }

        }

        class Player
        {
            public int player;
            public int xp;
            public int protection;

            public Player(int namber)
            {
                player = namber;
                xp = 100;
                protection = 100;
            }
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
                game.minus_xp = rnd.Next(0, 101);

                if (player_rnd == player_one.player)
                {
                    player_one.xp = (player_one.xp - game.minus_xp) <= 0 ? 0 : player_one.xp - game.minus_xp;

                    if (player_one.xp == 0)
                    {
                        Console.WriteLine("Выиграл 'player_two'");
                        game.gameover = true;
                        break;
                    }
                }
                else
                {
                    player_two.xp = (player_two.xp - game.minus_xp) <= 0 ? 0 : player_two.xp - game.minus_xp;

                    if (player_two.xp == 0)
                    {
                        Console.WriteLine("Выиграл 'player_one'");
                        game.gameover = true;
                        break;
                    }
                }
            }
            Console.Read();
        }

        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
