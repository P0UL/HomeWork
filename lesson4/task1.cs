using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class task1
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Введите целое число:");

            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        array[0] = 1;
                    }
                    else array[i] = array[i-1] + i;
                }
                Console.WriteLine(array[n-1]);
            }
            else Console.WriteLine("Число должно быть > 0");


            Console.Read();
        }
    }
}
