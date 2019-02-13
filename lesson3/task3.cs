using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class task3
    {
        static void Main(string[] args)
        {
            int from = -10;
            int to = 10;
            int inputRandom = 0;
            String userInput;
            bool rightEnter = false;

            Random rnd = new Random();

            while (!rightEnter)
            {
                Console.WriteLine("Введите любое число от -10 до 10");
                inputRandom = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Для выхода введите 'Выход'");
                userInput = Convert.ToString(Console.ReadLine());

                int randomNumber = rnd.Next(from, to);

                Console.WriteLine(randomNumber);

                if (userInput == "Выход" || inputRandom >= -10 && inputRandom <= 10)
                {
                    rightEnter = true;
                }



            }
        }
    }
}
