using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int from_xp = 0; //
            int to_xp = 100;

            int player_1 = 1;
            int fplayer_2 = 2;

            int player_xp1 = 100;
            int player_xp2 = 100;

            int minus_xp = 0;

            bool fight = true;

            int player_rnd = 1;

            Random rnd = new Random();

            while (fight)
            {
                player_rnd = rnd.Next(1, 3);
                minus_xp = rnd.Next(from_xp, to_xp);

                if(player_rnd == 1)
                {
                    player_xp1 = (player_xp1 - minus_xp)<=0 ? 0 : player_xp1 - minus_xp;

                    if (player_xp1 == 0)
                    {
                        Console.WriteLine("Выиграл 'player_2'");
                        break;
                    }
                }
                else
                {
                    player_xp2 =(player_xp1 - minus_xp)<=0 ? 0 : player_xp1 - minus_xp;

                    if (player_xp2 == 0)
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
