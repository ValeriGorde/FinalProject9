using System;
using System.IO;

namespace FinalProject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Exception exception = new Exception("Собственное исключение");
            Exception exception1 = new FormatException();
            Exception exception2 = new DivideByZeroException();
            Exception exception3 = new RankException();
            Exception exception4 = new DirectoryNotFoundException();
            Exception[] exceptions = { exception, exception1, exception2, exception3, exception4 };

            foreach (Exception ex in exceptions) 
            {
                try 
                {
                    throw ex;
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Ошибка: {0}",e.Message);
                }
            }

        }
    }
}
