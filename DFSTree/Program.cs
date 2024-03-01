using System;
using System.Linq;

namespace DFSTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>(7,
                  new Tree<int>(19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(21)),
                  new Tree<int>(21),
                  new Tree<int>(21,
                    new Tree<int>(23),
                    new Tree<int>(6)));
            tree.PrintTheTree();
            Console.WriteLine();
            Console.WriteLine($"BFS:{string.Join('-', tree.BFS().First())}");
            Console.WriteLine($"DFS:{string.Join('-', tree.OrderDFS())}");
            Console.WriteLine($"Count of nodes:{tree.OrderDFS().Count()}");
            Console.WriteLine("I wanna search: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Count of node {number} is {tree.OrderDFS().Where(x=>x==number).Count()}.");
        }
    }
}
