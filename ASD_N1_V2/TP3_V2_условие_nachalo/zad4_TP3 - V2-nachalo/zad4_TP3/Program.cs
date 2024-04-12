using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_TP3

{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
       
        static Tree<int> GetTreeNodeByValue(int value)
        {
            if(!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }
            return nodeByValue[value];
        }

        public static void AddEdge(int parent,int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);
            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }

        static void Main(string[] args)
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }

            //a)намиране на корена на дървото
            Console.WriteLine($"Корен: {nodeByValue.FirstOrDefault().Key}");
                                                                
            //b)намиране на вътрешните възли на дървото
            var nodes = nodeByValue
                .Where(x => x.Value.Parent != null && x.Value.Children.Count()!=0)
                .Select(x => x.Key)
                .OrderBy(x=>x)
                .ToList();
            
            Console.WriteLine($"Вътрешни възли: {string.Join(" ", nodes)}");
        }
    }
}
