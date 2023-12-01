using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static string[] element;
        static bool[] used;
        static string[] vari;

        public static void Variations(int index)
        {
            if (index >= vari.Length)
                Console.WriteLine($"({string.Join(',', vari)})");
            else
            {
                for (int i = 0; i < element.Length; i++)
                {
                    if (!used[i])
                    {
                        vari[index] = element[i];
                        used[i] = true;
                        Variations(index + 1);
                        used[i] = false;
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            element = Console.ReadLine().Split(',').ToArray();
            used = new bool[element.Length];
            vari = new string[3];
            Variations(0);
        }
    }
}
