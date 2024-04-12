using System;
using System.Linq;

namespace ExamTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(24,
                new Tree<int>(34,
                    new Tree<int>(15),
                    new Tree<int>(7)),
                new Tree<int>(25),
                new Tree<int>(13,
                    new Tree<int>(37),
                    new Tree<int>(66)),
                new Tree<int>(55,
                    new Tree<int>(53),
                    new Tree<int>(76),
                    new Tree<int>(84))
                );

            tree.PrintTheTree();
            Console.WriteLine($"DFS:{string.Join(' ',tree.OrderDFS())}");
            Console.WriteLine($"Count of nodes:{tree.OrderDFS().Where(x=>x%5!=0).Count()}");
        }
    }
}
