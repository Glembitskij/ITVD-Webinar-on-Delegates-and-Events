using System;

namespace _007_Delegates
{
    public delegate void MyGenericDelegate<T>(T argument);
    internal class Program
    {
        static void Main()
        {
            //MyGenericDelegate<string> delegatestring = new MyGenericDelegate<string>(MethodWithStringArg);
            MyGenericDelegate<string> delegatestring = MethodWithStringArg;
            
            delegatestring.Invoke("Hellow");
            delegatestring("Hellow");

            Console.WriteLine(new string('-', 30));

            //MyGenericDelegate<int> delegateint = new MyGenericDelegate<int>(MethodWithIntArg);
            MyGenericDelegate<int> delegateint = MethodWithIntArg;

            delegateint.Invoke(10);
            delegateint(10);

            Console.ReadLine();
        }

        // Метод для сполучення з єкземпляром делегату
        public static void MethodWithStringArg(string argument)
        {
            Console.WriteLine(argument);
        }

        // Метод для сполучення з єкземпляром делегату
        public static void MethodWithIntArg(int argument)
        {
            Console.WriteLine(argument);
        }
    }
}
