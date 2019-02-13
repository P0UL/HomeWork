using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool perem_bool = true;

            byte perem_byte = 1;

            short perem_short = 2;

            int perem_int = 3;

            uint perem_uint = 4;

            long perem_long = 5;

            float perem_float = 1.0f;

            double perem_double = 5.0;

            string perem_string = "lesson2";

            Console.WriteLine($"Значение переменной 'perem_bool' = {perem_bool}");
            Console.WriteLine($"Размер типа 'bool' = {sizeof(bool)}");
            //System.Type type = typeof(bool);
            Console.WriteLine($"Тип  переменной = {perem_bool.GetType()}");

            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_byte' = {perem_byte}");
            Console.WriteLine($"Размер типа 'byte' = {sizeof(byte)}");
            Console.WriteLine($"Тип  переменной = {perem_byte.GetType()}");

            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'short' = {perem_short}");
            Console.WriteLine($"Размер типа 'short' = {sizeof(short)}");
            Console.WriteLine($"Тип  переменной = {perem_short.GetType()}");


            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_int' = {perem_int}");
            Console.WriteLine($"Размер типа 'int' = {sizeof(int)}");
            Console.WriteLine($"Тип  переменной = {perem_int.GetType()}");

            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_uint' = {perem_uint}");
            Console.WriteLine($"Размер типа 'unit' = {sizeof(uint)}");
            Console.WriteLine($"Тип  переменной = {perem_uint.GetType()}");

            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_long' = {perem_long}");
            Console.WriteLine($"Размер типа 'long' = {sizeof(long)}");
            Console.WriteLine($"Тип  переменной = {perem_long.GetType()}");


            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_float' = {perem_float}");
            Console.WriteLine($"Размер типа 'float' = {sizeof(float)}");
            Console.WriteLine($"Тип  переменной = {perem_float.GetType()}");

            Console.WriteLine("");

            Console.WriteLine($"Значение переменной 'perem_double' = {perem_double}");
            Console.WriteLine($"Размер типа 'double' = {sizeof(double)}");
            Console.WriteLine($"Тип  переменной = {perem_double.GetType()}");

            Console.WriteLine("");
            Console.WriteLine("Введите ФИО");
            FIO();

            Console.WriteLine("");
            Console.WriteLine("Калькулятор");
            Calculator();

            Console.ReadKey();

        }
        static void FIO()
        {
            String F;
            F = Convert.ToString(Console.ReadLine());

            String I;
            I = Convert.ToString(Console.ReadLine());

            String O;
            O = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"{F} {I} {O}");


        }

        static void Calculator()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            b = Convert.ToInt32(Console.ReadLine());

            String c;
            c = Convert.ToString(Console.ReadLine());

            if (c == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (c == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (c == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (c == "/" && a != 0 && b != 0)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
