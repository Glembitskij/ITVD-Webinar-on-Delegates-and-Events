using System;

namespace _008_Delegates
{
    public delegate void MyGenericDelegate();
    public delegate void MyGenericDelegate<T>(T arg1);
    public delegate void MyGenericDelegate<T1, T2>(T1 arg1, T2 arg2);
    public delegate void MyGenericDelegate<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
    public delegate void MyGenericDelegate<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate void MyGenericDelegate<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate void MyGenericDelegate<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    internal class Program
    {
        static void Main()
        {
            MyGenericDelegate myGeneric0arg = MethodNoArguments;
            myGeneric0arg.Invoke();
            myGeneric0arg.Invoke();

            Console.WriteLine(new string('-', 30));

            MyGenericDelegate<string> myGeneric1arg = MethodWithOneArgument;
            myGeneric1arg.Invoke("Hellow");
            myGeneric1arg("Hellow");

            Console.WriteLine(new string('-', 30));

            MyGenericDelegate<string, bool> myGeneric2arg = MethodWithTwoArgument;
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
