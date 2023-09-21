using System;

namespace Delegates_and_Events
{
    // 1. Створюємо клас делегата
    public delegate void MyDelegate();

    internal class Program
    {
        static void Main()
        {
            // 3. Створення єкземпляру делегату, який сполучено з методом MethodForDelegate
            MyDelegate myDelegate = new MyDelegate(MethodForDelegate);
           
            // 4. Виклик метода, який сполучений з єкземпляром делегату
            myDelegate.Invoke();
            myDelegate();

            Console.ReadLine();
        }

        // 2. Метод для сполучення з єкземпляром делегату
        public static void MethodForDelegate() 
        {
            Console.WriteLine("Hellow from Delegate");
        }
    }
}
