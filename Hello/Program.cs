using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            //string name = args[0];
            //Console.WriteLine("Hello" + name);

            //foreach (var i in args)
            //{
            //    Console.WriteLine("Hello," + i);
            //}
            for (int i = 0; i < 10; i++)
            {
                Greetings();
                Calculate();
                Cleaning();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt = " + maxInt);
            Console.WriteLine("MinInt = " + minInt);
            Console.WriteLine("MaxLong = " + maxLong);
            Console.WriteLine("MinLong = " + minLong);
        }

        private static void Cleaning()
        {
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        private static void Calculate()
        {
            Console.Write("Podaj liczbę: ");
            int number;
            //int age = int.Parse(Console.ReadLine());
            bool result = int.TryParse(Console.ReadLine(), out number);
            //number

            //Console.WriteLine("Coś: " + name + ", Liczba: " + number);

            if (number > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Number is positive");
            }
            else if (result == false)
            {
                Console.WriteLine("To nie jest liczba!");
            }
            else Console.WriteLine("Number is negative");
        }

        private static void Greetings()
        {
            Console.Write("Wpisz coś: ");
            //string name;
            string name = Console.ReadLine();
            Console.WriteLine("Coś: " + name);
        }
    }
}
