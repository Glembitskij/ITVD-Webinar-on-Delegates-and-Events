using System;

namespace _002_Delegates
{
    // 1. Створюємо клас делегата
    public delegate void MyDelegate();
    
    internal class Program
    {
        static void Main()
        {
            // 4. Створення єкземпляру классу в якому знаходится метод для сполучення з делегатом
            ClassWithDelegate withDelegate = new ClassWithDelegate();
            
            // 5. Створення єкземпляру делегату, який сполучено з методом MethodForDelegate
            MyDelegate myDelegate = new MyDelegate(withDelegate.MethodForDelegate);

            // 6. Виклик метода, який сполучений з єкземпляром делегату
            myDelegate.Invoke();
            myDelegate();

            Console.ReadLine();
        }
    }

    // 2. Створення классу 
    class ClassWithDelegate
    {
        // 3. Метод для сполучення з єкземпляром делегату
        public void MethodForDelegate()
        {
            Console.WriteLine("Hellow from Delegate");
        }
    }
}
