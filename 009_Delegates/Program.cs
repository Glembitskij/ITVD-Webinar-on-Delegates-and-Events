using System;

namespace _009_Delegates
{
    internal class Program
    {
        static void Main()
        {
            Action myGeneric0arg = MethodNoArguments;
            myGeneric0arg.Invoke();
            myGeneric0arg.Invoke();

            Console.WriteLine(new string('-', 30));

            Action<string> myGeneric1arg = MethodWithOneArgument;
            myGeneric1arg.Invoke("Hellow");
            myGeneric1arg("Hellow");

            Console.WriteLine(new string('-', 30));

            Action<string, bool> myGeneric2arg = MethodWithTwoArgument;
            myGeneric2arg.Invoke("Hellow", true);
            myGeneric2arg("Hellow", true);

            Console.ReadLine();
        }

        public static void MethodNoArguments()
        {
            Console.WriteLine("Hellow");
        }

        public static void MethodWithOneArgument(string arg1)
        {
            Console.WriteLine(arg1);
        }

        public static void MethodWithTwoArgument(string arg1, bool arg2)
        {
            Console.WriteLine(string.Concat(arg1, arg2));
        }
    }
}
