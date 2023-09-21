using System;

namespace _006_Delegates
{
    public delegate int MyDel(int arg1, int rg2);

    internal class Program
    {
        private sealed class Lambda
        {
            public static readonly Lambda lambda = new Lambda();

            public static MyDel _myDel;

            internal int Method(int x, int y)
            {
                Console.WriteLine(x + y);
                return x + y;
            }
        }
        static void Main()
        {
            MyDel myDel = (x, y) =>
            {
                Console.WriteLine(x + y);
                return x + y;
            };

            myDel -= (x, y) =>
            {
                Console.WriteLine(x + y);
                return x + y;
            };


            //MyDel myDel = Lambda._myDel ?? (Lambda._myDel = new MyDel(Lambda.lambda.Method));

            myDel.Invoke(10, 10);

            Console.ReadKey();

        }
    }
}
