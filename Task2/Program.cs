using System;

namespace Task2
{
    internal class Program
    {
        public static string[] surnames = { "Иванов", "Абрамова", "Сидорчева", "Гнипель", "Шаманова" };
        static void SortInOrder(string[] surname)
        {
            Array.Sort(surname);
            foreach (var per in surname) 
            {
                Console.WriteLine(per);
            }
        }

        static void SortReverse(string[] surname)
        {
            Array.Sort(surname);
            Array.Reverse(surname);
            foreach (var per in surname)
            {
                Console.WriteLine(per);
            }
        }

        static void ShowResult(int num) 
        {
            switch (num) 
            {
                case 1:
                    SortInOrder(surnames);
                    break;
                case 2:
                    SortReverse(surnames);
                    break;
            }
        }

        static void Print(string[] surname) 
        {
            Console.WriteLine("Список фамилий:");
            for (int i = 0; i < surname.Length; i++) 
            {
                Console.WriteLine(surname[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            EnterNum enterNum = new EnterNum();
            enterNum.EnterNumEvent += ShowResult;

            try
            {
                Print(surnames);
                enterNum.Read();
            }
            catch (FormatException) 
            {
                Console.WriteLine("Вы ввели неверное значение.");
            }

        }
    }
}
