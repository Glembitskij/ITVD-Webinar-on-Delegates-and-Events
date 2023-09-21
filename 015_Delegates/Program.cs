using System;

namespace _015_Delegates
{
    internal class Program
    {
        private sealed class Lambda
        {
            public static readonly Lambda lambda = new Lambda();

            public static Action action;

            internal void Method()
            {
                Console.WriteLine("Hellow!");
            }
        }
        static void Main()
        {
            //Action action = () => { Console.WriteLine("Hellow!"); };

            Action action = Lambda.action ?? (Lambda.action = new Action(Lambda.lambda.Method));
        }
    }
}
