using System;

namespace _010_Delegates
{
    public delegate TResult MyGenericDelegate<TResult>();
    public delegate TResult MyGenericDelegate<T, TResult>(T arg);
    public delegate TResult MyGenericDelegate<T1, T2, TResult>(T1 arg1, T2 arg2);
    public delegate TResult MyGenericDelegate<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
    public delegate TResult MyGenericDelegate<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate TResult MyGenericDelegate<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
   
    internal class Program
    {
        static void Main()
        {
            MyGenericDelegate<int> myGeneric0arg = MethodReturnValueNoArgs;
            myGeneric0arg.Invoke();
            myGeneric0arg.Invoke();

            Console.WriteLine(new string('-', 30));

            MyGenericDelegate<int, int> myGeneric1arg = MethodReturnValueOneArgument;
            int res1 = myGeneric1arg.Invoke(10);
            res1 = myGeneric1arg(10);

            Console.WriteLine(new string('-', 30));

            MyGenericDelegate<int, string, string> myGeneric2arg = MethodReturnValueTwoArgument;
            string res2 = myGeneric2arg.Invoke(10, "Hellow");
            res2 = myGeneric2arg(10, "Hellow");

            Console.ReadLine();
        }

        public static int MethodReturnValueNoArgs()
        {
            return 10;
        }

        public static int MethodReturnValueOneArgument(int arg)
        {
            return arg * 20;
        }

        public static string MethodReturnValueTwoArgument(int arg1, string arg2)
        {
            return string.Concat(arg1, arg2);
        }
    }
}
