using System;

// Лямбда-вирази в C# - це коротка форма написання анонімних
// методів або делегатів. Вони дозволяють створювати функції
// "на льоту" без явного оголошення методу або делегата.

namespace _013_Delegates
{
    internal class Program
    {
        static void Main()
        {
            // 1 
            //Action printMessage = new Action(PrintMessageMethod);
            //printMessage.Invoke();
            //printMessage();

            // 2 Використовуючи анонімні функції
            //Action printMessage = delegate()
            //{
            //    Console.WriteLine("Початок повідомлення:");
            //    Console.WriteLine("Кінець повідомлення.");
            //};

            // 3 Використовуючи лямбда-оператори в C# 
            //Action printMessage =  ()=>
            //{
            //    Console.WriteLine("Початок повідомлення:");
            //    Console.WriteLine("Кінець повідомлення.");
            //};

            // 4 Використовуючи лямбда-вирази в C# 
            Action printMessage = () => Console.WriteLine("Початок повідомлення:");

            printMessage.Invoke();
            printMessage();

            Console.ReadLine();
        }

        //public static void PrintMessageMethod()
        //{
        //    Console.WriteLine("Початок повідомлення:");
        //    Console.WriteLine("Кінець повідомлення.");
        //}
    }
}
