using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            String chislo;

            chislo = Convert.ToString(Console.ReadLine());

            foreach (char i in chislo)
            {
                Console.Write($"{i},");
            }

            Console.Read();
        }
    }
}
