using System;

namespace _011_Delegates
{
    internal class Program
    {
        static void Main()
        {
            Func<int> myGeneric0arg = MethodReturnValueNoArgs;
            myGeneric0arg.Invoke();
            myGeneric0arg.Invoke();

            Console.WriteLine(new string('-', 30));

            Func<int, int> myGeneric1arg = MethodReturnValueOneArgument;
            int res1 = myGeneric1arg.Invoke(10);
            res1 = myGeneric1arg(10);

            Console.WriteLine(new string('-', 30));

            Func<int, string, string> myGeneric2arg = MethodReturnValueTwoArgument;
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
