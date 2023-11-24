using System;

namespace Permutation_Combinations
{
    class Program
    {
        static int[] elements;
        static bool[] used;
        static int[] perm;

        public static void Permute(int index) 
        {
            if (index >= elements.Length)
                Console.Write("(" + string.Join(", ", perm) + "), ");
            else 
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        var currentElement = elements[i];
                        used[i] = true;
                        perm[index] = currentElement;

                        Permute(index + 1);
                        used[i] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = i + 1;
            }
            used = new bool[elements.Length];
            perm = new int[elements.Length];
            Permute(0);
        }
    }
}
