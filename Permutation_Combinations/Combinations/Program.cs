using System;

namespace Combinations
{
    class Program
    {
        static int[] elements;
        static int[] comb;

        public static void Combinations(int index,int start)
        {
            if (index >= comb.Length)
                Console.Write("(" + string.Join(", ", comb) + "), ");
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                        comb[index] = elements[i];
                        Combinations(index + 1, i+1);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = i + 1;
            }
            comb = new int[k];
            Combinations(0,0);
        }
    }
}
