using System;

namespace DynamicBackpack
{
    class Program
    {
        const int countOfElements = 8;
        const int maxWeightOfBackpack = 7;

        static int[] elemetnsWeight = new int[] { 0, 3, 7, 6, 1, 2, 4, 5, 5 };
        static int[] elementsPrice = new int[] { 0, 5, 3, 9, 1, 1, 2, 5, 2 };
        static int result = 0;
        static int KnapSack(int n, int c) 
        {
            
            if (n == 0 || c == 0) return 0;
            else if (elemetnsWeight[n] > c) return KnapSack(n - 1, maxWeightOfBackpack);
            else 
            {
                var temp = KnapSack(n-1,c);
                var temp2 = elementsPrice[n] + KnapSack(n - 1, maxWeightOfBackpack - elemetnsWeight[n]);
                result = Math.Max(temp, temp2);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(KnapSack(countOfElements, maxWeightOfBackpack));
        }
    }
}
