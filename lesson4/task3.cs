using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class task3
    {
        static void task_()
        {
            //Rectangle();

            //Circle();

            Triangle();

            Console.Read();
        }

        static void Rectangle()
        {
            Console.WriteLine("Для расчета площади прямоугольника введите два числа:");

            int a = 0;
            int b = 0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * b);
        }

        static void Circle()
        {
            Console.WriteLine("Для расчета площади окружности введите число:");

            int r = 0;
            
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(3.14 * Math.Sqrt(r));
        }

        static void Triangle()
        {
            Console.WriteLine("Для расчета площади треугольника введите высоту и длину одной из сторон:");

            int h = 0;
            int b = 0;

            h = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(h/2 * b);
        }

    }
}
