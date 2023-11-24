using System;

namespace Variations
{
    class Program
    {
        static int[] elements;
        static bool[] used;
        static int[] vari;

        public static void Variations(int index)
        {
            if (index >= vari.Length)
                Console.Write("(" + string.Join(", ", vari) + "), ");
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        var currentElement = elements[i];
                        used[i] = true;
                        vari[index] = currentElement;

                        Variations(index + 1);
                        used[i] = false;
                    }
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
            used = new bool[elements.Length];
            vari = new int[k];
            Variations(0);
        }
    }
}
