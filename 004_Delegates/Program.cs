using System;

namespace _004_Delegates
{
    // 1. Створюємо клас делегата
    public delegate string MyDelegate(string argument);

    internal class Program
    {
        static void Main()
        {
            // 4. Створення єкземпляру классу в якому знаходится метод для сполучення з делегатом
            ClassWithDelegate withDelegate = new ClassWithDelegate();

            // 5. Створення єкземпляру делегату, який сполучено з методом MethodWithArgAndReturnValue
            MyDelegate myDelegate = new MyDelegate(withDelegate.MethodWithArgAndReturnValue);

            // 6. Виклик метода та отримання результату.
            string firstResult = myDelegate.Invoke("Hellow from Delegate");
            string secondResult = myDelegate("Hellow from Delegate");

            // 7. Вивід результату роботи методу
            Console.WriteLine(firstResult);
            Console.WriteLine(secondResult);

            Console.ReadLine();
        }
    }

    // 2. Створення классу 
    class ClassWithDelegate
    {
        // 3. Метод для сполучення з єкземпляром делегату, з аргументом
        // та повертаємим значенням
        public string MethodWithArgAndReturnValue(string name)
        {
            return $"Hellow {name} !";
        }
    }
}
