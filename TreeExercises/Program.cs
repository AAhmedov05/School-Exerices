using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeExercises
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        static Tree<int> GetTreeNodeByValue(int value) 
        {
            if (!nodeByValue.ContainsKey(value))
                nodeByValue[value] = new Tree<int>(value);
            
            return nodeByValue[value];
        }

        public static void AddEdge(int parent,int value) 
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(value);

            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }

        static void ReadTree() 
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }

        static void Main(string[] args)
        {
            ReadTree();
            var root = nodeByValue.Values
                .FirstOrDefault(k => k.Parent == null)
                .Value;

            var leaves = nodeByValue.Values
                .Where(k => k.Children.Count == 0)
                .Select(x=>x.Value)
                .OrderBy(x=>x)
                .ToList();

            var intermediateNodes = nodeByValue.Values
                .Where(k => k.Children.Count != 0 && k.Parent!=null)
                .Select(x=>x.Value)
                .OrderBy(x=>x)
                .ToList();
            
            Console.WriteLine($"Root is {root}");
            Console.WriteLine($"Leaves are {string.Join(' ',leaves)}");
            Console.WriteLine($"Intermediate Nodes are {string.Join(' ', intermediateNodes)}");

        }
    }
}
