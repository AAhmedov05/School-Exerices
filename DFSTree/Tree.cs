using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSTree
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public List<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
                this.Parent = this;
            }
        }

        public void PrintTheTree(int inception = 0)
        {
            Console.Write(new string(' ',inception*2));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
                child.PrintTheTree(inception + 1);
        }
        public IEnumerable<T> OrderDFS() 
        {
            List<T> order = new List<T>();
            this.DFS(this,order);
            return order; 
        }

        private void DFS(Tree<T> tree, List<T> order) 
        {
            foreach (var child in tree.Children)
            {
                this.DFS(child,order);
            }
            order.Add(tree.Value);
        }
        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);
            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.Value);
                foreach (var child in next.Children)
                {
                    visited.Enqueue(child);
                }
            }
            return order;
        }
    }
}
