using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class EnterNum
    {
        public delegate void EnterNumDelegate(int num);
        public event EnterNumDelegate EnterNumEvent;

        public void Read() 
        {
            Console.WriteLine("Введите число 1, если хотите отсортировать фамилии по алфавиту.\n" +
                "Введите число 2, если хотите отсортировать фамилии в порядке Я-А. ");
            Console.WriteLine();
            int num = Convert.ToInt32(Console.ReadLine());

            if (num != 1 && num != 2) throw new FormatException();
            EnterNumEvent(num);
        }

        protected virtual void EnteredNum(int num) 
        {
            EnterNumEvent?.Invoke(num);
        }
    }
}
