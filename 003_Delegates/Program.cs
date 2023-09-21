using System;

namespace _003_Delegates
{
    // 1. Створюємо клас делегата
    public delegate void MyDelegate(string argument);

    internal class Program
    {
        static void Main()
        {
            // 4. Створення єкземпляру классу в якому знаходится метод для сполучення з делегатом
            ClassWithDelegate withDelegate = new ClassWithDelegate();

            // 5. Створення єкземпляру делегату, який сполучено з методом MethodWithArgument
            MyDelegate myDelegate = new MyDelegate(withDelegate.MethodWithArgument);

            // 6. Виклик метода, який сполучений з єкземпляром делегату
            myDelegate.Invoke("Hellow from Delegate");
            myDelegate("Hellow from Delegate");

            Console.ReadLine();
        }
    }

    // 2. Створення классу 
    class ClassWithDelegate
    {
        // 3. Метод для сполучення з єкземпляром делегату, з аргументом
        public void MethodWithArgument(string argument)
        {
            Console.WriteLine(argument);
        }
    }
}
