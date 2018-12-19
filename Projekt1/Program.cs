using System;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            //puste wartości i 2 średniki (bo pętla for tego wymaga) daje efekt nieskończonego zapętlenia
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("Podaj wiek: ");

            //Parse - standardowy proces parsowania
            //TryParse - zwraca typ logiczny | 2 argumenty: 1. skąd; 2. do czego przypisać 

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo jesteś pełnoletni!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś błędny wiek!");
            }
            else
            {
                Console.WriteLine("No, you not adult.");
            }
        }

        /// <summary>
        /// Powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            //WriteLine - zostaje wyświetlony napis w jednej linii i kursor przechodzi do następnej
            //Write     - zostaje wyświetlony napis w jednej linii i kursor pozostaje w niej
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
