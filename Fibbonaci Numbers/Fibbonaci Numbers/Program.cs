using System;

namespace Fibbonaci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(x));
        }

        public static int Fibo(int x) 
        {
            if (x==1||x==2)
            {
                return 1;
            }
            return Fibo(x - 2) + Fibo(x - 1);
        }
    }
}
