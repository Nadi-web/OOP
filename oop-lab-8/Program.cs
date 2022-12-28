using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            User us1 = new User("Person1", 0, 0);
            User us2 = new User("Person2", 0, 0);
            User us3 = new User("Person3", 0, 0);
            User us4 = new User("Person4", 0, 0);
            User us5 = new User("Person5", 0, 0);
            User us6 = new User("Person6", 0, 0);

            us1.anon += (message) =>
            {
                Console.WriteLine("Вы вызвали анонимную функцию!");
            };

            us1.Squeeze += DisplayMessage;                                                  // обработчик для события Squeeze
            us1.Replace += DisplayMessage;                                                  // обработчик для события Replace
            us1.ChangingBias(10);
            us1.ChangingMovement(20);
            Console.WriteLine($"Сжатие {us1.Name} составило {us1.Bias}, а растяжение {us1.Moving}\n");

            us2.Squeeze += DisplayMessage;
            us2.Replace += DisplayMessage;
            us2.ChangingBias(55);
            us2.ChangingMovement(64);
            Console.WriteLine($"Сжатие {us2.Name} составило {us2.Bias}, а растяжение {us2.Moving}\n");

            us3.Squeeze += DisplayMessage;
            us3.Replace += DisplayMessage;
            us3.ChangingBias(222);
            us3.ChangingMovement(69);
            Console.WriteLine($"Сжатие {us3.Name} составило {us3.Bias}, а растяжение {us3.Moving}\n");



            Console.WriteLine("\n\n\n--------------Работа со строками--------------\n");

            Func<string, string> A;
            string str = "J/o y.   ------l,, i n e";

            Console.WriteLine($"Исходная строка:        {str}");

            A = StringMethods.RemovePunctionMarks;
            Console.WriteLine($"Без знаков препинания:  {str = A(str)}");

            A = StringMethods.RemoveSpase;
            Console.WriteLine($"Без пробелов:           {str = A(str)}");

            A = StringMethods.Upper;
            Console.WriteLine($"Заглавными буквами:     {str = A(str)}");

            A = StringMethods.Lower;
            Console.WriteLine($"Строчными буквами:      {str = A(str)}");

            A = StringMethods.AddToString;
            Console.WriteLine($"С добавлением символа:  {str = A(str)}");

            Console.ReadKey();
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}