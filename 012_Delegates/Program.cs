using System;

// Анонімні функції - це концепція, яка була доступна в C#
// до появи лямбда-виразів і лямбда-операторів
namespace _012_Delegates
{
    internal class Program
    {
        static void Main()
        {
            // 1 
            Action printMessage = new Action(PrintMessageMethod);
            printMessage.Invoke();
            printMessage();

            // 2 Використовуючи анонімні функції
            //Action printMessage = delegate()
            //{
            //    Console.WriteLine("Початок повідомлення:");
            //    Console.WriteLine("Кінець повідомлення.");
            //};

            //printMessage.Invoke();
            //printMessage();

            Console.ReadLine();
        }

        public static void PrintMessageMethod()
        {
            Console.WriteLine("Початок повідомлення:");
            Console.WriteLine("Кінець повідомлення.");
        }
    }
}
