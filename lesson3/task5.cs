using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            String chislo;

            chislo = Convert.ToString(Console.ReadLine());

            int a = 0;
            int b = 0;

            foreach (char sim in chislo)
            {
                a++;
            }

            b = 0;

            Char[] arr = new Char[a];

            foreach (char sim in chislo)
            {
                arr[b] = sim;
                b++;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]},");
            }

            Console.Read()
        }
    }
}
