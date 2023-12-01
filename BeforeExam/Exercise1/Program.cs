using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static string[] element;
        static string[] comb;

        public static void Combinations(int index,int start) 
        {
            if (index>=comb.Length)
                Console.WriteLine($"({string.Join(',',comb)})");
            else { 
                for (int i = start; i < element.Length; i++)
                {
                    comb[index] = element[i];
                    Combinations(index + 1,i+1);
                }
            }
        }
        static void Main(string[] args)
        {
            element = Console.ReadLine().Split(',').ToArray();
            comb = new string[4];
            Combinations(0,0);
        }
    }
}
