using System;

namespace Evklid_Algoritham
{
    class Program
    {
        static void Main(string[] args)
        {
            //Алгоритъм за намиране най-голямо общо кратно
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Evklid(a,b));
        }
        public static int Evklid(int a, int b)
        {      
            if (a==b)
	        {
                return a;
    	    }
            else
            {
                if (a > b)
                {
                    return Evklid(a-b,b);
                }
                else 
                {
                    return Evklid(a,b - a);
                }
            }
        }
    }
}
